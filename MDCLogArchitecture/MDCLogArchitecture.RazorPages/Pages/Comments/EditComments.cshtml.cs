using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.Extensions.Logging;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Domain.Services;
using MDCLogArchitecture.Domain.Interfaces;

namespace MDCLogArchitecture.RazorPages.Pages.Comments
{
    public class EditCommentsModel : PageModel
    {
        private readonly ILogger<EditCommentsModel> _logger;
        private readonly MDCLogService _service;

        public EditCommentsModel(ILogger<EditCommentsModel> logger, MDCLogService service)
        {
            _service = service;
            _logger = logger;
        }

        [BindProperty]
        public LogComments ThisComment { get; set; }
        [BindProperty]
        public int SeqNum { get; set; }
        [BindProperty]
        public int LogNumber { get; set; }
        [BindProperty]
        public string Type { get; set; }
        [BindProperty]
        public string TypeDesc { get; set; }
        [BindProperty]
        public string BasicNumber { get; set; }
        [BindProperty]
        public string Comment { get; set; }
        [BindProperty]
        public DateTime CreateDate { get; set; }
        [BindProperty]
        public int CreatedBySeqNum { get; set; }
        [BindProperty]
        public string CreatedBy { get; set; }
        [BindProperty]
        public int LinkToSeqNum { get; set; }
        
        public void OnGet(int SeqNum)
        {
            //ThisComment = _service.Find(SeqNum);
            ToViewModel(_service.Find(SeqNum));
            _logger.LogInformation($"User opened {SeqNum} for editing");
        }
        private void ToViewModel(ILogComments entity)
        {
            this.LogNumber = entity.LogNumber;
            this.SeqNum = entity.SeqNum;
            this.BasicNumber = entity.BasicNumber;
            this.LinkToSeqNum = entity.LinkToSeqNum;
            this.CreateDate = entity.CreateDate;
            this.CreatedBy = entity.CreatedBy;
            this.Type = entity.Type;
            this.TypeDesc = entity.TypeDesc;
            this.Comment = entity.Comment;

        }

    }
}