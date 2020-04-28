using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MDCLogArchitecture.Models.Filters;

namespace MDCLogArchitecture.RazorPages.Pages.LogHandlers
{
    public class EditLogHandlerModel : PageModel
    {
        private readonly ILogger<EditLogHandlerModel> _logger;
        private readonly LogHandlerService _service;

        public EditLogHandlerModel(ILogger<EditLogHandlerModel> logger, LogHandlerService service)
        {
            _service = service;
            _logger = logger;
        }

        [BindProperty]
        public LogHandler ThisLogHandler { get; set; }
        public void OnGet(int userseqnum)
        {
            ThisLogHandler = (LogHandler)_service.FindLogHandler(userseqnum);

        }
        public IActionResult OnPost()
        {
            _service.EditLogHandler(ThisLogHandler);
            _logger.LogInformation($"User edited {ThisLogHandler.UserSeqNum}");

            return RedirectToPage("./LogHandlerIndex");
        }
    }
}
