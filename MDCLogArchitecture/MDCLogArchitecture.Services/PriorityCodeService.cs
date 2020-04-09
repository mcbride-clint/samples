using MDCLogArchitecture.Models.DomainModels;
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

        public List<PriorityCode> FindPriorityList()
        {
            return _PriorityCodeRepo.FindPriorityList();
        }
    }
}
