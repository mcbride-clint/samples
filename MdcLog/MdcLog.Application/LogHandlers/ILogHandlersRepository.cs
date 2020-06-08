using System;
using System.Collections.Generic;
using MdcLog.Domain.Entities;
using System.Text;
using MdcLog.Application.LogHandlers.Models;

namespace MdcLog.Application.LogHandlers
{
    public interface ILogHandlersRepository
    {
        LogHandler InsertLogHandler(LogHandler entity);
        LogHandler SaveLogHandler(LogHandler entity);
        LogHandler EditLogHandler(LogHandler entity);
        LogHandler FindLogHandler(int Uid);
        IEnumerable<LogHandlerVM> FindLogHandlerList();
        LogHandler DeleteLogHandler(LogHandler entity);
    }
}
