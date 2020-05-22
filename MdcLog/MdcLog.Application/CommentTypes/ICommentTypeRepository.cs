using System;
using System.Collections.Generic;
using MdcLog.Domain.Entities;
using System.Text;
using MdcLog.Application.CommentTypes.Models;

namespace MdcLog.Application.CommentTypes
{
    public interface ICommentTypeRepository
    {
        CommentType InsertType(CommentType entity);
        CommentType SaveType(CommentType entity);
        CommentType EditType(CommentType entity);
        CommentType FindType(string CommentTypeCode);
        ICollection<CommentType> FindTypeList();
        CommentType DeleteType(CommentType entity);
        
    }
}
