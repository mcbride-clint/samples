using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Services;
using MDCLogArchitecture.Models.Filters;

namespace MDCLogArchitecture.RazorPages.Pages.Priority
{
    public class PriorityCodeIndexModel : PageModel
    {
        private PriorityCodeService service { get; }

        public List<PriorityCode> PriorityCodes { get; set; }

        public PriorityCodeIndexModel(PriorityCodeService service)
        {
            this.service = service;
        }
        public void OnGet()
        {
            PriorityCodes = service.FindPriorityList(new PriorityCodesFilter());
        }
    }
}
