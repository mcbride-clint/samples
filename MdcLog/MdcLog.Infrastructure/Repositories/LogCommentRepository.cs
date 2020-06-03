using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml;
using Dapper;
using MdcLog.Application.Comments;
using MdcLog.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace MdcLog.Infrastructure
{
    public class LogCommentRepository : ILogCommentRepository
    {
        private string listSQL = "SELECT  [SEQ_NUM] as SeqNum ,[LOG_NUM] as LogNumber" +
      ",[BASIC_NUMBER] as BasicNumber ,[TYPE] as Type , [LINK_TO_SEQ_NUM] as LinkToSeqNum" +
      ",[CREATED_DATE] as  CreateDate ,[CREATED_BY_SEQ_NUM] as CreatedBySeqNum " +
      " ,[COMMENT_TEXT] as Comment,[CREATED_BY] as CreatedBy ,[TYPE_DESC] as TypeDesc " +
  " FROM [mdc].[dbo].[TM_DIST_CHG_LOG_COMMENTS]";

        readonly System.Data.IDbConnection _db;



        public LogCommentRepository(IDbConnection db)
        {
            _db = db;
        }

        public LogComment InsertComment(LogComment entity)
        {
            string mySQL = "INSERT INTO [dbo].[TM_DIST_CHG_LOG_COMMENTS] "
            + "([LOG_NUM] "
           + ",[BASIC_NUMBER] "
           + ",[TYPE] "
           + ",[LINK_TO_SEQ_NUM] "
           + ",[CREATED_DATE]"
           + ",[CREATED_BY_SEQ_NUM]"
           + ",[COMMENT_TEXT]"
           + ",[CREATED_BY]"
           + ",[TYPE_DESC]) VALUES ("
           + entity.LogNumber
           + ",'" + entity.BasicNumber + "'"
           + ",'" + entity.CommentTypeCode + "'"
           + "," + entity.LinkToSeqNum
           + ",'" + DateTime.Now  + "'"
           + "," + entity.CreatedBySeqNum
           + ",'" + entity.Comment + "'"
           + ",'" + entity.CreatedBy + "'"
           + ",'" + entity.TypeDesc + "')";
            int rowsAffected = _db.Execute(mySQL);
            return entity;
        }







        public ICollection<LogComment> FindCommentList(string Log)
        {
            string getSQL = listSQL + " Where LOG_NUM = " + Log;
            return _db.Query<LogComment>(getSQL).ToList();
        }




    }
}
