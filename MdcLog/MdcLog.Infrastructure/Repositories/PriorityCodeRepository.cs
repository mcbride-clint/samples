using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml;
using Dapper;
using MdcLog.Application.Priorties;
using MdcLog.Application.Priorties.Models;
using MdcLog.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace MdcLog.Infrastructure.Repositories
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

        public PriorityCode InsertPriorityCode(PriorityCode entity)
        {
            string mySQL = " INSERT INTO [TM_MDC_LOG_PRIORITY] ([PRIORITY],[DESCR]) VALUES " +
                           " ( '" + entity.Priority + "','" + entity.Descr + "')";
            int rowsAffected = _db.Execute(mySQL);
            return entity;
        }

        public PriorityCode SavePriorityCode(PriorityCode entity)
        {
            throw new NotImplementedException();
        }

        public PriorityCode EditPriorityCode(PriorityCode entity)
        {
            string mySQL = "UPDATE[dbo].[TM_MDC_LOG_PRIORITY] SET[PRIORITY] = '" + entity.Priority + "'" +
              ",[DESCR] = '" + entity.Descr + "'" +
              " WHERE[PRIORITY] = '" + entity.Priority + "'";
            int rowsAffected = _db.Execute(mySQL);
            return entity;
        }

        public PriorityCode FindPriorityCode(int PriorityCode)
        {
            string findSQL = listSQL + " Where PRIORITY = '" + PriorityCode + "'";
            PriorityCode priorityCode = _db.QuerySingle<PriorityCode>(findSQL);
            return priorityCode;
        }

        public IEnumerable<PriorityCode> FindPriorityCodeList()
        {
            return _db.Query<PriorityCode>(listSQL);
        }

        public PriorityCode DeletePriorityCode(PriorityCode entity)
        {
            string mySQL = "DELETE [dbo].[TM_MDC_LOG_PRIORITY]  WHERE[PRIORITY] = " + entity.Priority;
            int rowsAffected = _db.Execute(mySQL, entity);
            return entity;
        }       
    }
}
