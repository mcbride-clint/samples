using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Models.DomainModels
{
    public class Image
    {
        public int ImageId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] ImageData { get; set; }
    }
}
