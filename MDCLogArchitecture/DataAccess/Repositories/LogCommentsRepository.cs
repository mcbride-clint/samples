﻿using System;
using System.Collections.Generic;

using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.Filters;
using MDCLogArchitecture.Models.Interfaces.Repositories;
using MDCLogArchitecture.DataAccess.Connections;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Data;

namespace MDCLogArchitecture.DataAccess.Repositories
{
   public class LogCommentsRepository : ILogCommentsRepository
    { 
        private string listSQL = "Select SEQ_NUM as SeqNum,LOG_NUM as LogNumber,TYPE as Type,COMMENT_TEXT as Comment from TM_DIST_CHG_LOG_COMMENTS";
        
        readonly System.Data.IDbConnection _db; 
        public LogCommentsRepository(IDbConnection db) {
            _db = db;
        }

        //public LogComments Find(int SeqNum)
        //{
           
        //    throw new NotImplementedException();
        //}

        public List<LogComments> Find(LogCommentsFilter filter)
        {    
                List<LogComments> comments = _db.Query<LogComments>(listSQL).ToList();
                return comments;  
        }

        public LogComments Insert(LogComments entity)
        {
            throw new NotImplementedException();
        }
    }



    
  
}
