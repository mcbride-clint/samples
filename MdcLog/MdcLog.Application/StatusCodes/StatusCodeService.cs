using MdcLog.Domain.Entities;
using MdcLog.Application.StatusCodes.Models;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Text;

namespace MdcLog.Application.StatusCodes
{
    public class StatusCodeService 
    {
        IStatusCodeRepository _statusCodesRepo;
        ILogger<StatusCodeService> _logger;
        /// <summary>
        /// Initialize the Service with an instance of an injected User Repository
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="statusCodesRepo"></param>
        public StatusCodeService(ILogger<StatusCodeService> logger, IStatusCodeRepository statusCodesRepo)
        {
            _logger = logger;
            _statusCodesRepo = statusCodesRepo;

        }

        public CreateStatusCodeVM GetCreateStatusCodeVM()
        {
            return new CreateStatusCodeVM();
        }
        public EditStatusCodeVM GetUpdateStatusCodeVM()
        {
            return new EditStatusCodeVM();
        }
        public DeleteStatusCodeVM GetDeleteStatusCodeVM()
        {
            return new DeleteStatusCodeVM();
        }
        public CreateStatusCodeVM CreateStatusCode(CreateStatusCodeVM entity)
        {
            throw new NotImplementedException();
        }
        public DeleteStatusCodeVM DeleteStatusCode(DeleteStatusCodeVM ThisDeleteStatus )
        {
            var deleteStatus = new StatusCode()
            {
                Status = ThisDeleteStatus.Status,
                Descr = ThisDeleteStatus.Descr
            };
            _statusCodesRepo.DeleteStatusCode(deleteStatus);
            return ThisDeleteStatus;
        }

        public EditStatusCodeVM EditStatusCode(EditStatusCodeVM ThisStatus)
        {
            var updateStatus = new StatusCode()
            {
                Status = ThisStatus.Status,
                Descr = ThisStatus.Descr
            };
            _statusCodesRepo.EditStatusCode(updateStatus);
            return ThisStatus;
        }

        public EditStatusCodeVM FindStatusCode(string StatusCode)
        {
            var foundStatus = _statusCodesRepo.FindStatusCode( StatusCode);
            return new EditStatusCodeVM()
            {
                Status = foundStatus.Status,
                Descr = foundStatus.Descr
            };
        }
        public DeleteStatusCodeVM FindDeleteStatusCode(string StatusCode)
        {
            var foundStatus = _statusCodesRepo.FindStatusCode(StatusCode);
            return new DeleteStatusCodeVM()
            {
                Status = foundStatus.Status,
                Descr = foundStatus.Descr
            };
        }

        public List<StatusCodeView> FindStatusCodeList()
        {
            var statusCodeList = _statusCodesRepo.FindStatusCodeList();

            var linqViewList = statusCodeList
                .Select(item => new StatusCodeView
                {
                    Status = item.Status,
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

        public CreateStatusCodeVM InsertStatusCode(CreateStatusCodeVM ThisStatus)
        {
            var insertStatus = new StatusCode()
            {
                Status = ThisStatus.Status,
                Descr = ThisStatus.Descr
            };
            _statusCodesRepo.InsertStatusCode(insertStatus);
            return ThisStatus;
        }

        public CreateStatusCodeVM SaveType(CreateStatusCodeVM entity)
        {
            throw new NotImplementedException();
        }
    }
}
