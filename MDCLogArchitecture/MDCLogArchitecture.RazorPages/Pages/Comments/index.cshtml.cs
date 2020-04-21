using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.Filters;
using MDCLogArchitecture.Domain.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MDCLogArchitecture.Domain.Interfaces;

namespace MDCLogArchitecture.RazorPages.Pages.Comments
{
    public class IndexModel : PageModel
    {

        private MDCLogService _service { get; }
        
        public List<ILogComments> LogComments { get; set; }

        public IndexModel(MDCLogService service)
        {
            _service = service;
        }
        public void OnGet()
        {
            int LogNumber = 100;
            LogComments = _service.FindList(LogNumber);

        }


    }
}