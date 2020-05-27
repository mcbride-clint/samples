using MdcLog.Application.Comments.Models;
using MdcLog.Application.Comments;
using MdcLog.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MdcLog.Application.Comments
{
    public class LogCommentService
    {
        ILogCommentRepository _commentsRepo;
        ILogger<LogCommentService> _logger;
        /// <summary>
        /// Initialize the Service with an instance of an injected User Repository
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="commentsRepo"></param>
        public LogCommentService(ILogger<LogCommentService> logger, ILogCommentRepository commentsRepo)
        {
            _logger = logger;
            _commentsRepo = commentsRepo;

        }
        /// /// <summary>
        /// Get All Comment Types
        /// </summary>
        /// <returns></returns>
        public List<LogCommentView> FindCommentList()
        {
            //var commentTypes = _commentTypesRepo.FindTypeList();

            //var viewList = new List<CommentTypeView>();


            // Linq
            var commentList = _commentsRepo.FindCommentList();

            var linqViewList = commentList
                .Select(item => new LogCommentView()
                {
                    CommentTypeCode = item.CommentTypeCode,
                    TypeDesc = item.TypeDesc,
                    BasicNumber = item.BasicNumber,
                    Comment = item.Comment,
                    CreateDate= item.CreateDate,
                    CreatedBy = item.CreatedBy,
                    CreatedBySeqNum = item.CreatedBySeqNum,
                    LinkToSeqNum = item.LinkToSeqNum,
                    LogNumber = item.LogNumber,
                    SeqNum = item.SeqNum
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



        public CreateLogCommentVM GetCreateCommentVMType()
        {
            return new CreateLogCommentVM();
        }

        public CreateLogCommentVM InsertComment(CreateLogCommentVM ThisComment)
        {
            var insertComment = new LogComment()
            {
                CommentTypeCode = ThisComment.CommentTypeCode,
                TypeDesc = ThisComment.TypeDesc,
                BasicNumber = ThisComment.BasicNumber,
                Comment = ThisComment.Comment,
                CreateDate = ThisComment.CreateDate,
                CreatedBy = ThisComment.CreatedBy,
                CreatedBySeqNum = ThisComment.CreatedBySeqNum,
                LinkToSeqNum = ThisComment.LinkToSeqNum,
                LogNumber = ThisComment.LogNumber,
                SeqNum = ThisComment.SeqNum
            };
            _commentsRepo.InsertComment(insertComment);
            return ThisComment;
        }

    }
}
