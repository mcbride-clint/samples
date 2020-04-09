using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Services;

namespace MDCLogArchitecture.RazorPages.Pages.Priority
{
    public class PriorityCodeIndexModel : PageModel
    {
        private PriorityCodeService _service { get; }

        public List<PriorityCode> PriorityCodes { get; set; }

        public PriorityCodeIndexModel(PriorityCodeService service)
        {
            _service = service;
        }
        public void OnGet()
        {
            PriorityCodes = _service.FindPriorityList();
        }
    }
}
