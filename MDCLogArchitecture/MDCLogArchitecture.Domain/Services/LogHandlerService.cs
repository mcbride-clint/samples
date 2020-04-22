using System;
using System.Collections.Generic;
using System.Text;
using MDCLogArchitecture.Domain.Interfaces.Repositories;
using MDCLogArchitecture.Domain.Interfaces;
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
        public List<ILogHandler> FindLogHandlerList()
        {
            return _LogHandlersRepo.FindLogHandlerList().ToList();
        }
        public ILogHandler Insert(ILogHandler LogHandler)
        {
            return _LogHandlersRepo.InsertLogHandler(LogHandler);
        }

        public ILogHandler FindLogHandler(int UserSeqNum)
        {
            return _LogHandlersRepo.FindLogHandler(UserSeqNum);
        }

        public ILogHandler EditLogHandler(ILogHandler ThisLogHandler)
        {
            return _LogHandlersRepo.EditLogHandler(ThisLogHandler);
        }
    }
}
