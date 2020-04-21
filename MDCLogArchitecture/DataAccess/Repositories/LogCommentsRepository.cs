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
    public class LogCommentsRepository : ILogCommentsRepository
    {
        private string listSQL = "Select SEQ_NUM as SeqNum,LOG_NUM as LogNumber,TYPE as Type,TYPE_DESC as TypeDesc,COMMENT_TEXT as Comment," +
            "BASIC_NUMBER as BasicNumber,CREATED_DATE as CreateDate,CREATED_BY_SEQ_NUM as CreatedBySeqNum," +
            " CREATED_BY as CreatedBy from TM_DIST_CHG_LOG_COMMENTS";

        readonly System.Data.IDbConnection _db;
        public LogCommentsRepository(IDbConnection db)
        {
            _db = db;
        }

        public ILogComments Find(int SeqNum)
        {
            string findSQL = listSQL + " where seq_num = " + SeqNum;
            LogComments comment = _db.QuerySingle<LogComments>(findSQL);
            return comment;
        }
        public IEnumerable<ILogComments> FindList(int LogNumber)
        {
            string mySQL = listSQL + " where Log_num = " + LogNumber;
            return _db.Query<LogComments>(mySQL);
        }
        //public IEnumerable<ILogComments> ILogCommentsRepository.FindList(int LogNumber)
        //{
        //    string mySQL = listSQL + " where Log_number = " + LogNumber;
        //    List<LogComments> listComments = _db.Query<LogComments>(listSQL).ToList();
        //    return listComments;
        //}

        public ILogComments Insert(ILogComments entity)
        {
            string mySQL = "INSERT INTO [TM_DIST_CHG_LOG_COMMENTS] ([LOG_NUM],[BASIC_NUMBER]" +
    ",[TYPE],[LINK_TO_SEQ_NUM],[CREATED_DATE],[CREATED_BY_SEQ_NUM],[COMMENT_TEXT]" +
      " ,[CREATED_BY],[TYPE_DESC]) VALUES " +
        "(" + entity.LogNumber + ",'"+ entity.BasicNumber + "','"  + entity.Type.ToString() + "',"
         + entity.LinkToSeqNum + "," + entity.CreateDate.ToShortDateString() + "," + entity.CreatedBySeqNum + ",'"
         + entity.Comment.ToString() + "','" + entity.CreatedBy.ToString() + "','" + entity.TypeDesc.ToString() + "')";
           int rowsAffected = _db.Execute(mySQL);
            return entity;
        }
        //public LogComments Save(LogComments entity)
        //{
        //    throw new NotImplementedException();
        //}

        //ILogComments ILogCommentsRepository.Insert(ILogComments entity)
        //{
        //    throw new NotImplementedException();
        //}

        public ILogComments Save(ILogComments entity)
        {
            throw new NotImplementedException();
        }

       

        //ILogComments ILogCommentsRepository.Find(int SeqNum)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<ILogComments> FindList(Domain.Interfaces.Repositories.LogCommentsFilter filter)
        //{
        //    throw new NotImplementedException();
        //}

        //IEnumerable<ILogComments> ILogCommentsRepository.FindList(int LogNumber)
        //{
        //    throw new NotImplementedException();
        //}
    }





}
