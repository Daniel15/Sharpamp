using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace Daniel15.Sharpamp
{
	/// <summary>
	/// Winamp API for C#. Allows controlling of Winamp.
	/// </summary>
	public class Winamp
	{
		// Window handle for the Winamp window
		private IntPtr _WinampWindow;
		// Did we load "in process" (ie. as a plugin). If we're not a plugin,
		// some things will be unavailable!
		private readonly bool _InProcess;
		// Window subclassing stuff
		private IntPtr _OldWinampWndProc = IntPtr.Zero;
		private Win32.Win32WndProc _WinampWndProc;

		#region Winamp API
		
		private const int WM_WA_IPC = Win32.WM_USER;

		// Callbacks
		private const int IPC_PLAYING_FILE = 3003;
		private const int IPC_CB_MISC = 603;
		private const int IPC_CB_MISC_TITLE = 0;
		private const int IPC_CB_MISC_STATUS = 2;

		/// <summary>
		/// Winamp window  title, for if we have to search for it (ie, we're not
		/// using this as a plugin)
		/// </summary>
		private const string WINAMP_TITLE = "Winamp v1.x";

		/// <summary>
		/// IPC commands we can send to Winamp
		/// </summary>
		protected enum IPCCommand
		{
			GetVersion = 0,
            IsPlaying = 104,
			GetFilename = 3031,
			GetTitle = 3034,
			ExtendedFileInfo = 3026,
		}

		/// <summary>
		/// Misc commands we can send to Winamp
		/// </summary>
		protected enum Command
		{
			Play = 40045,
			PlayPause = 40046,
			Stop = 40047,
			PrevTrack = 40198,
			NextTrack = 40048,
		}
		#endregion

		/// <summary>
		/// Occurs when the currently playing song has been changed
		/// </summary>
		public event SongChangedEventHandler SongChanged;
		/// <summary>
		/// Occurs when the playing status changes
		/// </summary>
		public event StatusChangedEventHandler StatusChanged;

		/// <summary>
		/// Gets the currently playing song
		/// </summary>
		public Song CurrentSong { get; private set; }

		private Status _Status;
		/// <summary>
		/// Gets the current Winamp status
		/// </summary>
		public Status Status
		{
			get
			{
				return _Status;
			}

			private set
			{
				// Was it not actually changed?
				if (_Status == value)
					return;

				_Status = value;
				// Raise the event
				if (StatusChanged != null)
					StatusChanged(this, new StatusChangedEventArgs(value));
			}
		}

		/// <summary>
		/// Create a new instance of the Winamp class
		/// </summary>
		/// <param name="hWnd">Window handle of Winamp</param>
		public Winamp(IntPtr hWnd)
		{
			_WinampWindow = hWnd;
			_InProcess = true;
			Init();
		}

		/// <summary>
		/// Create a new instance of the Winamp class. If invoked with no window
		/// handle, we try to find Winamp ourselves. This is so it can be used
		/// outside of a Winamp plugin
		/// </summary>
		public Winamp()
		{
			// TODO: More testing. A lot of things will NOT work in this mode!
 
			// Let's try to find Winamp
			_WinampWindow = Win32.FindWindow(WINAMP_TITLE, null);
			if (_WinampWindow.ToInt32() == 0)
				throw new Exception("Could not find Winamp instance.");

			_InProcess = false;
			Init();
		}

		/// <summary>
		/// Initialise the Winamp class. Called from the constructor
		/// </summary>
		private void Init()
		{
			// Let's set up debugging, if we're in debug mode!
			#if DEBUG
				string debugDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
				string debugFile = Path.Combine(debugDir, "winamp-cs-debug.txt");
				Debug.Listeners.Add(new TextWriterTraceListener(new StreamWriter(debugFile, true)));
				Debug.AutoFlush = true;
				Debug.WriteLine("hWnd: " + _WinampWindow);
			#endif

			// Start with a blank "currently playing" song
			CurrentSong = new Song();
			// Update the song data
			UpdateSongData();

			// And now, let's set up our subclassing. We can only do this if we're
			// "in process", so let's bail if we're not.
			if (!_InProcess)
			{
				// TODO: This should not be a messagebox. This is just for debugging.
				System.Windows.Forms.MessageBox.Show("Not running 'in process', certain features will not work!");
				return;
			}

			// Here's our delegate
			_WinampWndProc = new Win32.Win32WndProc(WinampWndProc);
			// Make sure it doesn't get garbage collected
			GC.KeepAlive(_WinampWndProc);
			// Let's go ahead and set the new one, saving the old one
			_OldWinampWndProc = Win32.SetWindowLong(_WinampWindow, Win32.GWL_WNDPROC, _WinampWndProc);
			Debug.WriteLine("Subclassed Winamp window (old proc = " + _OldWinampWndProc + ", new proc = " + _WinampWndProc +")");
		}

		~Winamp()
		{
			// Better remove this
			if (_InProcess)
				Win32.SetWindowLong(_WinampWindow, Win32.GWL_WNDPROC, _OldWinampWndProc);
		}

		/// <summary>
		/// Handle a message from the playlist window
		/// </summary>
		/// <param name="hWnd">Window handle of playlist</param>
		/// <param name="msg">Message type</param>
		/// <param name="wParam">wParam</param>
		/// <param name="lParam">lParam</param>
		/// <returns></returns>
		private int WinampWndProc(IntPtr hWnd, int msg, int wParam, int lParam)
		{
			if (msg == WM_WA_IPC)
			{
				// A message we want?
				if (lParam == IPC_CB_MISC)
				{
					// A title notification?
					if (wParam == IPC_CB_MISC_TITLE)
					{
						UpdateSongData();
					}
					// A status notification?
					else if (wParam == IPC_CB_MISC_STATUS)
					{
						Status status = (Status)SendIPCCommandInt(IPCCommand.IsPlaying);
						Debug.WriteLine("Status = " + status);
						Status = status;
					}

				}
			}

			// Pass this message to the old handler
			return Win32.CallWindowProc(_OldWinampWndProc, hWnd, msg, wParam, lParam);
		}

		#region Commands
		/// <summary>
		/// Send a command to Winamp via SendMessage()
		/// </summary>
		/// <param name="command">Command to send</param>
		/// <returns>Return value of command</returns>
		protected IntPtr SendIPCCommand(IPCCommand command)
		{
			//return SendMessage(_WinampWindow, WM_WA_IPC, (Int32) command, 0);
			return Win32.SendMessage(_WinampWindow, WM_WA_IPC, 0, (Int32)command);
		}

		/// <summary>
		/// Send an IPC command to Winamp via SendMessage(), and return an int result
		/// </summary>
		/// <param name="command">Command to send</param>
		/// <returns>Return value of command</returns>
		protected int SendIPCCommandInt(IPCCommand command)
		{
			return Win32.SendMessage(_WinampWindow, WM_WA_IPC, 0, (Int32)command).ToInt32();
		}

		/// <summary>
		/// Send a command to Winamp via SendMessage(), and receive a string result
		/// </summary>
		/// <param name="command">Command to send</param>
		/// <returns>Return value of command</returns>
		protected string SendIPCCommandString(IPCCommand command)
		{
			return Marshal.PtrToStringAuto(Win32.SendMessage(_WinampWindow, WM_WA_IPC, 0, (Int32)command));
		}

		/// <summary>
		/// Send a command to Winamp via SendMessage()
		/// </summary>
		/// <param name="command"></param>
		protected void SendCommand(Command command)
		{
			Debug.WriteLine("Sending command " + command);
			Win32.SendMessage(_WinampWindow, Win32.WM_COMMAND, (Int32)command, 0);
		}

		/// <summary>
		/// Start playing the current song
		/// </summary>
		public void Play()
		{
			SendCommand(Command.Play);
		}

		/// <summary>
		/// Stop playing the current song
		/// </summary>
		public void Stop()
		{
			SendCommand(Command.Stop);
		}
		
		/// <summary>
		/// If currently playing, pause playback. If currently paused or stopped,
		/// start playing.
		/// </summary>
		public void PlayPause()
		{
			SendCommand(Command.PlayPause);
		}

		/// <summary>
		/// Go to the previous track
		/// </summary>
		public void PrevTrack()
		{
			SendCommand(Command.PrevTrack);
		}

		/// <summary>
		/// Go to the next track
		/// </summary>
		public void NextTrack()
		{
			SendCommand(Command.NextTrack);
		}

		/// <summary>
		/// Get the version of Winamp
		/// </summary>
		/// <returns>Version number (eg. 5.56)</returns>
		public string GetVersion()
		{
			int version = SendIPCCommand(IPCCommand.GetVersion).ToInt32();
			return String.Format("{0}.{1}", (version & 0x0000FF00) >> 12, version & 0x000000FF);
		}

		// TODO: Version string
		#endregion

		/// <summary>
		/// Update the data about the currently playing song
		/// </summary>
		private void UpdateSongData()
		{
			// Get the current title
			//string title = SendIPCCommandString(IPCCommand.GetTitle);
            // Get
			string filename = SendIPCCommandString(IPCCommand.GetFilename);
			Debug.WriteLine("Filename = " + filename);

			// Here's all our data.
			bool hasMetadata = true;
			string title = GetMetadata(filename, "title");
			string artist = "";
			string year = "";
			string album = "";

			// If the title is blank, we don't have any metadata :(
			// Better just get whatever Winamp gives us as the "title", and save
			// that.
			if (String.IsNullOrEmpty(title))
			{
				title = SendIPCCommandString(IPCCommand.GetTitle);
				hasMetadata = false;
			}

			// Only update the data if it's changed
			/* TODO: This is a hack. What if the title is the same, but the 
			 * artist or album is different? It won't be counted as a change
			 * I need to think of a better way of doing this.
			 */
			if (CurrentSong.Title == title)
				return;

			// Get all our extra metadata, if we can
			if (hasMetadata)
			{
				artist = GetMetadata(filename, "artist");
				year = GetMetadata(filename, "year");
				album = GetMetadata(filename, "album");
			}

			// Save the new song
			Song song = new Song{
				HasMetadata = hasMetadata,
				Filename = filename,
				Title = title,
				Artist = artist,
				Album = album,
				Year = year
			};
			CurrentSong = song;

			// Invoke the "song changed" method
			if (SongChanged != null)
				SongChanged(this, new SongChangedEventArgs(song));
		}

		/// <summary>
		/// Get metadata about a song.
		/// </summary>
		/// <param name="filename">Filename</param>
		/// <param name="tag">Tag to get</param>
		/// <returns>Data contained in this tag</returns>
		private string GetMetadata(string filename, string tag)
		{
			// Create our struct
			Win32.extendedFileInfoStructW data = new Win32.extendedFileInfoStructW();
			data.Metadata = tag;
			data.Filename = filename;
			data.Ret = new string('\0', 256);
			data.RetLen = 256;
			// Let's fire it off!
			Win32.SendMessage(_WinampWindow, WM_WA_IPC, ref data, (int)IPCCommand.ExtendedFileInfo);
			Debug.WriteLine(tag + " = " + data.Ret);
			return data.Ret;
		}
	}

	#region Events
	public delegate void SongChangedEventHandler(object sender, SongChangedEventArgs e);
	public class SongChangedEventArgs : EventArgs
	{
		public Song Song { get; private set; }
		public SongChangedEventArgs(Song song)
		{
			Song = song;
		}
	}

	public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);
	public class StatusChangedEventArgs : EventArgs
	{
		public Status Status { get; private set; }
		public StatusChangedEventArgs(Status status)
		{
			Status = status;
		}

	}
	#endregion

	// TODO: Move to new class
	public enum Status
	{
		Stopped = 0,
		Playing = 1,
		Paused = 3
	}
}
