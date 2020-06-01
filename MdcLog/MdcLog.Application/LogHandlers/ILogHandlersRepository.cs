using System;
using System.Collections.Generic;
using MdcLog.Domain.Entities;
using System.Text;
using MdcLog.Application.LogHandlers.Models;

namespace MdcLog.Application.LogHandlers
{
    public interface ILogHandlersRepository
    {
        LogHandlerVM InsertLogHandler(LogHandlerVM entity);
        LogHandlerVM SaveLogHandler(LogHandlerVM entity);
        LogHandlerVM EditLogHandler(int Uid);
        LogHandlerVM FindLogHandler(int Uid);
        IEnumerable<LogHandlerVM> FindLogHandlerList();
        LogHandlerVM DeleteLogHandler(LogHandlerVM entity);
    }
}
