using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.Filters;
using MDCLogArchitecture.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MDCLogArchitecture.RazorPages.Pages.Comments
{
    public class IndexModel : PageModel
    {
       
            private MDCLogService _service { get; }

            public List<LogComments> LogComments { get; set; }

            public IndexModel(MDCLogService service)
            {
                _service = service;
            }
            public void OnGet()
            {
                LogComments = _service.FindList(new LogCommentsFilter() { LogNumber = 100 });
            
        }


    }
}