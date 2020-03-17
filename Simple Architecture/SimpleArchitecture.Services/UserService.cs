using Microsoft.Extensions.Logging;
using SimpleArchitecture.Models.DomainModels;
using SimpleArchitecture.Models.Filters;
using SimpleArchitecture.Models.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleArchitecture.Services
{
    /// <summary>
    /// Actions that can be performed for User Data
    /// </summary>
    public class UserService
    {
        IUserRepository _userRepo;
        ILogger<UserService> _logger;

        /// <summary>
        /// Initialize the Service with an instance of an injected User Repository
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="userRepo"></param>
        public UserService(ILogger<UserService> logger, IUserRepository userRepo)
        {
            _logger = logger;
            _userRepo = userRepo;
        }

        /// <summary>
        /// Locate a Single User via it's key
        /// </summary>
        /// <param name="userIdSeqNum"></param>
        /// <returns></returns>
        public User Find(long userIdSeqNum)
        {
            return _userRepo.Find(userIdSeqNum);
        }

        /// <summary>
        /// Search all users given a set of parameters
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<User> Find(UserFilter filter)
        {
            return _userRepo.Find(filter);
        }

        /// <summary>
        /// Save a User to the User Repository.  Will Insert or Update as Needed.
        /// </summary>
        /// <param name="thisUser"></param>
        /// <returns></returns>
        public User Save(User thisUser)
        {
            _logger.LogDebug("Checking for existing User Id Seq Num");
            if (thisUser.UserIdSeqNum == 0)
            {
                _logger.LogInformation("No UserIdSeqNum Found, inserting new record");
                return _userRepo.Insert(thisUser);
            }
            else
            {
                _logger.LogInformation("UserIdSeqNum Found, updating existing record");
                return _userRepo.Update(thisUser);
            }
        }

        /// <summary>
        /// Remove a User from the Repository
        /// </summary>
        /// <param name="thisUser"></param>
        public void Delete(User thisUser) {
            _userRepo.Delete(thisUser);
        }
    }
}
