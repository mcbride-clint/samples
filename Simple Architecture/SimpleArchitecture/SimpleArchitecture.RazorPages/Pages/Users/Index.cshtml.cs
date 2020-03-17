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
    public class IndexModel : PageModel
    {
        private UserService _service { get; }

        public List<User> Users { get; set; }

        public IndexModel(UserService service) {
            _service = service;
        }
        public void OnGet()
        {
            Users = _service.Find(new Models.Filters.UserFilter());
        }
    }
}