using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.Extensions.Logging;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Services;

namespace MDCLogArchitecture.RazorPages.Pages.Comments
{
    public class EditCommentsModel : PageModel
    {
        private readonly ILogger<EditCommentsModel> _logger;
        private readonly MDCLogService _service;

        public EditCommentsModel(ILogger<EditCommentsModel> logger, MDCLogService service)
        {
            _service = service;
            _logger = logger;
        }

        [BindProperty]
        public LogComments ThisComment { get; set; }
        public void OnGet(int SeqNum)
        {
            ThisComment = _service.Find(SeqNum);
            _logger.LogInformation($"User opened {ThisComment.SeqNum} for editing");
        }
    }
}