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
    public class CreateCommentTypeModel : PageModel
    {
        private readonly ILogger<CreateCommentTypeModel> _logger;
        private readonly CommentTypeService _service;
        public CreateCommentTypeModel(ILogger<CreateCommentTypeModel> logger, CommentTypeService service)
        {
            _service = service;
            _logger = logger;
        }
        [BindProperty]
        public CommentType ThisCommentType { get; set; }
        public void OnGet()
        {
           
        }
        public IActionResult OnPost()
        {
            _service.InsertType(ThisCommentType);
            _logger.LogInformation($"User created {ThisCommentType.CommentTypeCode}");

            return RedirectToPage("./CommentTypesIndex");
        }
    }
}