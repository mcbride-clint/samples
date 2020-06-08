using MdcLog.Application.Users.Models;
using MdcLog.Application.Comments;
using MdcLog.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MdcLog.Application.Users
{
    public class UserIdService
    {
        IUserIdRepository _usersRepo;
        ILogger<UserIdService> _logger;
        /// <summary>
        /// Initialize the Service with an instance of an injected User Repository
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="usersRepo"></param>
        public UserIdService(ILogger<UserIdService> logger, IUserIdRepository usersRepo)
        {
            _logger = logger;
            _usersRepo = usersRepo;

        }
        UserIdVM GetUserIdVM ()
        {
            return new UserIdVM();
        }
        public List<UserIdView> FindUserIdList()
        {
            var userIdList = _usersRepo.FindUserIdList();

            var linqViewList = userIdList
                .Select(item => new UserIdView
                {
                    UserSeqNum =  item.UserSeqNum,
                    Owner = item.Owner,
                    AdFullName = item.AdFullName,
                    UserIdCode = item.UserIdCode
                    
                })
                .ToList();

           

            return linqViewList;
        }
        public UserId FindUserId(int userSeqNum)
        {
            var userIdObj = _usersRepo.FindUserId(userSeqNum);
            return userIdObj;
        }
    }
}
