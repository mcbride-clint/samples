﻿using System;
using System.Collections.Generic;

using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.ViewModels;
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
        private string listSQL = "Select SEQ_NUM as SeqNum,LOG_NUM as LogNumber,TYPE as CommentTypeCode,TYPE_DESC as TypeDesc,COMMENT_TEXT as Comment," +
            "BASIC_NUMBER as BasicNumber,CREATED_DATE as CreateDate,CREATED_BY_SEQ_NUM as CreatedBySeqNum," +
            " CREATED_BY as CreatedBy from TM_DIST_CHG_LOG_COMMENTS";

        readonly System.Data.IDbConnection _db;
        public LogCommentsRepository(IDbConnection db)
        {
            _db = db;
        }

        public LogComment Find(int SeqNum)
        {
            string findSQL = listSQL + " where seq_num = " + SeqNum;
            LogComment comment = _db.QuerySingle<LogComment>(findSQL);
            return comment;
        }
        public IEnumerable<LogComment> FindList(int LogNumber)
        {
            string mySQL = listSQL + " where Log_num = " + LogNumber;
            return _db.Query<LogComment>(mySQL);
        }
       

        public LogCommentVM Insert(LogCommentVM entity)
        {
            string mySQL = "INSERT INTO [TM_DIST_CHG_LOG_COMMENTS] ([LOG_NUM],[BASIC_NUMBER]" +
    ",[TYPE],[LINK_TO_SEQ_NUM],[CREATED_DATE],[CREATED_BY_SEQ_NUM],[COMMENT_TEXT]" +
      " ,[CREATED_BY],[TYPE_DESC]) VALUES " +
        "(" + entity.LogNumber + ",'"+ entity.BasicNumber + "','"  + entity.CommentTypeCode.ToString() + "',"
         + entity.LinkToSeqNum + ",'" + DateTime.Now + "'," + entity.CreatedBySeqNum + ",'"
         + entity.Comment.ToString() + "','" + entity.CreatedBy + "','" + entity.TypeDesc.ToString() + "')";
           int rowsAffected = _db.Execute(mySQL);
            return entity;
        }
       

        public LogComment Save(LogComment entity)
        {
            throw new NotImplementedException();
        }
    }





}
