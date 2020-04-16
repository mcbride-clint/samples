using MDCLogArchitecture.Domain.Interfaces.Repositories;
using MDCLogArchitecture.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
        public List<IPriorityCode> FindPriorityList(IPriorityCodesFilter filter)
        {
            return _PriorityCodeRepo.FindPriorityList(filter).ToList();
        }
        public IPriorityCode Insert(IPriorityCode PriorityCode)
        {
            return _PriorityCodeRepo.InsertPriority(PriorityCode);
        }

        public IPriorityCode Find(IPriorityCodesFilter filter)
        {
            return _PriorityCodeRepo.FindPriority(filter);
        }

        public IPriorityCode Edit(IPriorityCode ThisPriorityCode)
        {
            return _PriorityCodeRepo.EditPriority(ThisPriorityCode);
        }
    }
}
