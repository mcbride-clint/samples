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
        private string listSQL = "Select TYPE as Type,TYPE_DESC as TypeDesc" +
           " from TM_MDC_COMMENT_TYPES";

        readonly System.Data.IDbConnection _db;
        public CommentsTypeRepository(IDbConnection db)
        {
            _db = db;
        }
        public CommentType EditType(CommentType entity)
        {
            throw new NotImplementedException();
        }

        public List<CommentType> FindTypeList()
        {
            List<CommentType> commentTypes = _db.Query<CommentType>(listSQL).ToList();
            return commentTypes;
        }

        

        public CommentType InsertType(CommentType entity)
        {
            throw new NotImplementedException();
        }

        public CommentType SaveType(CommentType entity)
        {
            throw new NotImplementedException();
        }
       

        
    }
}
