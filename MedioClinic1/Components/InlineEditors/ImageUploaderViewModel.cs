using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MedioClinic1.Models;

namespace MedioClinic1.Components.InlineEditors
{
    public class ImageUploaderViewModel : InlineEditorViewModel
    {
        public int? PageId { get; set; }

        public bool HasImage { get; set; }

        public MediaLibraryViewModel? MediaLibraryViewModel { get; set; }
    }
}
