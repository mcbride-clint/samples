using System.Collections;
using System.Collections.Generic;
using MDCLogArchitecture.Models.DomainModels;

namespace MDCLogArchitecture.Domain.Interfaces.Repositories
{
    public interface ILogCommentsRepository
    {
        /// <summary>
        /// Comments can only be inserted and viewed - because they are a history of what transpired from
        /// the logs birth to completion
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        LogComment Insert(LogComment entity);
        //LogComments Save(LogComments entity);

        LogComment Find(int SeqNum);
        IEnumerable <LogComment> FindList(int LogNumber);

    }

    
}
