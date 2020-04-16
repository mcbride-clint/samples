using System;
using System.Collections.Generic;
using MDCLogArchitecture.DataAccess.Repositories;
using MDCLogArchitecture.Models.DomainModels;
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

        public ICommentType InsertType(ICommentType entity)
        {
            string mySQL = "INSERT INTO [TM_MDC_COMMENT_TYPES] ([TYPE],[TYPE_DESC]) VALUES " +
        "('" + entity.CommentTypeCode + "','" + entity.TypeDesc.ToString() + "')";
            int rowsAffected = _db.Execute(mySQL);
            return entity;
        }

        public ICommentType SaveType(ICommentType entity)
        {
            throw new NotImplementedException();
        }

        public ICommentType EditType(ICommentType entity)
        {
            string mySQL = "UPDATE[dbo].[TM_MDC_COMMENT_TYPES] SET[TYPE] = '" + entity.CommentTypeCode + "'" +
              ",[TYPE_DESC] = '" + entity.TypeDesc + "'" +
              $" WHERE[Type] = @{nameof(entity.CommentTypeCode)}";
            int rowsAffected = _db.Execute(mySQL, entity);
            return entity;
        }

        public ICommentType FindType(string CommentTypeCode)
        {
            string findSQL = listSQL + " Where Type = '" + CommentTypeCode + "'";
                CommentType commentType = _db.QuerySingle<CommentType>(findSQL);
                return commentType;
        }

        public IEnumerable<ICommentType> FindTypeList()
        {
                 return _db.Query<CommentType>(listSQL);
        }

        public ICommentType DeleteType(string CommentTypeCode)
        {
            throw new NotImplementedException();
        }
        public ICommentType EditType2(CommentType entity)
        {
            string mySQL = "UPDATE[dbo].[TM_MDC_COMMENT_TYPES] SET[TYPE] = '" + entity.CommentTypeCode + "'" +
              ",[TYPE_DESC] = '" + entity.TypeDesc + "'" +
              $" WHERE[Type] = @{nameof(entity.CommentTypeCode)}";
             int rowsAffected = _db.Execute(mySQL, entity);
            return entity;
        }

        //public ICommentTypesRepository FindType(string CommentTypeCode)

        //{
        //    string findSQL = listSQL + " Where Type = '" + CommentTypeCode + "'";
        //    ICommentType commentType = _db.QuerySingle<ICommentType>(findSQL);
        //    return commentType;
        //}
        // public CommentType DeleteType(string CommentTypeCode)
        // {/// need to work this one out
        //     string delSQL = " Delete[dbo].[TM_MDC_COMMENT_TYPES] where TYPE =  '" + CommentTypeCode + "'";
        //     CommentType commentType = _db.QuerySingle<CommentType>(delSQL);
        //     return commentType;
        // }

        // public List<CommentType> FindTypeList()
        // {
        //     List<CommentType> commentTypes = _db.Query<CommentType>(listSQL).ToList();
        //     return commentTypes;
        // }

        // public CommentType InsertType(CommentType entity)
        // {
        //     string mySQL = "INSERT INTO [TM_MDC_COMMENT_TYPES] ([TYPE],[TYPE_DESC]) VALUES " +
        //"('" + entity.CommentTypeCode + "','" + entity.TypeDesc.ToString() + "')";
        //     int rowsAffected = _db.Execute(mySQL);
        //     return entity;
        // }

        // public CommentType SaveType(CommentType entity)
        // {
        //     throw new NotImplementedException();
        // }

    }
}
