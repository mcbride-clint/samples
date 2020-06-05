using MdcLog.Application.Priorties.Models;
using MdcLog.Application.Priorties;
using MdcLog.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MdcLog.Application.Priorties
{
    public class PriorityCodeService
    {
        IPriorityRepository _PriorityCodeRepo;
        ILogger<PriorityCodeService> _logger;
        public PriorityCodeService(ILogger<PriorityCodeService> logger, IPriorityRepository PriorityCodeRepo)
        {
            _logger = logger;
            _PriorityCodeRepo = PriorityCodeRepo;
        }

        public List<PriorityCodeVM> FindPriorityCodeList()
        {
            var PriorityCodeList = _PriorityCodeRepo.FindPriorityCodeList();

            var newPriorityCodeList = PriorityCodeList
                .Select(item => new PriorityCodeVM()
                {
                    Priority = item.Priority,
                    Descr = item.Descr

                })
                .ToList();


            return newPriorityCodeList;
        }

        public CreatePriorityCodeVM CreateNewPriorityCodeVM()
        {
            return new CreatePriorityCodeVM();
        }

        public CreatePriorityCodeVM InsertPriorityCode(CreatePriorityCodeVM ThisPriorityCode)
        {
            var insertPriorityCode = new PriorityCode()
            {
                Priority = ThisPriorityCode.Priority,
                Descr = ThisPriorityCode.Descr
            };
            _PriorityCodeRepo.InsertPriorityCode(insertPriorityCode);
            return ThisPriorityCode;
        }

        public EditPriorityCodeVM FindPriorityCode(int Priority)
        {
            var foundPriorityCode = _PriorityCodeRepo.FindPriorityCode(Priority);

            return new EditPriorityCodeVM()
            {
                Priority = foundPriorityCode.Priority,
                Descr = foundPriorityCode.Descr
            };
        }

        public EditPriorityCodeVM EditPriorityCode(EditPriorityCodeVM ThisPriorityCode)
        {
            var editPriorityCode = new PriorityCode()
            {
                Priority = ThisPriorityCode.Priority,
                Descr = ThisPriorityCode.Descr
            };
            _PriorityCodeRepo.EditPriorityCode(editPriorityCode);
            return ThisPriorityCode;
        }


        public DeletePriorityCodeVM FindDeletePriorityCode(int Priority)
        {
            var foundPriorityCode = _PriorityCodeRepo.FindPriorityCode(Priority);

            return new DeletePriorityCodeVM()
            {
                Priority = foundPriorityCode.Priority,
                Descr = foundPriorityCode.Descr
            };
        }

        public DeletePriorityCodeVM DeletePriorityCode(DeletePriorityCodeVM ThisPriorityCode)
        {
            var deletePriorityCode = new PriorityCode()
            {
                Priority = ThisPriorityCode.Priority,
                Descr = ThisPriorityCode.Descr
            };
            _PriorityCodeRepo.DeletePriorityCode(deletePriorityCode);
            return ThisPriorityCode;
        }

    }

}
