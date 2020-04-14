using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MDCLogArchitecture.Models.Filters;

namespace MDCLogArchitecture.RazorPages.Pages.Priority
{
    public class EditPriorityCodeModel : PageModel
    {
        private readonly ILogger<EditPriorityCodeModel> _logger;
        private readonly PriorityCodeService _service;

        public EditPriorityCodeModel(ILogger<EditPriorityCodeModel> logger, PriorityCodeService service)
        {
            _service = service;
            _logger = logger;
        }

        [BindProperty]
        public PriorityCode ThisPriorityCode { get; set; }
        public void OnGet(PriorityCodesFilter filter)
        {
            ThisPriorityCode = _service.Find(filter);

        }
        public IActionResult OnPost()
        {
            _service.Edit(ThisPriorityCode);
            _logger.LogInformation($"User edited {ThisPriorityCode.Priority}");

            return RedirectToPage("./PriorityCodeIndex");
        }
    }
}
