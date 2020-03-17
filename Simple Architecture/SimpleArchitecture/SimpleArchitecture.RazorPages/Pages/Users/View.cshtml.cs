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
    public class ViewModel : PageModel
    {
        private readonly UserService _service;
        public ViewModel(UserService service)
        {
            _service = service;
        }

        public User ThisUser { get; set; }
        public void OnGet(long userSeqNum)
        {
            ThisUser = _service.Find(userSeqNum);
        }
    }
}