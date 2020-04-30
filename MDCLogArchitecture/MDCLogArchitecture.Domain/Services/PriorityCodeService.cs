using MDCLogArchitecture.Domain.Interfaces.Repositories;
using MDCLogArchitecture.Models.DomainModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
        public List<PriorityCode> FindPriorityList()
        {
            return _PriorityCodeRepo.FindPriorityList().ToList();
        }
        public PriorityCode Insert(PriorityCode PriorityCode)
        {
            return _PriorityCodeRepo.InsertPriority(PriorityCode);
        }

        public PriorityCode Find(string PriorityCode)
        {
            return _PriorityCodeRepo.FindPriority(PriorityCode);
        }

        public PriorityCode Edit(PriorityCode ThisPriorityCode)
        {
            return _PriorityCodeRepo.EditPriority(ThisPriorityCode);
        }
    }
}
