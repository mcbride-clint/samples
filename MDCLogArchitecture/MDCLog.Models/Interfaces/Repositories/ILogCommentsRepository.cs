using System;
using System.Collections.Generic;
using System.Text;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.Filters;

namespace MDCLogArchitecture.Models.Interfaces.Repositories
{
    public interface ILogCommentsRepository
    {
      
            LogComments Insert(LogComments entity);

            void Delete(LogComments entity);
            LogComments Find(int SeqNum);
            List<LogComments> Find(LogCommentsFilter filter);
      
    }
}
