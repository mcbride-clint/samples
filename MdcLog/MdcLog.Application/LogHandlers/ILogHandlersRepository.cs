using System;
using System.Collections.Generic;
using MdcLog.Domain.Entities;
using System.Text;
using MdcLog.Application.LogHandlers.Models;

namespace MdcLog.Application.LogHandlers
{
    public interface ILogHandlersRepository
    {
        //LogHandler InsertLogHandler(LogHandler entity);
        LogHandler SaveLogHandler(LogHandler entity);
        LogHandlerVM EditLogHandler(LogHandlerVM entity);
        LogHandlerVM FindLogHandler(int Uid);
        IEnumerable<LogHandler> FindLogHandlerList();
        LogHandlerVM InsertLogHandlersType(LogHandlerVM thisLogHandler);

        int DeleteLogHandler(int Uid);
    }
}
