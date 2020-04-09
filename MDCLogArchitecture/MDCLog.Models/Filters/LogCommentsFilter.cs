using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLogArchitecture.Models.Filters
{
    public class LogCommentsFilter
    {
        
        public int? LogNumber { get; set; }
        public int? SeqNum { get; set; }
        

    }
    public class CommentsTypeFilter
    {

        public string CommentTypeCode { get; set; }
        


    }
}
