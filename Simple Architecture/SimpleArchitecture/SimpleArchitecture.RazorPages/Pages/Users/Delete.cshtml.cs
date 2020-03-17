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
    public class DeleteModel : PageModel
    {
        private readonly UserService _service;
        public DeleteModel(UserService service)
        {
            _service = service;
        }

        [BindProperty]
        public User ThisUser { get; set; }
        public void OnGet(long userSeqNum)
        {
            ThisUser = _service.Find(userSeqNum);
        }

        public IActionResult OnPost()
        {
            ThisUser = _service.Find(ThisUser.UserIdSeqNum);

            if (ThisUser is null) {
                // Not the greatest way to return an error message
                ModelState.AddModelError("UserError", "User is not found");
                return Page();
            }

            _service.Delete(ThisUser);

            return RedirectToPage("./Index");
        }
    }
}