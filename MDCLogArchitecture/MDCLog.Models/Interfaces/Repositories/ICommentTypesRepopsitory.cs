using System;
using System.Collections.Generic;
using MDCLogArchitecture.Models.DomainModels;
using System.Text;

namespace MDCLogArchitecture.Models.Interfaces.Repositories
{
    public interface ICommentTypesRepository
    {
        CommentType InsertType(CommentType entity);
         CommentType SaveType(CommentType entity);
         CommentType EditType(CommentType entity);

         List<CommentType> FindTypeList();
    }
}
