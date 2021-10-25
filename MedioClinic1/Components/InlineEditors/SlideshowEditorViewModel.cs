using MedioClinic1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XperienceAdapter.Models;

namespace MedioClinic1.Components.InlineEditors
{
	public class SlideshowEditorViewModel : InlineEditorViewModel
	{
		/// <summary>
		/// Swiper ID.
		/// </summary>
		public string? SwiperId { get; set; }

		/// <summary>
		/// Images from the media library.
		/// </summary>
		public IEnumerable<MediaLibraryFile>? Images { get; set; }

		/// <summary>
		/// Info about the media library in use.
		/// </summary>
		public MediaLibraryViewModel? MediaLibraryViewModel { get; set; }
	}
}
