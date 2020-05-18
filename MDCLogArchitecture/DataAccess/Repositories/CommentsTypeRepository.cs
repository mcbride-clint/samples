using System;
using System.Collections.Generic;
using MDCLogArchitecture.DataAccess.Repositories;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.ViewModels;
using Dapper;
using System.Linq;
using System.Data;
using MDCLogArchitecture.Domain.Interfaces.Repositories;
using MDCLogArchitecture.Domain.Interfaces;

namespace MDCLogArchitecture.DataAccess.Repositories
{
    public class CommentsTypeRepository : ICommentTypesRepository
    {
        private string listSQL = "Select TYPE as CommentTypeCode,TYPE_DESC as TypeDesc" +
           " from TM_MDC_COMMENT_TYPES";

        readonly System.Data.IDbConnection _db;
        public CommentsTypeRepository(IDbConnection db)
        {
            _db = db;
        }

        public CommentTypeVM InsertType(CommentTypeVM entity)
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

        public CommentTypeVM EditType(CommentTypeVM entity)
        {
            string mySQL = "UPDATE[dbo].[TM_MDC_COMMENT_TYPES] SET[TYPE] = '" + entity.CommentTypeCode + "'" +
              ",[TYPE_DESC] = '" + entity.TypeDesc + "'" +
              $" WHERE[Type] = @{nameof(entity.CommentTypeCode)}";
            int rowsAffected = _db.Execute(mySQL, entity);
            return entity;
        }

        public CommentTypeVM FindType(string CommentTypeCode)
        {
            string findSQL = listSQL + " Where Type = '" + CommentTypeCode + "'";
            CommentTypeVM commentType = _db.QuerySingle<CommentTypeVM>(findSQL);
            return commentType;
        }

        public IEnumerable<CommentType> FindTypeList()
        {
            string findSQL = listSQL + " ORDER BY COMMENT_TYPE_CODE";
            return _db.Query<CommentType>(listSQL).ToList();
        }

        public int DeleteType(string CommentTypeCode)
        {
            int deletedRecords = _db.Execute("DELETE[dbo].[TM_MDC_COMMENT_TYPES] where Type = '" + CommentTypeCode + "'");
            return deletedRecords;
        }




    }
}
