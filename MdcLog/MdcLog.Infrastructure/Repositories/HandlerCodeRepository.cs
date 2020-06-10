using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml;
using Dapper;

using MdcLog.Application.LogHandlers.Models;
using MdcLog.Domain.Entities;
using MdcLog.Application.HandlerCodes;
using Microsoft.Extensions.Logging;
using MdcLog.Infrastructure.Repositories;



namespace MdcLog.Infrastructure.Repositories
{
    public class HandlerCodeRepository : IHandlerCodeRepository
    {
        string listSQL = "SELECT  [CODE],[DESCR] FROM[mdc].[dbo].[TM_HANDLERS_CODE]";
        readonly IDbConnection _db;
        public HandlerCodeRepository(IDbConnection db)
        {
            _db = db;
        }
        

        public HandlerCode EditHandlerCode(HandlerCode entity)
        {
            string mySQL = "UPDATE[dbo].[TM_HANDLERS_CODE] SET[CODE] = '" + entity.Code + "'" +
             ",[DESCR] = '" + entity.Descr + "'" +
             $" WHERE[CODE] = @{nameof(entity.Code)}";
            int rowsAffected = _db.Execute(mySQL, entity);
            return entity;
        }
        public HandlerCode DeleteHandlerCode(HandlerCode entity)
        {
            string mySQL = "DELETE[dbo].[TM_HANDLERS_CODE] " +
             $" WHERE[CODE] = @{nameof(entity.Code)}";
            int rowsAffected = _db.Execute(mySQL, entity);
            return entity;
        }

        public HandlerCode FindHandlerCode(string Code)
        {
            string findSQL = listSQL + " Where Code = '" + Code + "'";
            HandlerCode handlerCode = _db.QuerySingle<HandlerCode>(findSQL);
            return handlerCode;
        }

        public ICollection<HandlerCode> FindHandlerCodeList()
        {
            string runSQL = listSQL + " Order by Status";
            return _db.Query<HandlerCode>(listSQL).ToList();
        }

        public HandlerCode InsertHandlerCode(HandlerCode entity)
        {
            string mySQL = "INSERT INTO [TM_HANDLERS_CODE] ([CODE],[DESCR]) VALUES " +
 "('" + entity.Code + "','" + entity.Descr.ToString() + "')";
            int rowsAffected = _db.Execute(mySQL);
            if (rowsAffected == 0)
            {
                throw new Exception($"Record Not Inserted: {entity.Code}");
            }
            return entity;
        }

            public HandlerCode SaveType(HandlerCode entity)
            {
                throw new NotImplementedException();
            }
        }
    }
