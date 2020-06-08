using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml;
using Dapper;
using MdcLog.Application.LogHandlers;
using MdcLog.Application.Users;
using MdcLog.Application.LogHandlers.Models;
using MdcLog.Domain.Entities;
using MdcLog.Application.Users;
using Microsoft.Extensions.Logging;
using MdcLog.Infrastructure.Repositories;
namespace MdcLog.Infrastructure.Repositories
{
    public class LogHandlerRepository : ILogHandlersRepository
    {
      
        private string listSQL = " Select UID as UID," +
                                 " USERID_SEQ_NUM as USERSEQNUM, " +
                                 " HANDLERS_CODE as CODE, " +
                                 " TMMA_CODE as TMMA " +
                                 " from TM_MDC_LOG_HANDLERS ";
        private string fullListSQL = " Select UID as UID," +
                                 " t.USERID_SEQ_NUM as USERSEQNUM, " +
                                 " HANDLERS_CODE as CODE, " +
                                 " TMMA_CODE as TMMA, " +
                                 " AD_FULL_NAME as AdFullName " +
                                 " from TM_MDC_LOG_HANDLERS t";


        readonly IDbConnection _db;
        public LogHandlerRepository(IDbConnection db)
        {
            _db = db;
        }

        public LogHandler InsertLogHandler(LogHandler entity)
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

        public LogHandler SaveLogHandler(LogHandler entity)
        {
            throw new NotImplementedException();
        }

        public LogHandler EditLogHandler(LogHandler entity)
        {
            string mySQL = "UPDATE[dbo].[TM_MDC_LOG_HANDLERS] SET [USERID_SEQ_NUM] = " + entity.UserSeqNum +
              ", [HANDLERS_CODE] = '" + entity.Code + "'" +
              ", [TMMA_CODE] = '" + entity.Tmma + "'" +
            //$" WHERE[UID] = @{nameof(entity.Uid)}";
            " WHERE[UID] =  " + entity.Uid;
            int rowsAffected = _db.Execute(mySQL);
            return entity;
        }

        public LogHandler FindLogHandler(int uid)
        {
            
            string findSQL = listSQL + " where UID = " + uid;
            LogHandler loghandler = _db.QuerySingle<LogHandler>(findSQL);
            return loghandler;
        }

        public LogHandler EditLogHandler(int uid)
        {
            string findSQL = listSQL + " where UID = " + uid;
            LogHandler loghandler = _db.QuerySingle<LogHandler>(findSQL);
            return loghandler;
        }

        public IEnumerable<LogHandlerVM> FindLogHandlerList()
        {
            string findSQL = fullListSQL + ",USERID u WHERE t.USERID_SEQ_NUM = u.USERID_SEQ_NUM ";
            return _db.Query<LogHandlerVM>(findSQL).ToList();
        }

        public LogHandler DeleteLogHandler(LogHandler entity)
        {
            string mySQL = " DELETE[dbo].[TM_MDC_LOG_HANDLERS] " + $" WHERE[UID] = @{nameof(entity.Uid)}";
            int rowsAffected = _db.Execute(mySQL, entity);
            return entity;
        }
    }
}
