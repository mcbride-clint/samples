using SimpleArchitecture.Models.DomainModels;
using SimpleArchitecture.Models.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleArchitecture.Models.Interfaces.Repositories
{
    public interface IUserRepository
    {
        User Insert(User entity);
        User Update(User entity);
        void Delete(User entity);
        User Find(long userSeqNum);
        List<User> Find(UserFilter filter);
    }
}
