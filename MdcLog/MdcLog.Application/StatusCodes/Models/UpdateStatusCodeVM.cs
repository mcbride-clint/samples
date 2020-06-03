using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MdcLog.Application.StatusCodes.Models
{
    public class UpdateStatusCodeVM
    {

        [ReadOnly(isReadOnly: true)]
        public string Status { get; set; }
        [Required]
        public string Descr { get; set; }
    }
}
