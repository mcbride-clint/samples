﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SimpleArchitecture.Models.DomainModels;
using SimpleArchitecture.Domain.Services;

namespace SimpleArchitecture.RazorPages
{
    public class CreateModel : PageModel
    {
        private readonly ILogger<CreateModel> _logger;
        private readonly UserService _service;

        public CreateModel(ILogger<CreateModel> logger, UserService service)
        {
            _service = service;
            _logger = logger;
        }

        [BindProperty]
        public User ThisUser { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _service.Save(ThisUser); 
            _logger.LogInformation($"User created {ThisUser.FullName}");

            return RedirectToPage("./View", new { userSeqNum = ThisUser.UserIdSeqNum });
        }
    }
}