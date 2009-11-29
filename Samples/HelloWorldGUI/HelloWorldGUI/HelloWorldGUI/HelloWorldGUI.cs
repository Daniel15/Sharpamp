using System;
using System.Windows.Forms;

namespace HelloWorldGUI
{
	public class HelloWorldGUI : Daniel15.Sharpamp.GeneralPlugin
	{
		public override string Name
		{
			get { return "Hello World C# Plugin (with GUI!)"; }
		}

		public override void Initialize()
		{
			//System.Windows.Forms.MessageBox.Show("Hello World!");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new frmTest(Winamp));
			(new frmTest(Winamp)).Show();
		}
	}
}
