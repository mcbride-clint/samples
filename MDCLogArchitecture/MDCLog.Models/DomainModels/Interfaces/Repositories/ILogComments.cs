using MDCLogArchitecture.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLogArchitecture.Models.DomainModels.Interfaces.Repositories
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
