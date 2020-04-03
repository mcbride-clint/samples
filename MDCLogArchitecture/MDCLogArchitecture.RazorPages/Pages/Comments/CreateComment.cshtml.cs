using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Services;

namespace MDCLogArchitecture.RazorPages.Pages.Comments
{
    public class CreateCommentModel : PageModel
    {
        private readonly ILogger<CreateCommentModel> _logger;
        private readonly MDCLogService _service;

        public CreateCommentModel(ILogger<CreateCommentModel> logger, MDCLogService service)
        {
            _service = service;
            _logger = logger;
        }

        [BindProperty]
        public LogComments ThisComment { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _service.Save(ThisComment);
            _logger.LogInformation($"User created {ThisComment.SeqNum}");

            return RedirectToPage("./index", new { SeqNum = ThisComment.SeqNum });
        }
    }
}