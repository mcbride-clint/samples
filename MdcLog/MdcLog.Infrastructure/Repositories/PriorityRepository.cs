using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml;
using Dapper;
using MdcLog.Application.CommentTypes;
using MdcLog.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace MdcLog.Infrastructure.Repositories
{
    class PriorityRepository : IPriorityRepository
    {
        private string listSQL = " Select PRIORITY,DESCR " +
            " from TM_MDC_LOG_PRIORITY ";

        readonly System.Data.IDbConnection _db;
        public PriorityRepository(IDbConnection db)
        {
            _db = db;
        }

        public PriorityCodeVM InsertPriority(PriorityCodeVM entity)
        {
            string mySQL = " INSERT INTO [TM_MDC_LOG_PRIORITY] ([PRIORITY],[DESCR]) VALUES " +
                           " ( '" + entity.Priority + "','" + entity.Descr + "')";
            int rowsAffected = _db.Execute(mySQL);
            return entity;
        }

        public PriorityCode SavePriority(PriorityCode entity)
        {
            throw new NotImplementedException();
        }

        public PriorityCodeVM EditPriority(PriorityCodeVM entity)
        {
            string mySQL = "UPDATE[dbo].[TM_MDC_LOG_PRIORITY] SET[PRIORITY] = '" + entity.Priority + "'" +
              ",[DESCR] = '" + entity.Descr + "'" +
              " WHERE[PRIORITY] = '" + entity.Priority + "'";
            int rowsAffected = _db.Execute(mySQL);
            return entity;
        }

        public PriorityCodeVM FindPriority(int PriorityCode)
        {
            string findSQL = listSQL + " Where PRIORITY = '" + PriorityCode + "'";
            //CommentType commentType = _db.QuerySingle<CommentType>(findSQL);
            //return commentType;
            PriorityCodeVM priorityCode = _db.QuerySingle<PriorityCodeVM>(findSQL);
            return priorityCode;
        }

        public IEnumerable<PriorityCode> FindPriorityList()
        {
            return _db.Query<PriorityCode>(listSQL);
        }

        public int DeletePriority(int PriorityCode)
        {
            int deletedRecords = _db.Execute("DELETE[dbo].[TM_MDC_LOG_PRIORITY] where PRIORITY = '" + PriorityCode + "'");
            return deletedRecords;
        }
    }
}
