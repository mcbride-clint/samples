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
      ",[BASIC_NUMBER] as BasicNumber ,[TYPE] as Type ,[LINK_TO_SEQ_NUM] as LinkToSeqNum" +
      ",[CREATED_DATE] as  CreatedDate ,[CREATED_BY_SEQ_NUM] as CreatedBySeqNum " +
      " ,[COMMENT_TEXT] as Comment,[CREATED_BY] as CreatedBy ,[TYPE_DESC] as Type " +
  " FROM [mdc].[dbo].[TM_DIST_CHG_LOG_COMMENTS]";

        readonly System.Data.IDbConnection _db;



        public LogCommentRepository(IDbConnection db)
        {
            _db = db;
        }

        public LogComment InsertComment(LogComment entity)
        {
            string mySQL = "INSERT INTO [TM_MDC_COMMENT_TYPES] ([TYPE],[TYPE_DESC]) VALUES " +
        "('" + entity.CommentTypeCode + "','" + entity.TypeDesc.ToString() + "')";
            int rowsAffected = _db.Execute(mySQL);
            return entity;
        }







        public ICollection<LogComment> FindCommentList()
        {
            return _db.Query<LogComment>(listSQL).ToList();
        }




    }
}
