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
        /// <summary>
        /// Initialize the Service with an instance of an injected User Repository
        /// </summary>
        /// <param name="userRepo"></param>
        public UserService(IUserRepository userRepo)
        {
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
            if (thisUser.UserIdSeqNum == 0)
            {
                return _userRepo.Insert(thisUser);
            }
            else
            {
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
