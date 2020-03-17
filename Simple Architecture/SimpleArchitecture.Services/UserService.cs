using SimpleArchitecture.Models.DomainModels;
using SimpleArchitecture.Models.Filters;
using SimpleArchitecture.Models.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleArchitecture.Services
{
    public class UserService
    {
        IUserRepository _userRepo;
        public UserService(IUserRepository userRepo) {
            _userRepo = userRepo;
        }

        public User Find(long userIdSeqNum) {
            return _userRepo.Find(userIdSeqNum);
        }

        public List<User> Find(UserFilter filter)
        {
            return _userRepo.Find(filter);
        }
    }
}
