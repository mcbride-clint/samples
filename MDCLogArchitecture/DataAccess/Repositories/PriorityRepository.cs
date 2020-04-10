using System;
using System.Collections.Generic;
using System.Text;

using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.Filters;
using MDCLogArchitecture.Models.Interfaces.Repositories;
using MDCLogArchitecture.DataAccess.Connections;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Data;
using System.Runtime.InteropServices.ComTypes;

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
            throw new NotImplementedException();
        }

        public PriorityCode FindPriority(string PriorityCode)
        {
            throw new NotImplementedException();
        }

        public List<PriorityCode> FindPriorityList()
        {
            string mySQL = listSQL ;
            List<PriorityCode> priorities = _db.Query<PriorityCode>(listSQL).ToList();
            return priorities;
        }

        public PriorityCode InsertPriority(PriorityCode entity)
        {
            throw new NotImplementedException();
        }

        public PriorityCode SavePriority(PriorityCode entity)
        {
            throw new NotImplementedException();
        }
    }
}
