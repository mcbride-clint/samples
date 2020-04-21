using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLogArchitecture.Domain.Interfaces
{
    public interface ICommentType
    {
         string CommentTypeCode { get; set; }
         string TypeDesc { get; set; }
    }
}
