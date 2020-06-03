using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace MdcLog.Application.StatusCodes.Models
{
    public class CreateStatusCodeVM
    {
        
        [Required]
        public string Status { get; set; }
        [Required]
        public string Descr { get; set; }
    }
}
