Sharpamp 1.0 Beta - Create Winamp plugins in C#
===============================================
By Daniel15 - http://dan.cx/

https://github.com/Daniel15/Sharpamp

Download: https://github.com/Daniel15/Sharpamp/releases/download/release-0.1.0/Sharpamp.0.1.Beta.exe

Sharpamp allows you to easily write Winamp plugins in C#. It provides a library for access to the
Winamp API, and a Visual Studio template for creating Winamp plugins. It **requires** you to have 
Visual Studio 2008 (2005 or 2010 might work, but they have not yet been tested). Take a look at the
[Getting Started](https://github.com/Daniel15/Sharpamp/wiki/Getting-Started) article to see how 
simple it is to get started :)

It supports some basic functionality of the Winamp API, with more coming in the future:  
![Intellisense Menu](http://stuff.dan.cx/images/projects/sharpamp/intellisense.png)

Handling song changes uses standard C# events, and is as simple as:

	public override void Initialize()
	{
		Winamp.SongChanged += Winamp_SongChanged;
	}

	void Winamp_SongChanged(object sender, Daniel15.Sharpamp.SongChangedEventArgs e)
	{
		MessageBox.Show("The song changed to " + e.Song.Title);
	}

A demonstration of what you can do with Sharpamp is shown in the [HelloWorldGUI](https://github.com/Daniel15/Sharpamp/wiki/HelloWorldGUI) sample (included in the download)

Requirements:
=============
 - Visual Studio 2008 (should work in 2005 as well as 2010 beta, but this has not been tested yet)
   - C# and C++ both have to be installed
 - Winamp

License
=======
Sharpamp is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Sharpamp is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with Sharpamp.  If not, see <http://www.gnu.org/licenses/>.
