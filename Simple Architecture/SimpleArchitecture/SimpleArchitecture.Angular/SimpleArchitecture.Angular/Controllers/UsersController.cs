using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleArchitecture.Models.DomainModels;
using SimpleArchitecture.Domain.Services;
using SimpleArchitecture.Domain.Interfaces;

namespace SimpleArchitecture.Angular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly UserService _userService;

        public UsersController(ILogger<UsersController> logger, UserService userService) {
            _logger = logger;
            _userService = userService;
        }

        // GET: api/Users
        [HttpGet]
        public IEnumerable<IUser> Get()
        {
            return _userService.Find(new Models.Filters.UserFilter());
        }

        // GET: api/Users/5
        [HttpGet("{userSeqNum}", Name = "Get")]
        public IUser Get(int userSeqNum)
        {
            return _userService.Find(userSeqNum);
        }

        // POST: api/Users
        [HttpPost]
        public void Post([FromBody] IUser value)
        {
            _userService.Save(value);
        }

        // PUT: api/Users/5
        [HttpPut("{userSeqNum}")]
        public void Put(int userSeqNum, [FromBody] IUser value)
        {
            _userService.Save(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{userSeqNum}")]
        public void Delete(int userSeqNum)
        {
            var user = _userService.Find(userSeqNum);
            _userService.Delete(user);
        }
    }
}
