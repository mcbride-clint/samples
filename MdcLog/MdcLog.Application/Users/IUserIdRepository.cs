using System;
using System.Collections.Generic;
using System.Text;
using MdcLog.Domain.Entities;


namespace MdcLog.Application.Users
{
   public interface IUserIdRepository
    {
        UserId FindUserId(int UserSeqNum);
        ICollection<UserId> FindUserIdList();
    }
}
