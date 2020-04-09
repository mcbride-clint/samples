using System;
using System.Collections.Generic;
using MDCLogArchitecture.Models.DomainModels;
using System.Text;

namespace MDCLogArchitecture.Models.Interfaces.Repositories
{/// <summary>
 /// Commenttypes maintenance
  /// </summary>
 /// <param name="entity"></param>
 /// <returns></returns>
    public interface ICommentTypesRepository
    {
        CommentType InsertType(CommentType entity);
         CommentType SaveType(CommentType entity);
         CommentType EditType(CommentType entity);
        CommentType FindType(string CommentTypeCode);
         List<CommentType> FindTypeList();
        CommentType DeleteType(string CommentTypeCode);
    }
}
