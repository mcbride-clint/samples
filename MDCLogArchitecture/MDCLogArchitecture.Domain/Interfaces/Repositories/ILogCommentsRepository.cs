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
        ILogCommentsRepository Insert(ILogCommentsRepository entity);
        ILogCommentsRepository Save(ILogCommentsRepository entity);

        ILogCommentsRepository Find(int SeqNum);
        List<ILogCommentsRepository> FindList(LogCommentsFilter filter);

    }

    public class LogCommentsFilter
    {
    }
}
