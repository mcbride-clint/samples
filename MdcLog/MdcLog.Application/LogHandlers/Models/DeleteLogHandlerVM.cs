using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MdcLog.Application.LogHandlers.Models
{
     public class DeleteLogHandlerVM
    {
        [ReadOnly(isReadOnly: true)] 
        public int Uid { get; set; }
        [ReadOnly(isReadOnly: true)] 
        public int UserSeqNum { get; set; }
        [ReadOnly(isReadOnly: true)] 
        public string Code { get; set; }
        [ReadOnly(isReadOnly: true)] 
        public string Tmma { get; set; }
    }
}
