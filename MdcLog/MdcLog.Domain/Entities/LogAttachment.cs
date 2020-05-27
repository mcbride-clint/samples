using System;
using System.Collections.Generic;
using System.Text;

namespace MdcLog.Domain.Entities
{
    class LogAttachment
    {
        public int SeqNum { get; set; }
        public string FileName { get; set; }
        public string FileDescription { get; set; }
        public string MimeType { get; set; }
        public string Classification { get; set; }
        public DateTime CreateDate { get; set; }    // change to dateTime - didn't have in community edition
        public int CreatedBySeqNum { get; set; }
        public byte FileContent { get; set; }     // change to blob type
    }
}
