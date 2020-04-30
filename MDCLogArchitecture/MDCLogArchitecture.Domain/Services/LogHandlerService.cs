using System;
using System.Collections.Generic;
using System.Text;
using MDCLogArchitecture.Domain.Interfaces.Repositories;
using MDCLogArchitecture.Models.DomainModels;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace MDCLogArchitecture.Domain.Services
{
    public class LogHandlerService
    {
        ILogHandlersRepository _LogHandlersRepo;
        ILogger<LogHandlerService> _logger;
        public LogHandlerService(ILogger<LogHandlerService> logger, ILogHandlersRepository LogHandlersRepo)
        {
            _logger = logger;
            _LogHandlersRepo = LogHandlersRepo;
        }
        public List<LogHandler> FindLogHandlerList()
        {
            return _LogHandlersRepo.FindLogHandlerList().ToList();
        }
        public LogHandler Insert(LogHandler LogHandler)
        {
            return _LogHandlersRepo.InsertLogHandler(LogHandler);
        }

        public LogHandler FindLogHandler(int UserSeqNum)
        {
            return _LogHandlersRepo.FindLogHandler(UserSeqNum);
        }

        public LogHandler EditLogHandler(LogHandler ThisLogHandler)
        {
            return _LogHandlersRepo.EditLogHandler(ThisLogHandler);
        }
    }
}
