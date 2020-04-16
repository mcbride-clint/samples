using System;
using System.Collections.Generic;

using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.Filters;
using Dapper;
using System.Linq;
using System.Data;

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

        public PriorityCode EditPriority(PriorityCode entity)
        {
            string mySQL = "UPDATE[dbo].[TM_MDC_LOG_PRIORITY] SET[PRIORITY] = '" + entity.Priority + "'" +
              ",[DESCR] = '" + entity.Descr + "'" +
              " WHERE[PRIORITY] = '" + entity.Priority + "'";
            int rowsAffected = _db.Execute(mySQL);
            return entity;
        }

        public PriorityCode FindPriority(PriorityCodesFilter filter)
        {
            string findSQL = listSQL + " Where PRIORITY = '" + filter.Priority + "'";
            PriorityCode priorityCode = _db.QuerySingle<PriorityCode>(findSQL);
            return priorityCode;
        }

        public List<PriorityCode> FindPriorityList(PriorityCodesFilter filter)
        {

            string mySQL = listSQL + " where PRIORITY = " + filter.Priority;
            List<PriorityCode> priorities = _db.Query<PriorityCode>(listSQL).ToList();
            return priorities;
        }

        public PriorityCode InsertPriority(PriorityCode entity)
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
    }
}
