﻿using MDCLogArchitecture.Domain.Interfaces.Repositories;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MDCLogArchitecture.Domain.Services
{
    
    public class CommentTypeService
    {
        ICommentTypesRepository _commentTypesRepo;
        ILogger<CommentTypeService> _logger;
        /// <summary>
        /// Initialize the Service with an instance of an injected User Repository
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="commentTypesRepo"></param>
        public CommentTypeService(ILogger<CommentTypeService> logger, ICommentTypesRepository commentTypesRepo)
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
            _logger.LogError("Hello");
            return _commentTypesRepo.FindTypeList().ToList();
        }
        public CommentType FindType(string CommentTypeCode)
        {
            return _commentTypesRepo.FindType(CommentTypeCode);
        }
        public CommentType InsertType (CommentType ThisCommentType)
        {
            return _commentTypesRepo.InsertType( ThisCommentType);
        }
        public CommentType EditType(CommentType ThisCommentType)
        {
            return _commentTypesRepo.EditType(ThisCommentType);
        }
    }
}
