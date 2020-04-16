using System.Collections;
using System.Collections.Generic;

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
        ILogComments Insert(ILogComments entity);
        //ILogComments Save(ILogComments entity);

        ILogComments Find(int SeqNum);
        IEnumerable <ILogComments> FindList(int LogNumber);

    }

    
}
