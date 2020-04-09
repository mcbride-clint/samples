using System.Collections.Generic;

namespace SimpleArchitecture.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        IUser Insert(IUser entity);
        IUser Update(IUser entity);
        void Delete(IUser entity);
        IUser Find(long userSeqNum);
        List<IUser> Find(IUserFilter filter);
    }
}
