using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MDCLogArchitecture.Models.DomainModels;

using MDCLogArchitecture.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace MDCLogArchitecture.RazorPages.Pages.Comments.CommentTypes
{
    public class CommentTypesIndexModel : PageModel
    {
        private CommentTypeServices _service { get; }

        public List<CommentType> CommentTypes { get; set; }

        public CommentTypesIndexModel(CommentTypeServices service)
        {
            _service = service;
        }
        public void OnGet()
        {
            CommentTypes = _service.FindTypeList();

        }
    }
}