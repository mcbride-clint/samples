using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleArchitecture.Models.DomainModels;
using SimpleArchitecture.Services;

namespace SimpleArchitecture.RazorPages
{
    public class CreateModel : PageModel
    {
        private readonly UserService _service;
        public CreateModel(UserService service)
        {
            _service = service;
        }

        [BindProperty]
        public User ThisUser { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _service.Save(ThisUser);

            return RedirectToPage("./View", new { userSeqNum = ThisUser.UserIdSeqNum });
        }
    }
}