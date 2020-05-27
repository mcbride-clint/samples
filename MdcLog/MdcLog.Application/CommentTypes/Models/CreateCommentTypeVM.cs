using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace MdcLog.Application.CommentTypes.Models
{
    public class CreateCommentTypeVM
    {
        [Required]
        public string CommentTypeCode { get; set; }
        [Required]
        public string TypeDesc { get; set; }
    }
}
