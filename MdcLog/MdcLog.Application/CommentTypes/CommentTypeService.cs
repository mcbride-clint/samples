using MdcLog.Application.CommentTypes.Models;
using MdcLog.Application.CommentTypes;
using MdcLog.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MdcLog.Application.CommentTypes
{
    public class CommentTypeService
    {
        ICommentTypeRepository _commentTypesRepo;
        ILogger<CommentTypeService> _logger;
        /// <summary>
        /// Initialize the Service with an instance of an injected User Repository
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="commentTypesRepo"></param>
        public CommentTypeService(ILogger<CommentTypeService> logger, ICommentTypeRepository commentTypesRepo)
        {
            _logger = logger;
            _commentTypesRepo = commentTypesRepo;

        }
        /// /// <summary>
        /// Get All Comment Types
        /// </summary>
        /// <returns></returns>
        public List<CommentTypeView> FindTypeList()
        {
            //var commentTypes = _commentTypesRepo.FindTypeList();

            //var viewList = new List<CommentTypeView>();


            // Linq
            var commentTypesList = _commentTypesRepo.FindTypeList();

            var linqViewList = commentTypesList
                .Select(item => new CommentTypeView()
                {
                    CommentTypeCode = item.CommentTypeCode,
                    TypeDesc = item.TypeDesc
                })
                .ToList();

            // Standard Loop
            //foreach (var item in commentTypes)
            //{
            //    viewList.Add(new CommentTypeView()
            //    {
            //        CommentTypeCode = item.CommentTypeCode,
            //        TypeDesc = item.TypeDesc
            //    });
            //}

            return linqViewList;
        }
        public CreateCommentTypeVM GetCreateCommentVMType()
        {
            return new CreateCommentTypeVM();
        }
        public UpdateCommentTypeVM GetCreateUpdateVMType()
        {
            return new UpdateCommentTypeVM();
        }
        public DeleteCommentTypeVM GetDeleteCommentTypeVM()
        {
            return new DeleteCommentTypeVM();
        }
        public UpdateCommentTypeVM FindType(string CommentTypeCode)
        {
            var foundType = _commentTypesRepo.FindType(CommentTypeCode);

            return new UpdateCommentTypeVM()
            {
                CommentTypeCode = foundType.CommentTypeCode,
                TypeDesc = foundType.TypeDesc
            };
        }
        public DeleteCommentTypeVM FindDeleteType(string CommentTypeCode)
        {
            var foundType = _commentTypesRepo.FindType(CommentTypeCode);

            return new DeleteCommentTypeVM()
            {
                CommentTypeCode = foundType.CommentTypeCode,
                TypeDesc = foundType.TypeDesc
            };
        }
        public CreateCommentTypeVM InsertType(CreateCommentTypeVM ThisCommentType)
        {
            var insertComment = new CommentType()
            {
                CommentTypeCode = ThisCommentType.CommentTypeCode,
                TypeDesc = ThisCommentType.TypeDesc
            };
            _commentTypesRepo.InsertType(insertComment);
            return ThisCommentType;
        }
        public UpdateCommentTypeVM EditType(UpdateCommentTypeVM ThisCommentType)
        {
            var updateComment = new CommentType()
            {
                CommentTypeCode = ThisCommentType.CommentTypeCode,
                TypeDesc = ThisCommentType.TypeDesc
            };
            _commentTypesRepo.EditType(updateComment);
            return ThisCommentType;
        }
        public DeleteCommentTypeVM DeleteType(DeleteCommentTypeVM ThisCommentType)
        {
            var deleteComment = new CommentType()
            {
                CommentTypeCode = ThisCommentType.CommentTypeCode,
                TypeDesc = ThisCommentType.TypeDesc
            };
            _commentTypesRepo.DeleteType(deleteComment);
            return ThisCommentType;
        }
    }
}

