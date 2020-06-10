using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MdcLog.Application.CommentTypes.Models
{
    public class EditCommentTypeVM
    {
        [ReadOnly(isReadOnly: true)]
        public string CommentTypeCode { get; set; }
        [Required]
        public string TypeDesc { get; set; }
    }
}
