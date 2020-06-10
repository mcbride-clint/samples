using MdcLog.Application.HandlerCodes.Models;
using MdcLog.Application.HandlerCodes;
using MdcLog.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MdcLog.Application.HandlerCodes
{
    public class HandlerCodeService
    {
        IHandlerCodeRepository _handlerCodesRepo;
        ILogger<HandlerCodeService> _logger;
        /// <summary>
        /// Initialize the Service with an instance of an injected User Repository
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="handlerCodesRepo"></param>
        public HandlerCodeService(ILogger<HandlerCodeService> logger, IHandlerCodeRepository handlerCodesRepo)
        {
            _logger = logger;
            _handlerCodesRepo = handlerCodesRepo;

        }
        /// /// <summary>
        /// Get All Comment Types
        /// </summary>
        /// <returns></returns>
        public List<HandlerCodeView> FindHandlerCodeList()
        {
            //var commentTypes = _commentTypesRepo.FindTypeList();

            //var viewList = new List<CommentTypeView>();


            // Linq
            var handlerCodesList = _handlerCodesRepo.FindHandlerCodeList();

            var linqViewList = handlerCodesList
                .Select(item => new HandlerCodeView()
                {
                    Code = item.Code,
                    Descr = item.Descr
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
        public CreateHandlerCodeVM GetCreateHandlerCodeVM()
        {
            return new CreateHandlerCodeVM();
        }
        public EditHandlerCodeVM GetCreateUpdateHandlerCodeVM()
        {
            return new EditHandlerCodeVM();
        }
        public DeleteHandlerCodeVM GetDeleteHandlerCodeVM()
        {
            return new DeleteHandlerCodeVM();
        }
        public EditHandlerCodeVM FindHandlerCode(string Code)
        {
            var foundType = _handlerCodesRepo.FindHandlerCode(Code);

            return new EditHandlerCodeVM()
            {
                Code = foundType.Code,
                Descr = foundType.Descr
            };
        }
        public DeleteHandlerCodeVM FindDeleteCode(string Code)
        {
            var foundHandlerCode = _handlerCodesRepo.FindHandlerCode(Code);

            return new DeleteHandlerCodeVM()
            {
                Code = foundHandlerCode.Code,
                Descr = foundHandlerCode.Descr
            };
        }
        public CreateHandlerCodeVM InsertHandlerCode(CreateHandlerCodeVM ThisHandlerCode)
        {
            var insertHandlerCode = new HandlerCode()
            {
                Code = ThisHandlerCode.Code,
                Descr = ThisHandlerCode.Descr
            };
            _handlerCodesRepo.InsertHandlerCode(insertHandlerCode);
            return ThisHandlerCode;
        }
        public EditHandlerCodeVM EditHandlerCode(EditHandlerCodeVM ThisHandlerCode)
        {
            var updateHandlerCode = new HandlerCode()
            {
                Code = ThisHandlerCode.Code,
                Descr = ThisHandlerCode.Descr
            };
            _handlerCodesRepo.EditHandlerCode(updateHandlerCode);
            return ThisHandlerCode;
        }
        public DeleteHandlerCodeVM DeleteHandlerCode(DeleteHandlerCodeVM ThisHandlerCode)
        {
            var deleteHandlerCode = new HandlerCode()
            {
                Code = ThisHandlerCode.Code,
                Descr = ThisHandlerCode.Descr
            };
            _handlerCodesRepo.DeleteHandlerCode(deleteHandlerCode);
            return ThisHandlerCode;
        }

    }
}
