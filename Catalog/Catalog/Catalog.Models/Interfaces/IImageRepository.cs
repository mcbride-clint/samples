using Catalog.Models.DomainModels;
using Catalog.Models.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Models.Interfaces
{
    public interface IImageRepository
    {
        Image Find(int imageId);
        IEnumerable<Image> Find(ImageFilter filter);
        Image Insert(Image entity);
        Image Update(Image entity);
        void Delete(int imageId);
    }
}
