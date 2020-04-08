using System;
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
    public class CommentsTypeRepository : ICommentTypesRepository
    {
        private string listSQL = "Select TYPE as CommentTypeCode,TYPE_DESC as TypeDesc" +
           " from TM_MDC_COMMENT_TYPES";

        readonly System.Data.IDbConnection _db;
        public CommentsTypeRepository(IDbConnection db)
        {
            _db = db;
        }
        public CommentType EditType(CommentType entity)
        {
            string mySQL = "UPDATE[dbo].[TM_MDC_COMMENT_TYPES] SET[TYPE] = '" + entity.CommentTypeCode + "'" +
              ",[TYPE_DESC] = '" + entity.TypeDesc + "'" +
              " WHERE[Type] = '" + entity.CommentTypeCode + "'";
            int rowsAffected = _db.Execute(mySQL);
            return entity;
        }
        public CommentType FindType(string CommentTypeCode)
        {
            string findSQL = listSQL + " Where Type = '" + CommentTypeCode + "'";
            CommentType commentType = _db.QuerySingle<CommentType>(findSQL);
            return commentType;
        }
        public List<CommentType> FindTypeList()
        {
            List<CommentType> commentTypes = _db.Query<CommentType>(listSQL).ToList();
            return commentTypes;
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
    }
}
