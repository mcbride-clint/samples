using System;
using System.Collections.Generic;
using System.Text;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.Filters;

namespace MDCLogArchitecture.Models.Interfaces.Repositories
{
    public interface ILogCommentsRepository
    {
        /// <summary>
        /// Comments can only be inserted and viewed - because they are a history of what transpired from
        /// the logs birth to completion
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        LogComments Insert(LogComments entity);
        LogComments Save(LogComments entity);

        LogComments Find(int SeqNum);
        List<LogComments> FindList(LogCommentsFilter filter);

    }
}
