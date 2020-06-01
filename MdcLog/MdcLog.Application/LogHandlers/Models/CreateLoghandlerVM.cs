using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MdcLog.Application.LogHandlers.Models
{
    public class CreateLoghandlerVM
    {
        public int UserSeqNum { get; set; }
        public string Code { get; set; }
        public string Tmma { get; set; }
    }
}
