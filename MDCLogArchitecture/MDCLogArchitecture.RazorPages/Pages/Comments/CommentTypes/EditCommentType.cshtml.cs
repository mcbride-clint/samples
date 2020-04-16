using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MDCLogArchitecture.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

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

        [BindProperty]
        [Required]
        public string CommentTypeCode { get; set; }
        [BindProperty]
        [Required]
        public string TypeDesc { get; set; }


        public void OnGet(string CommentTypeCode)
        {
            ToViewModel(_service.FindType(CommentTypeCode));
            _logger.LogInformation($"User opened {CommentTypeCode} for editing");

        }
        public IActionResult OnPost()
        {
            _service.EditType(this.ToDomainModel());
            _logger.LogInformation($"User edited {ThisCommentType.CommentTypeCode}");

            return RedirectToPage("./CommentTypesIndex");
        }

        private CommentType ToDomainModel() {
            var entity = new CommentType()
            {
                CommentTypeCode = this.CommentTypeCode,
                TypeDesc = this.TypeDesc
            };

            return entity;
        }

        private void ToViewModel(ICommentType entity)
        {
            this.CommentTypeCode = entity.CommentTypeCode;
            this.TypeDesc = entity.TypeDesc;
        }
    }
}