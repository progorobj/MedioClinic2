using System;
using Kentico.Content.Web.Mvc;

using System.Collections.Generic;
using System.Text;

namespace XperienceAdapter.Models
{
	/// <summary>
	/// Media library file.
	/// </summary>
	public class MediaLibraryFile
	{
		public Guid Guid { get; set; }

		public string? Name { get; set; }

		public IMediaFileUrl? MediaFileUrl { get; set; }

		public string? Extension { get; set; }

		public bool IsImage { get; set; }

		public int Width { get; set; }

		public int Height { get; set; }
	}
}
