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
