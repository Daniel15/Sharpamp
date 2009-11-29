using System;

namespace Daniel15.Sharpamp
{
	/// <summary>
	/// A generic Winamp plugin. Do not use this unless you are making a Winamp
	/// plugin. Generic Winamp plugins should inherit from this class.
	/// </summary>
	public abstract class GeneralPlugin
	{
		protected Winamp Winamp { get; private set; }

		/// <summary>
		/// Name of the plugin
		/// </summary>
		public abstract string Name { get; }

		/// <summary>
		/// Called when the plugin should be initialized
		/// </summary>
		public abstract void Initialize();

		/// <summary>
		/// Configure the plugin. May open a configuration dialog, or just do
		/// nothing.
		/// </summary>
		public virtual void Config()
		{
			// By default, show a messagebox
			System.Windows.Forms.MessageBox.Show("This plugin has no configuration options.",
				"Winamp Plugin Configuration",
				System.Windows.Forms.MessageBoxButtons.OK,
				System.Windows.Forms.MessageBoxIcon.Information);
		}

		/// <summary>
		/// Quit the plugin
		/// </summary>
		public virtual void Quit()
		{
			
		}

		/// <summary>
		/// Internal initialisation routine
		/// </summary>
		public void Init(IntPtr hWnd)
		{
			Winamp = new Winamp(hWnd);
			Initialize();
		}
	}
}
