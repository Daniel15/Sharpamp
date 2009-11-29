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
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			(new frmTest(Winamp)).Show();
		}
	}
}
