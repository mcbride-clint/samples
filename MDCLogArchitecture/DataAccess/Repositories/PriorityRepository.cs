using System;
using System.Collections.Generic;

using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.Filters;
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

        public PriorityCode DeletePriority(string PriorityCode)
        {
            throw new NotImplementedException();
        }

        public IPriorityCode EditPriority(IPriorityCode entity)
        {
            string mySQL = "UPDATE[dbo].[TM_MDC_LOG_PRIORITY] SET[PRIORITY] = '" + entity.Priority + "'" +
              ",[DESCR] = '" + entity.Descr + "'" +
              " WHERE[PRIORITY] = '" + entity.Priority + "'";
            int rowsAffected = _db.Execute(mySQL);
            return entity;
        }

        public IPriorityCode FindPriority(string PriorityCode)
        {
            string findSQL = listSQL + " Where PRIORITY = '" + PriorityCode + "'";
            //CommentType commentType = _db.QuerySingle<CommentType>(findSQL);
            //return commentType;
            PriorityCode priorityCode = _db.QuerySingle<PriorityCode>(findSQL);
            return priorityCode;
        }
        public IEnumerable<IPriorityCode> FindPriorityList()
        {
            return _db.Query<PriorityCode>(listSQL);
        }
        //public List<PriorityCode> FindPriorityList()
        //{

        //    string mySQL = listSQL ;
        //    List<PriorityCode> priorities = _db.Query<PriorityCode>(listSQL).ToList();
        //    return priorities;
        //}

        public IPriorityCode InsertPriority(IPriorityCode entity)
        {
            string mySQL = " INSERT INTO [TM_MDC_LOG_PRIORITY] ([PRIORITY],[DESCR]) VALUES " +
                           " ( '" + entity.Priority + "','" + entity.Descr + "')";
            int rowsAffected = _db.Execute(mySQL);
            return entity;
        }

        public IPriorityCode SavePriority(IPriorityCode entity)
        {
            throw new NotImplementedException();
        }

        
        IPriorityCode IPriorityRepository.DeletePriority(string PriorityCode)
        {
            throw new NotImplementedException();
        }
    }
}
