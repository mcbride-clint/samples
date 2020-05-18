using MDCLogArchitecture.Domain.Interfaces.Repositories;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.ViewModels;
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

        public IList<CommentType> FindTypeList()
        {
            _logger.LogError("Hello");
            return _commentTypesRepo.FindTypeList().ToList();
        }
        public CommentTypeVM FindType(string typecode)
        {
            return _commentTypesRepo.FindType(typecode);
        }
        public CommentTypeVM GetCreateCommentVMType()
        {
            return new CommentTypeVM();
        }
        public CommentTypeVM InsertType(CommentTypeVM ThisCommentType)
        {
            return _commentTypesRepo.InsertType(ThisCommentType);
        }
        public CommentTypeVM EditType(CommentTypeVM ThisCommentType)
        {
            return _commentTypesRepo.EditType(ThisCommentType);
        }
        public int DeleteType(string typecode)
        {
            int recordsDeleted = _commentTypesRepo.DeleteType(typecode);
            return recordsDeleted;
        }
    }
}
