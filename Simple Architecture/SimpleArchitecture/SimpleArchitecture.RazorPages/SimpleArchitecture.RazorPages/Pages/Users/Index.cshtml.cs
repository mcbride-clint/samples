using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleArchitecture.Domain.Interfaces;
using SimpleArchitecture.Domain.Services;
using System.Collections.Generic;

namespace SimpleArchitecture.RazorPages
{
    public class IndexModel : PageModel
    {
        private UserService _service { get; }

        public List<IUser> Users { get; set; }

        public IndexModel(UserService service) {
            _service = service;
        }
        public void OnGet()
        {
            Users = _service.Find(new Models.Filters.UserFilter());
        }
    }
}