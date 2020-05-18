using System;
using System.Collections.Generic;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.ViewModels;

namespace MDCLogArchitecture.Domain.Interfaces.Repositories
{
    public interface ILogHandlersRepository
    {
        //LogHandler InsertLogHandler(LogHandler entity);
        LogHandler SaveLogHandler(LogHandler entity);
        LogHandler EditLogHandler(LogHandler entity);
        LogHandlerVM FindLogHandler(int UserSeqNum);
        IEnumerable<LogHandler> FindLogHandlerList();
        LogHandler DeleteLogHandler(int UserSeqNum);
        LogHandlerVM InsertLogHandlersType(LogHandlerVM thisLogHandler);       
    }
}
