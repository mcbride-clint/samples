
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
        public List<LogComments> Find(LogCommentsFilter filter)
        {
            return _commentsRepo.Find(filter);
        }
    }
}
