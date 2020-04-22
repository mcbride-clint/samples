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

namespace MDCLogArchitecture.RazorPages.Pages
{
    public class CreateLogHandlerModel : PageModel
    {
        private readonly ILogger<CreateLogHandlerModel> _logger;
        private readonly LogHandlerService _service;

        public CreateLogHandlerModel(ILogger<CreateLogHandlerModel> logger, LogHandlerService service)
        {
            _service = service;
            _logger = logger;
        }

        [BindProperty]
        public LogHandler ThisLogHandler { get; set; }
        public void OnGet(LogHandlersFilter filter)
        {

        }

        public IActionResult OnPost()
        {
            _service.Insert(ThisLogHandler);
            _logger.LogInformation($"User created {ThisLogHandler.UserSeqNum}");

            return RedirectToPage("./LogHandlerIndex", new { Priority = ThisLogHandler.UserSeqNum});
        }
    }
}
