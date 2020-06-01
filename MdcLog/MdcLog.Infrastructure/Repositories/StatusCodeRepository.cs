using System;
using System.Collections.Generic;
using System.Text;
using MdcLog.Domain.Entities;
using MdcLog.Application.StatusCodes;
using System.Data;
using Dapper;
using System.Linq;

namespace MdcLog.Infrastructure
{
    public class StatusCodeRepository : IStatusCodeRepository
    {
        private string listSQL = "Select STATUS ,DESCR " +
          " from TM_MDC_STATUS_CODES";

        readonly System.Data.IDbConnection _db;



        public StatusCodeRepository(IDbConnection db)
        {
            _db = db;
        }

        public StatusCode DeleteStatusCode(StatusCode entity)
        {
            string mySQL = " Delete[dbo].[TM_MDC_STATUS_CODES] " + $" WHERE[Status] = @{nameof(entity.Status)}";
            int rowsAffected = _db.Execute(mySQL, entity);
            return entity;
        }

        public StatusCode EditStatusCode(StatusCode entity)
        {
            string mySQL = "UPDATE[dbo].[TM_MDC_STATUS_CODES] SET[STATUS] = '" + entity.Status + "'" +
              ",[DESCR] = '" + entity.Descr + "'" +
              $" WHERE[Status] = @{nameof(entity.Status)}";
            int rowsAffected = _db.Execute(mySQL, entity);
            return entity;
        }

        public StatusCode FindStatusCode(string StatusCode)
        {
            string findSQL = listSQL + " Where Status = '" + StatusCode + "'";
            StatusCode statusCode = _db.QuerySingle<StatusCode>(findSQL);
            return statusCode;
        }

        public ICollection<StatusCode> FindStatusCodeList()
        {
            string runSQL = listSQL + " Order by Status";
            return _db.Query<StatusCode>(listSQL).ToList();
        }

        public StatusCode InsertStatusCode(StatusCode entity)
        {
            string mySQL = "INSERT INTO [TM_MDC_STATUS_CODES] ([STATUS],[DESCR]) VALUES " +
    "('" + entity.Status + "','" + entity.Descr.ToString() + "')";
            int rowsAffected = _db.Execute(mySQL);
            return entity;
        }

        public StatusCode SaveType(StatusCode entity)
        {
            throw new NotImplementedException();
        }
    }
}
