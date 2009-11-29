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
using Daniel15.Sharpamp;

namespace HelloWorldGUI
{
	public partial class frmTest : Form
	{
		private Winamp Winamp;

		public frmTest(Winamp winamp)
		{
			InitializeComponent();
			Winamp = winamp;
		}

		private void cmdPlay_Click(object sender, EventArgs e)
		{
			Winamp.Play();
		}

		private void cmdStop_Click(object sender, EventArgs e)
		{
			Winamp.Stop();
		}

		private void cmdPrev_Click(object sender, EventArgs e)
		{
			Winamp.PrevTrack();
		}

		private void cmdNext_Click(object sender, EventArgs e)
		{
			Winamp.NextTrack();
		}

		private void cmdPlayPause_Click(object sender, EventArgs e)
		{
			Winamp.PlayPause();
		}

		private void frmTest_Load(object sender, EventArgs e)
		{
			Winamp.SongChanged += Winamp_SongChanged;
			Winamp.StatusChanged += Winamp_StatusChanged;

			// Update all the data with initial data, so we don't have a
			// blankish form on startup
			UpdateData(Winamp.CurrentSong);
		}

		private void Winamp_StatusChanged(object sender, StatusChangedEventArgs e)
		{
			// Inefficient, but is fine for a demo :P
			// String.Concat is faster than using + when there's many variables
			// involved.
			txtLog.Text = String.Concat(DateTime.Now, ": Status changed: ", e.Status, "\r\n", txtLog.Text);
			lblStatus.Text = "Status: " + e.Status;
		}

		private void Winamp_SongChanged(object sender, SongChangedEventArgs e)
		{
			txtLog.Text = String.Concat(DateTime.Now, ": Song changed: ", e.Song.Title, "\r\n", txtLog.Text);
			UpdateData(e.Song);
		}

		private void UpdateData(Song song)
		{
			// Update the labels
			lblHasMetadata.Text = "Has Metadata? " + (song.HasMetadata ? "Yes" : "No");
			lblTitle.Text = "Title: " + song.Title;
			lblArtist.Text = "Artist: " + song.Artist;
			lblAlbum.Text = "Album: " + song.Album;
			lblFilename.Text = "Filename: " + song.Filename;
			lblYear.Text = "Year: " + song.Year;
		}
	}
}
