using System.Collections.Generic;
using MDCLogArchitecture.Models.DomainModels;

namespace MDCLogArchitecture.Domain.Interfaces.Repositories
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
        IEnumerable<CommentType> FindTypeList();
        CommentType DeleteType(string CommentTypeCode);
    }
}
