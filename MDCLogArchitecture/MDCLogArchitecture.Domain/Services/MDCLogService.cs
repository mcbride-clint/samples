using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Domain.Interfaces;
using MDCLogArchitecture.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MDCLogArchitecture.Domain.Services
{
    public class MDCLogService
    {
        ILogCommentsRepository _commentsRepo;
        ILogger<MDCLogService> _logger;

        /// <summary>
        /// Initialize the Service with an instance of an injected User Repository
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="commentsRepo"></param>
        public MDCLogService(ILogger<MDCLogService> logger, ILogCommentsRepository commentsRepo)
        {
            _logger = logger;
            _commentsRepo = commentsRepo;
            
        }
        /// <summary>
        /// Get All Comments
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<LogComment> FindList(int LogNum)
        {
            return _commentsRepo.FindList(LogNum).ToList();
        }
        public LogComment Find(int SeqNum)
        {
            return _commentsRepo.Find(SeqNum);
        }
        public LogComment Save(LogComment ThisComment)
        {
            _logger.LogInformation("No UserIdSeqNum Found, inserting new record");
            return _commentsRepo.Insert(ThisComment);
        }


    }
}
