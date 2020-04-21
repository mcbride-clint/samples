using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLogArchitecture.Domain.Interfaces.Repositories
{
    public interface ILogHandlersRepository
    {
        ILogHandler InsertLogHandler(ILogHandler entity);
        ILogHandler SaveLogHandler(ILogHandler entity);
        ILogHandler EditLogHandler(ILogHandler entity);
        ILogHandler FindLogHandler(int UserSeqNum);
        IEnumerable<ILogHandler> FindLogHandlerList();
        ILogHandler DeleteLogHandler(int UserSeqNum);
    }
}
