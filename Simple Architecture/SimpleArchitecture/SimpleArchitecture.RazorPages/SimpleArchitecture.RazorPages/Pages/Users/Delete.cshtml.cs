using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SimpleArchitecture.Domain.Services;
using SimpleArchitecture.Models.DomainModels;

namespace SimpleArchitecture.RazorPages
{
    public class DeleteModel : PageModel
    {
        private readonly ILogger<DeleteModel> _logger;
        private readonly UserService _service;

        public DeleteModel(ILogger<DeleteModel> logger, UserService service)
        {
            _service = service;
            _logger = logger;
        }

        [BindProperty]
        public User ThisUser { get; set; }
        public void OnGet(long userSeqNum)
        {
            ThisUser = (User)_service.Find(userSeqNum);
            _logger.LogInformation($"User opened {ThisUser.FullName} for deletion");
        }

        public IActionResult OnPost()
        {
            ThisUser = (User)_service.Find(ThisUser.UserIdSeqNum);

            if (ThisUser is null) {
                // Not the greatest way to return an error message
                ModelState.AddModelError("UserError", "User is not found");
                return Page();
            }

            _service.Delete(ThisUser);
            _logger.LogInformation($"User deleted {ThisUser.FullName}");

            return RedirectToPage("./Index");
        }
    }
}