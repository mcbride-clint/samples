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
            var logHandlerList = _LogHandlersRepo.FindLogHandlerList();

            var newLogHandlerList = logHandlerList
                .Select(item => new LogHandlerVM()
                {
                    Uid = item.Uid,
                    UserSeqNum = item.UserSeqNum,
                    Code = item.Code,
                    Tmma = item.Tmma
                })
                .ToList();


            return newLogHandlerList;
        }

        //public LogHandler FindLogHandler(int Uid)
        //{
        //    return _LogHandlersRepo.FindLogHandler(Uid);
        //}

        public CreateLoghandlerVM CreateNewLogHandlerVM()
        {
            return new CreateLoghandlerVM();
        }

        public CreateLoghandlerVM InsertLogHandler(CreateLoghandlerVM ThisLogHandler)
        {
            var insertLogHandler = new LogHandler()
            {
                UserSeqNum = ThisLogHandler.UserSeqNum,
                Code = ThisLogHandler.Code,
                Tmma = ThisLogHandler.Tmma
            };
            _LogHandlersRepo.InsertLogHandler(insertLogHandler);
            return ThisLogHandler;
        }

        public EditLogHandlerVM FindLogHandler(int Uid)
        {
            var foundLogHandler = _LogHandlersRepo.FindLogHandler(Uid);

            return new EditLogHandlerVM()
            {
                Uid = foundLogHandler.Uid,
                UserSeqNum = foundLogHandler.UserSeqNum,
                Code = foundLogHandler.Code,
                Tmma = foundLogHandler.Tmma
            };
        }

        public EditLogHandlerVM EditLogHandler(EditLogHandlerVM ThisLogHandler)
        {
            var editLogHandler = new LogHandler()
            {
                Uid = ThisLogHandler.Uid,
                UserSeqNum = ThisLogHandler.UserSeqNum,
                Code = ThisLogHandler.Code,
                Tmma = ThisLogHandler.Tmma
            };
            _LogHandlersRepo.EditLogHandler(editLogHandler);
            return ThisLogHandler;
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
            var deleteLogHandler = new LogHandler()
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
