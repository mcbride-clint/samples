using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MDCLogArchitecture.Models.DomainModels;

using MDCLogArchitecture.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MDCLogArchitecture.Domain.Interfaces;

namespace MDCLogArchitecture.RazorPages.Pages.Comments.CommentTypes
{
    public class CommentTypesIndexModel : PageModel
    {
        private CommentTypeService _service { get; }

        public List<ICommentType> CommentTypes { get; set; }

        public CommentTypesIndexModel(CommentTypeService service)
        {
            _service = service;
        }
        public void OnGet()
        {
            CommentTypes = _service.FindTypeList();

        }
    }
}