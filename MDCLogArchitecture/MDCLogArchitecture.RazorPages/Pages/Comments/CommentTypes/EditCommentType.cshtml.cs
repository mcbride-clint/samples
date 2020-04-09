using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace MDCLogArchitecture.RazorPages.Pages.Comments.CommentTypes
{
    public class EditCommentTypeModel : PageModel
    {
        private readonly ILogger<EditCommentTypeModel> _logger;
        private readonly CommentTypeService _service;
        public EditCommentTypeModel(ILogger<EditCommentTypeModel> logger, CommentTypeService service)
        {
            _service = service;
            _logger = logger;
        }
        [BindProperty]
        public CommentType ThisCommentType { get; set; }
        
        public void OnGet(string CommentTypeCode)
        {
            ThisCommentType = _service.FindType(CommentTypeCode);
            _logger.LogInformation($"User opened {CommentTypeCode} for editing");

        }
        public IActionResult OnPost()
        {
            _service.EditType(ThisCommentType);
            _logger.LogInformation($"User edited {ThisCommentType.CommentTypeCode}");

            return RedirectToPage("./CommentTypesIndex");
        }
    }
}