using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Models.DomainModels;
using Catalog.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Catalog.Pages.Designator
{
    public class ViewModel : PageModel
    {
        private readonly DesignatorService _designatorService;
        private readonly ImageService _imageService;

        public Models.DomainModels.Designator thisDesignator { get; set; }
        public IEnumerable<Image> Images { get; set; }
        public ViewModel(DesignatorService service, ImageService imageService)
        {
            _designatorService = service;
            _imageService = imageService;
        }
        public void OnGet(int designatorId)
        {
            thisDesignator = _designatorService.Get(designatorId);
            Images = _imageService.GetImages(thisDesignator.ImageListId);
        }
    }
}