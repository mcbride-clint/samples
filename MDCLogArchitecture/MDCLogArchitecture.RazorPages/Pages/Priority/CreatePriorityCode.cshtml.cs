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

namespace MDCLogArchitecture.RazorPages.Pages.Priority
{  
    public class CreatePriorityCodeModel : PageModel
    {
        private readonly ILogger<CreatePriorityCodeModel> _logger;
        private readonly PriorityCodeService _service;

        public CreatePriorityCodeModel(ILogger<CreatePriorityCodeModel> logger, PriorityCodeService service)
        {
            _service = service;
            _logger = logger;
        }

        [BindProperty]
        public PriorityCode ThisPriorityCode { get; set; }
        public void OnGet(PriorityCodesFilter filter)
        {            

        }

        public IActionResult OnPost()
        {
            _service.Insert(ThisPriorityCode);
            _logger.LogInformation($"User created {ThisPriorityCode.Priority}");

            return RedirectToPage("./PriorityCodeIndex", new { Priority = ThisPriorityCode.Priority });
        }
    }
}
