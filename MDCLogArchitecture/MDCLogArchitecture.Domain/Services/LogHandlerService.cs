using System;
using System.Collections.Generic;
using System.Text;
using MDCLogArchitecture.Domain.Interfaces.Repositories;
using MDCLogArchitecture.Models.DomainModels;
using Microsoft.Extensions.Logging;
using System.Linq;
using MDCLogArchitecture.Models.ViewModels;

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
        public LogHandlerVM Insert(LogHandlerVM ThisLogHandler)
        {
            return _LogHandlersRepo.InsertLogHandlersType(ThisLogHandler);
        }

        public LogHandlerVM FindLogHandler(int UserSeqNum)
        {
            return _LogHandlersRepo.FindLogHandler(UserSeqNum);
        }

        public LogHandler EditLogHandler(LogHandler ThisLogHandler)
        {
            return _LogHandlersRepo.EditLogHandler(ThisLogHandler);
        }

        public LogHandlerVM GetCreateLogHandlerVMType()
        {
            return new LogHandlerVM();
        }
        public void DeleteLogHandler(int UserSeqNum)
        {
            _LogHandlersRepo.DeleteLogHandler(UserSeqNum);
        }
    }
}
