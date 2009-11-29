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

namespace Daniel15.Sharpamp
{
	/// <summary>
	/// Information about a song.
	/// </summary>
	public class Song
	{
		/// <summary>
		/// Title of the song
		/// </summary>
		public string Title { get; internal set; }
		/// <summary>
		/// Artist of the song
		/// </summary>
		public string Artist { get; internal set; }
		/// <summary>
		/// Album of the song
		/// </summary>
		public string Album { get; internal set; }
		/// <summary>
		/// Year of the song
		/// </summary>
		public string Year { get; internal set; }
		/// <summary>
		/// Whether the song has any metadata. If false, only the title will be
		/// available.
		/// </summary>
		public bool HasMetadata { get; internal set; }
		/// <summary>
		/// Filename of the song
		/// </summary>
		public string Filename { get; internal set; }
	}
}
