using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.Filters;
using MDCLogArchitecture.Models.Interfaces.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLogArchitecture.Services
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
        public List<PriorityCode> FindPriorityList(PriorityCodesFilter filter)
        {
            return _PriorityCodeRepo.FindPriorityList(filter);
        }
        public PriorityCode Insert(PriorityCode PriorityCode)
        {
            return _PriorityCodeRepo.InsertPriority(PriorityCode);
        }

        public PriorityCode Find(PriorityCodesFilter filter)
        {
            return _PriorityCodeRepo.FindPriority(filter);
        }

        public PriorityCode Edit(PriorityCode ThisPriorityCode)
        {
            return _PriorityCodeRepo.EditPriority(ThisPriorityCode);
        }
    }
}
