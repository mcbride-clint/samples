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
    public class PriorityCodeService
    {
        IPriorityRepository _PriorityCodeRepo;
        ILogger<PriorityCodeService> _logger;
        public PriorityCodeService(ILogger<PriorityCodeService> logger, IPriorityRepository PriorityCodeRepo)
        {
            _logger = logger;
            _PriorityCodeRepo = PriorityCodeRepo;
        }
        public IList<PriorityCode> FindPriorityList()
        {
            _logger.LogError("Hello");
            return _PriorityCodeRepo.FindPriorityList().ToList();
        }

        public PriorityCodeVM FindPriority(int PriorityCode)
        {
            return _PriorityCodeRepo.FindPriority(PriorityCode);
        }

        public PriorityCodeVM GetCreatePriorityCodeVMType()
        {
            return new PriorityCodeVM();
        }

        public PriorityCodeVM InsertPriority(PriorityCodeVM ThisPriorityCode)
        {
            return _PriorityCodeRepo.InsertPriority(ThisPriorityCode);
        }

        public PriorityCodeVM EditPriority(PriorityCodeVM ThisPriorityCode)
        {
            return _PriorityCodeRepo.EditPriority(ThisPriorityCode);
        }

        public int DeletePriority(int Priority)
        {
            int recordsDeleted = _PriorityCodeRepo.DeletePriority(Priority);
            return recordsDeleted;

        }
    }
}
