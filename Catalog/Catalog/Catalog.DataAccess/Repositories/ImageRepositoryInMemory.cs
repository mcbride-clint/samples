using Catalog.Models.DomainModels;
using Catalog.Models.Filters;
using Catalog.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Catalog.DataAccess.Repositories
{
    public class ImageRepositoryInMemory : IImageRepository
    {
        private readonly List<Image> Images;
        public ImageRepositoryInMemory()
        {
            // May Only work in Testing
            var rootDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            var dummyData = File.ReadAllText(rootDirectory + "\\Catalog.DataAccess\\DummyData\\Image.json");
            Images = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Image>>(dummyData);
        }
        public void Delete(int imageId)
        {
            var existingItem = Images.Single(i => i.ImageListId == imageId);
            Images.Remove(existingItem);
        }

        public Image Find(int imageId)
        {
            return Images.Single(i => i.ImageListId == imageId);
        }

        public IEnumerable<Image> Find(ImageFilter filter)
        {
            var matchedImages = Images.AsEnumerable();

            if (filter.ImageId.HasValue)
                matchedImages = matchedImages.Where(i => i.ImageId == filter.ImageId);
            if (filter.ImageListId.HasValue)
                matchedImages = matchedImages.Where(i => i.ImageListId == filter.ImageListId);

            return matchedImages;
        }

        public Image Insert(Image entity)
        {
            entity.ImageId = Images.Max(i => i.ImageId);
            Images.Add(entity);

            return entity;
        }

        public Image Update(Image entity)
        {
            var existingImage = Images.Single(i => i.ImageId == entity.ImageId);

            existingImage.Title = entity.Title;
            existingImage.Description = entity.Description;
            existingImage.ImageListId = entity.ImageListId;
            existingImage.ImageData = entity.ImageData;

            return entity;
        }
    }
}
