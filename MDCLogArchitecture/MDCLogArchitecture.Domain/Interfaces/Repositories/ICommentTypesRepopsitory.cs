using System.Collections.Generic;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.ViewModels;

namespace MDCLogArchitecture.Domain.Interfaces.Repositories
{/// <summary>
 /// Commenttypes maintenance
 /// </summary>
 /// <param name="entity"></param>
 /// <returns></returns>
    public interface ICommentTypesRepository
    {
        CommentTypeVM InsertType(CommentTypeVM entity);
        CommentType SaveType(CommentType entity);
        CommentTypeVM EditType(CommentTypeVM entity);
        CommentTypeVM FindType(string CommentTypeCode);
        IEnumerable<CommentType> FindTypeList();
         int DeleteType(string CommentTypeCode);
    }
}
