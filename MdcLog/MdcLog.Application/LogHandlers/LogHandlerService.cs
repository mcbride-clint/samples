using MdcLog.Application.LogHandlers.Models;
using MdcLog.Application.LogHandlers;
using MdcLog.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MdcLog.Application.LogHandlers
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

        public LogHandlerVM FindLogHandler(int Uid)
        {
            return _LogHandlersRepo.FindLogHandler(Uid);
        }

        public LogHandlerVM EditLogHandler(LogHandlerVM ThisLogHandler)
        {
            return _LogHandlersRepo.EditLogHandler(ThisLogHandler);
        }

        public LogHandlerVM GetCreateLogHandlerVMType()
        {
            return new LogHandlerVM();
        }
        public int DeleteLogHandler(int Uid)
        {
            int recordsDeleted = _LogHandlersRepo.DeleteLogHandler(Uid);
            return recordsDeleted;

        }
    }
}
