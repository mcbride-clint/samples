using Microsoft.Extensions.Logging;
using SimpleArchitecture.Domain.Interfaces;
using SimpleArchitecture.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace SimpleArchitecture.Domain.Services
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
        public IUser Find(long userIdSeqNum)
        {
            return _userRepo.Find(userIdSeqNum);
        }

        /// <summary>
        /// Search all users given a set of parameters
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<IUser> Find(IUserFilter filter)
        {
            return _userRepo.Find(filter);
        }

        /// <summary>
        /// Save a User to the User Repository.  Will Insert or Update as Needed.
        /// </summary>
        /// <param name="thisUser"></param>
        /// <returns></returns>
        public IUser Save(IUser thisUser)
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
        public void Delete(IUser thisUser) {
            _userRepo.Delete(thisUser);
        }
    }
}
