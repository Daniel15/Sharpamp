using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Daniel15.Sharpamp
{
	/// <summary>
	/// Internal class containing all the Win32 calls used.
	/// </summary>
	internal class Win32
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		internal static extern IntPtr SendMessage(IntPtr hWnd, UInt32 msg, IntPtr wParam, IntPtr lParam);
		[DllImport("user32.dll")]
		internal static extern IntPtr SendMessage(IntPtr hWnd, UInt32 msg, Int32 wParam, Int32 lParam);
		[DllImport("user32.dll")]
		internal static extern IntPtr SendMessage(IntPtr hWnd, UInt32 msg, IntPtr wParam, Int32 lParam);
		[DllImport("user32.dll", SetLastError = true)]
		internal static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
		[DllImport("user32")]
		internal static extern IntPtr SetWindowLong(IntPtr hWnd, int nIndex, Win32WndProc newProc);
		internal delegate int Win32WndProc(IntPtr hWnd, int msg, int wParam, int lParam);
		[DllImport("user32")]
		internal static extern IntPtr SetWindowLong(IntPtr hWnd, int nIndex, IntPtr newProc);
		[DllImport("user32")]
		internal static extern int CallWindowProc(IntPtr lpPrevWndFunc, IntPtr hWnd, int msg, int wParam, int lParam);

		// SendMessage override for getting song information
		[DllImport("user32.dll")]
		internal static extern IntPtr SendMessage(IntPtr hWnd, UInt32 msg, ref extendedFileInfoStructW wParam, Int32 lParam);

		// Constants
		internal const int WM_USER = 0x0400;
		internal const int WM_COMMAND = 0x111;
		internal const int GWL_WNDPROC = -4;

		// Structs
		[StructLayout(LayoutKind.Sequential)]
		internal struct extendedFileInfoStructW
		{
			[MarshalAs(UnmanagedType.LPWStr)]
			public string Filename;
			[MarshalAs(UnmanagedType.LPWStr)]
			public string Metadata;
			[MarshalAs(UnmanagedType.LPWStr)]
			public string Ret;
			public Int32 RetLen;
		}
	}
}
