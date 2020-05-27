using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml;
using Dapper;
using MdcLog.Application.CommentTypes;
using MdcLog.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace MdcLog.Infrastructure.Repositories
{
  public  class CommentTypeRepository : ICommentTypeRepository
    {
       
        private string listSQL = "Select TYPE as CommentTypeCode,TYPE_DESC as TypeDesc" +
           " from TM_MDC_COMMENT_TYPES";
        
        readonly System.Data.IDbConnection _db;

       
       
        public CommentTypeRepository(IDbConnection db)
        {
            _db = db;
        }

        public CommentType InsertType(CommentType entity)
        {
            string mySQL = "INSERT INTO [TM_MDC_COMMENT_TYPES] ([TYPE],[TYPE_DESC]) VALUES " +
        "('" + entity.CommentTypeCode + "','" + entity.TypeDesc.ToString() + "')";
            int rowsAffected = _db.Execute(mySQL);
            return entity;
        }

        public CommentType SaveType(CommentType entity)
        {
            throw new NotImplementedException();
        }

        public CommentType EditType(CommentType entity)
        {
            string mySQL = "UPDATE[dbo].[TM_MDC_COMMENT_TYPES] SET[TYPE] = '" + entity.CommentTypeCode + "'" +
              ",[TYPE_DESC] = '" + entity.TypeDesc + "'" +
              $" WHERE[Type] = @{nameof(entity.CommentTypeCode)}";
            int rowsAffected = _db.Execute(mySQL, entity);
            return entity;
        }

        public CommentType FindType(string CommentTypeCode)
        {
            string findSQL = listSQL + " Where Type = '" + CommentTypeCode + "'";
            CommentType commentType = _db.QuerySingle<CommentType>(findSQL);
            return commentType;
        }

        public ICollection<CommentType> FindTypeList()
        {
             return _db.Query<CommentType>(listSQL).ToList();
        }

        public CommentType DeleteType(CommentType entity)
        {
            string mySQL = " Delete[dbo].[TM_MDC_COMMENT_TYPES] " + $" WHERE[Type] = @{nameof(entity.CommentTypeCode)}";
            int rowsAffected = _db.Execute(mySQL, entity);
            return entity;
        }
        public CommentType EditType2(CommentType entity)
        {
            string mySQL = "UPDATE[dbo].[TM_MDC_COMMENT_TYPES] SET[TYPE] = '" + entity.CommentTypeCode + "'" +
              ",[TYPE_DESC] = '" + entity.TypeDesc + "'" +
              $" WHERE[Type] = @{nameof(entity.CommentTypeCode)}";
            int rowsAffected = _db.Execute(mySQL, entity);
            return entity;
        }

        

    }
}
