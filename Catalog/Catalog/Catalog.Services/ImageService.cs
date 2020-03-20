using Catalog.Models.DomainModels;
using Catalog.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Services
{
    public class ImageService
    {
        private readonly IImageRepository _imageRepo;

        public ImageService(IImageRepository imageRepo)
        {
            _imageRepo = imageRepo;
        }

        public IEnumerable<Image> GetImages(int imageListId)
        {
            return _imageRepo.Find(new Models.Filters.ImageFilter() { ImageListId = imageListId });
        }
    }
}
