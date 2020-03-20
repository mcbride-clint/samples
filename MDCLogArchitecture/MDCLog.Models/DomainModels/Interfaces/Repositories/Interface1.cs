using MDCLog.Models.DomainModels.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLog.Models.DomainModels.Interfaces.Repositories
{
    interface ILogComments
    {
        LogComments Insert(LogComments entity);
        LogComments Update(LogComments entity);
        void Delete(LogComments entity);
        LogComments Find(int LogNumber);
        List<LogComments> Find(LogComments filter);

    }
}
