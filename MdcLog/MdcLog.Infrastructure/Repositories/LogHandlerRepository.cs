using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml;
using Dapper;
using MdcLog.Application.LogHandlers;
using MdcLog.Application.LogHandlers.Models;
using MdcLog.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace MdcLog.Infrastructure.Repositories
{
    public class LogHandlerRepository : ILogHandlersRepository
    {
        private string listSQL = " Select UID as UID," +
                                 "USERID_SEQ_NUM as USERSEQNUM, " +
                                 " HANDLERS_CODE as CODE, " +
                                 " TMMA_CODE as TMMA " +
                                 " from TM_MDC_LOG_HANDLERS ";

        readonly IDbConnection _db;
        public LogHandlerRepository(IDbConnection db)
        {
            _db = db;
        }

        public LogHandlerVM InsertLogHandler(LogHandlerVM entity)
        {
            string mySQL = " INSERT INTO[dbo].[TM_MDC_LOG_HANDLERS] " +
                                        " ([USERID_SEQ_NUM], " +
                                        " [HANDLERS_CODE], " +
                                        " [TMMA_CODE]) " +
                               " VALUES " +
                                        " (" + entity.UserSeqNum + " ," +
                                        " '" + entity.Code + "'," +
                                        " '" + entity.Tmma + "' )";
            int rowsAffected = _db.Execute(mySQL);
            return entity;
        }

        public LogHandlerVM SaveLogHandler(LogHandlerVM entity)
        {
            throw new NotImplementedException();
        }

        public CreateLogHandlerVM EditLogHandler(CreateLogHandlerVM entity)
        {
            string mySQL = "UPDATE[dbo].[TM_MDC_LOG_HANDLERS] SET [USERID_SEQ_NUM] = " + entity.UserSeqNum +
              ", [HANDLERS_CODE] = '" + entity.Code + "'" +
              ", [TMMA_CODE] = '" + entity.Tmma + "'" +
            //$" WHERE[UID] = @{nameof(entity.Uid)}";
            " WHERE[UID] =  " + entity.Uid;
            int rowsAffected = _db.Execute(mySQL);
            return entity;
        }

        public LogHandlerVM FindLogHandler(int uid)
        {
            string findSQL = listSQL + " where UID = " + uid;
            LogHandlerVM loghandler = _db.QuerySingle<LogHandlerVM>(findSQL);
            return loghandler;
        }

        public LogHandlerVM EditLogHandler(int uid)
        {
            string findSQL = listSQL + " where UID = " + uid;
            LogHandlerVM loghandler = _db.QuerySingle<LogHandlerVM>(findSQL);
            return loghandler;
        }

        public IEnumerable<LogHandlerVM> FindLogHandlerList()
        {
            return _db.Query<LogHandlerVM>(listSQL).ToList();
        }

        public LogHandlerVM DeleteLogHandler(LogHandlerVM entity)
        {
            string mySQL = " DELETE[dbo].[TM_MDC_LOG_HANDLERS] " + $" WHERE[UID] = @{nameof(entity.Uid)}";
            int rowsAffected = _db.Execute(mySQL, entity);
            return entity;
        }
    }
}
