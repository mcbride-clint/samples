

using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.ViewModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using MDCLogArchitecture.Domain.Interfaces.Repositories;
using System.Linq;

namespace MDCLogArchitecture.Domain.Services
{
    public class CommentService
    {
        Domain.Interfaces.Repositories.ILogCommentsRepository _commentsRepo;
        ILogger<CommentService> _logger;

        /// <summary>
        /// Initialize the Service with an instance of an injected User Repository
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="commentsRepo"></param>
        public CommentService(ILogger<CommentService> logger, ILogCommentsRepository commentsRepo)
        {
            _logger = logger;
            _commentsRepo = commentsRepo;

        }
        /// <summary>
        /// Get All Comments
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<LogComment> FindList(int filter)
        {
            return _commentsRepo.FindList(filter).ToList();
        }
        public LogComment Find(int SeqNum)
        {
            return _commentsRepo.Find(SeqNum);
        }
        public LogCommentVM Insert(LogCommentVM ThisComment)
        {
            _logger.LogInformation("No UserIdSeqNum Found, inserting new record");
            return _commentsRepo.Insert(ThisComment);
        }
        public LogCommentVM GetCreateCommentVMType()
        {
            return new LogCommentVM();
        }


    }
}