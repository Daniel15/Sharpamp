/*
 * Sharpamp version 0.1 beta
 * $Id$
 * Copyright (C) 2009, Daniel Lo Nigro (Daniel15) <daniel at d15.biz>
 * 
 * This file is part of Sharpamp.
 * 
 * Sharpamp is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * Sharpamp is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public License
 * along with Sharpamp.  If not, see <http://www.gnu.org/licenses/>.
 */
using System;

namespace Daniel15.Sharpamp
{
	/// <summary>
	/// A generic Winamp plugin. Do not use this unless you are making a Winamp
	/// plugin. Generic Winamp plugins should inherit from this class.
	/// </summary>
	public abstract class GeneralPlugin
	{
		/// <summary>
		/// Access to the Winamp API
		/// </summary>
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
