
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.Filters;
using MDCLogArchitecture.Models.Interfaces.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLogArchitecture.Services
{
    public class MDCLogService
    {
        ILogCommentsRepository _commentsRepo;
        ILogger<MDCLogService> _logger;

        /// <summary>
        /// Initialize the Service with an instance of an injected User Repository
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="commentTypesRepo"></param>
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
        public List<LogComments> FindList(LogCommentsFilter filter)
        {
            return _commentsRepo.FindList(filter);
        }
        public LogComments Find(int SeqNum)
        {
            return _commentsRepo.Find(SeqNum);
        }
        public LogComments Save(LogComments ThisComment)
        {
            _logger.LogInformation("No UserIdSeqNum Found, inserting new record");
            return _commentsRepo.Insert(ThisComment);
        }
        /// <summary>
        /// Get Comment Types
        /// </summary>
        
    }
}
