using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MdcLog.Application.CommentTypes.Models
{
    public class DeleteCommentTypeVM
    {
        [ReadOnly(isReadOnly: true)]
        public string CommentTypeCode { get; set; }
        [ReadOnly(isReadOnly: true)]
        public string TypeDesc { get; set; }
    }
}

