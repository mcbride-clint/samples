using System;
using System.Collections.Generic;
using MDCLogArchitecture.DataAccess.Repositories;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.ViewModels;
using Dapper;
using System.Linq;
using System.Data;
using MDCLogArchitecture.Domain.Interfaces.Repositories;
using MDCLogArchitecture.Domain.Interfaces;


namespace MDCLogArchitecture.DataAccess.Repositories
{
    public class PriorityRepository : IPriorityRepository
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

        public PriorityCodeVM FindPriority(string PriorityCode)
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

        public PriorityCode DeletePriority(string PriorityCode)
        {
            throw new NotImplementedException();
        }
       
    }
}
