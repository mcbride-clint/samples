using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.Interfaces.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLogArchitecture.Services
{
    
    public class CommentTypeServices
    {
        ICommentTypesRepository _commentTypesRepo;
        ILogger<CommentTypeServices> _logger;
        /// <summary>
        /// Initialize the Service with an instance of an injected User Repository
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="commentTypesRepo"></param>
        public CommentTypeServices(ILogger<CommentTypeServices> logger, ICommentTypesRepository commentTypesRepo)
        {
            _logger = logger;
            _commentTypesRepo = commentTypesRepo;

        }
        /// /// <summary>
        /// Get All Comment Types
        /// </summary>
        /// <returns></returns>
        public List<CommentType> FindTypeList()
        {
            return _commentTypesRepo.FindTypeList();
        }
    }
}
