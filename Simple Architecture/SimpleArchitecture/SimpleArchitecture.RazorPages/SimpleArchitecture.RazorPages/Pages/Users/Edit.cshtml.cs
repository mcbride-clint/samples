﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SimpleArchitecture.Domain.Services;
using SimpleArchitecture.Models.DomainModels;

namespace SimpleArchitecture.RazorPages
{
    public class EditModel : PageModel
    {
        private readonly ILogger<EditModel> _logger;
        private readonly UserService _service;

        public EditModel(ILogger<EditModel> logger, UserService service)
        {
            _service = service;
            _logger = logger;
        }

        [BindProperty]
        public User ThisUser { get; set; }
        public void OnGet(long userSeqNum)
        {
            ThisUser = (User)_service.Find(userSeqNum);
            _logger.LogInformation($"User opened {ThisUser.FullName} for editing");
        }

        public IActionResult OnPost()
        {
            _service.Save(ThisUser);
            _logger.LogInformation($"User made changes to {ThisUser.FullName}");

            return RedirectToPage("./View", new { userSeqNum = ThisUser.UserIdSeqNum });
        }
    }
}