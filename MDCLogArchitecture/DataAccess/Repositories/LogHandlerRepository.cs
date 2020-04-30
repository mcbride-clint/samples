using System;
using System.Collections.Generic;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.Filters;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Collections;
using System.Data;
using MDCLogArchitecture.Domain.Interfaces.Repositories;
using MDCLogArchitecture.Domain.Interfaces;

namespace MDCLogArchitecture.DataAccess.Repositories
{
    public class LogHandlerRepository : ILogHandlersRepository
    {
        private string listSQL = " Select USERID_SEQ_NUM as USERSEQNUM, " +
                                 " HANDLERS_CODE as CODE, " +
                                 " TMMA_CODE as TMMA " +
                                 " from TM_MDC_LOG_HANDLERS ";

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
            string mySQL = "UPDATE[dbo].[TM_MDC_LOG_HANDLERS] SET[USERID_SEQ_NUM] = " + entity.UserSeqNum +
              ",[HANDLERS_CODE] = '" + entity.Code + "'" +
              ",[TMMA_CODE] = '" + entity.Tmma + "'" +
              $" WHERE[USERID_SEQ_NUM] = @{nameof(entity.UserSeqNum)}";            
            int rowsAffected = _db.Execute(mySQL);
            return entity;
        }

        public LogHandler FindLogHandler(int userseqnum)
        {
            string findSQL = listSQL + " where USERID_SEQ_NUM = '" + userseqnum + "'";
            LogHandler loghandler = _db.QuerySingle<LogHandler>(findSQL);
            return loghandler;
        }

        public IEnumerable<LogHandler> FindLogHandlerList()
        {
            return _db.Query<LogHandler>(listSQL).ToList();
        }

        public LogHandler DeleteLogHandler(int LogHandler)
        {
            throw new NotImplementedException();
        }
    }
}
