using System;
using System.Collections.Generic;
using System.Text;
using MdcLog.Domain.Entities;


namespace MdcLog.Application.Users
{
   public interface IUserIdRepository
    {
        UserId FindUserId(string UserIdSeqNum);
        ICollection<UserId> FindUserIdList();
    }
}
