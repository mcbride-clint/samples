using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Domain.Services;
using MDCLogArchitecture.Models.Filters;
using MDCLogArchitecture.Domain.Interfaces;

namespace MDCLogArchitecture.RazorPages.Pages.LogHandlers
{
    public class LogHandlerIndexModel : PageModel
    {
        private LogHandlerService service { get; }

        public List<ILogHandler> LogHandler { get; set; }

        public LogHandlerIndexModel(LogHandlerService service)
        {
            this.service = service;
        }
        public void OnGet()
        {
            LogHandler = service.FindLogHandlerList();
        }
    }
}
