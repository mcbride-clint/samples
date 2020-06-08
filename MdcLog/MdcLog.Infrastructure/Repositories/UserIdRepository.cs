using System;
using System.Collections.Generic;
using System.Text;
using MdcLog.Domain.Entities;
using MdcLog.Application.StatusCodes;
using System.Data;
using Dapper;
using System.Linq;
using MdcLog.Application.Users;

namespace MdcLog.Infrastructure.Repositories
{
    public class UserIdRepository :IUserIdRepository
    {
        private string listSQL = "Select USERID_SEQ_NUM as UserSeqNum,OWNER,AD_FULL_NAME as AdFullName " +
         " ,USERID as UserIdCode from USERID";

        readonly System.Data.IDbConnection _db;



        public UserIdRepository(IDbConnection db)
        {
            _db = db;
        }
        public ICollection<UserId> FindUserIdList()
        {
            string runSQL = listSQL + " Order by AD_FULL_NAME";
            return _db.Query<UserId>(listSQL).ToList();
        }
        public UserId FindUserId(int UserSeqNum)
        {
            string findSQL = listSQL + " Where USER_SEQ_NUM = '" + UserSeqNum + "'";
            UserId userIduser = _db.QuerySingle<UserId>(findSQL);
            return userIduser;
        }
    }
}
