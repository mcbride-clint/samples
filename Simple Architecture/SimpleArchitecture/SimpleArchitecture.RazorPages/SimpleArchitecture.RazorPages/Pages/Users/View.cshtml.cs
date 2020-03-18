using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SimpleArchitecture.Models.DomainModels;
using SimpleArchitecture.Services;

namespace SimpleArchitecture.RazorPages
{
    public class ViewModel : PageModel
    {
        private readonly ILogger<ViewModel> _logger;
        private readonly UserService _service;

        public ViewModel(ILogger<ViewModel> logger, UserService service)
        {
            _service = service;
            _logger = logger;
        }

        public User ThisUser { get; set; }
        public void OnGet(long userSeqNum)
        {
            ThisUser = _service.Find(userSeqNum);
            _logger.LogInformation($"User opened {ThisUser.FullName} for viewing");
        }
    }
}