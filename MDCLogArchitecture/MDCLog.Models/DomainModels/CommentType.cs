using MDCLogArchitecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLogArchitecture.Models.DomainModels
{
    public class CommentType :ICommentType
    {
        public string CommentTypeCode { get; set; }
        public string TypeDesc { get; set; }
    }
}
