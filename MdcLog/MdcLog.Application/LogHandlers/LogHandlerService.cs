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
        public List<LogHandlerVM> FindLogHandlerList()
        {
            return _LogHandlersRepo.FindLogHandlerList().ToList();
        }
        public LogHandlerVM FindLogHandler(int Uid)
        {
            return _LogHandlersRepo.FindLogHandler(Uid);
        }

        public CreateLogHandlerVM CreateNewLogHandlerVM()
        {
            return new CreateLogHandlerVM();
        }

        public CreateLogHandlerVM InsertLogHandler(CreateLogHandlerVM ThisLogHandler)
        {
            var insertLogHandler = new LogHandlerVM()
            {
                UserSeqNum = ThisLogHandler.UserSeqNum,
                Code = ThisLogHandler.Code,
                Tmma = ThisLogHandler.Tmma
            };
            _LogHandlersRepo.InsertLogHandler(insertLogHandler);
            return ThisLogHandler;
        }       

        //public CreateLogHandlerVM EditLogHandler(CreateLogHandlerVM ThisLogHandler)
        //{
        //    return _LogHandlersRepo.EditLogHandler(ThisLogHandler);
        //}

        public CreateLogHandlerVM GetCreateLogHandlerVMType()
        {
            return new CreateLogHandlerVM();
        }
       
        public DeleteLogHandlerVM FindDeleteLogHandler(int Uid)
        {
            var foundLogHandler = _LogHandlersRepo.FindLogHandler(Uid);

            return new DeleteLogHandlerVM()
            {
                Uid = foundLogHandler.Uid,
                UserSeqNum = foundLogHandler.UserSeqNum,
                Code = foundLogHandler.Code,
                Tmma = foundLogHandler.Tmma
            };
        }

        public DeleteLogHandlerVM DeleteLogHandler(DeleteLogHandlerVM ThisLogHandler)
        {
            var deleteLogHandler = new LogHandlerVM()
            {
                Uid = ThisLogHandler.Uid,
                UserSeqNum = ThisLogHandler.UserSeqNum,
                Code = ThisLogHandler.Code,
                Tmma = ThisLogHandler.Tmma
            };
            _LogHandlersRepo.DeleteLogHandler(deleteLogHandler);
            return ThisLogHandler;
        }


    }
}
