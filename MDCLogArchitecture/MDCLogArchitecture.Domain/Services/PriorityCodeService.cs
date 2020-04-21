using MDCLogArchitecture.Domain.Interfaces.Repositories;
using MDCLogArchitecture.Domain.Interfaces;
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
        public List<IPriorityCode> FindPriorityList()
        {
            return _PriorityCodeRepo.FindPriorityList().ToList();
        }
        public IPriorityCode Insert(IPriorityCode PriorityCode)
        {
            return _PriorityCodeRepo.InsertPriority(PriorityCode);
        }

        public IPriorityCode Find(string PriorityCode)
        {
            return _PriorityCodeRepo.FindPriority(PriorityCode);
        }

        public IPriorityCode Edit(IPriorityCode ThisPriorityCode)
        {
            return _PriorityCodeRepo.EditPriority(ThisPriorityCode);
        }
    }
}
