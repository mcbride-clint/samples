using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SimpleArchitecture.Domain.Interfaces;
using SimpleArchitecture.Domain.Services;

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

        public IUser ThisUser { get; set; }
        public void OnGet(long userSeqNum)
        {
            ThisUser = _service.Find(userSeqNum);
            _logger.LogInformation($"User opened {ThisUser.FullName} for viewing");
        }
    }
}