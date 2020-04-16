using System.Collections.Generic;

namespace MDCLogArchitecture.Domain.Interfaces.Repositories
{/// <summary>
 /// Commenttypes maintenance
 /// </summary>
 /// <param name="entity"></param>
 /// <returns></returns>
    public interface ICommentTypesRepository
    {
        ICommentType InsertType(ICommentType entity);
        ICommentType SaveType(ICommentType entity);
        ICommentType EditType(ICommentType entity);
        ICommentType FindType(string CommentTypeCode);
        IEnumerable<ICommentType> FindTypeList();
        ICommentType DeleteType(string CommentTypeCode);
    }
}
