using System;
using System.Collections.Generic;
using MdcLog.Domain.Entities;
using System.Text;

namespace MdcLog.Application.Comments
{
    public interface ILogCommentRepository
    {
        LogComment InsertComment(LogComment entity);
        
        ICollection<LogComment> FindCommentList();
       
    }
}
