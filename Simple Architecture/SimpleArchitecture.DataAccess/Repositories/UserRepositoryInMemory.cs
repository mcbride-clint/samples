using SimpleArchitecture.Domain.Interfaces;
using SimpleArchitecture.Domain.Interfaces.Repositories;
using SimpleArchitecture.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleArchitecture.DataAccess.Repositories
{
    public class UserRepositoryInMemory : IUserRepository
    {
        private Dictionary<long, IUser> Users { get; }
        public UserRepositoryInMemory()
        {
            Users = new Dictionary<long, IUser>();
            Users.Add(1, new User()
            {
                UserIdSeqNum = 1,
                UserId = "jsmith",
                FullName = "Smith, John",
                Owner = "A",
                Activity = "A",
                Subactivity = "1",
                PhoneNumber = "123-456-7890"
            });
        }

        public IUser Insert(IUser entity)
        {
            entity.UserIdSeqNum = Users.Keys.Max() + 1;
            Users.Add(entity.UserIdSeqNum, entity);
            return entity;
        }

        public IUser Update(IUser entity)
        {
            Users.Remove(entity.UserIdSeqNum);
            Users.Add(entity.UserIdSeqNum, entity);
            return entity;
        }

        public void Delete(IUser entity)
        {
            Users.Remove(entity.UserIdSeqNum);
        }

        public IUser Find(long userSeqNum)
        {
            Users.TryGetValue(userSeqNum, out IUser matchedUser);
            return matchedUser;
        }

        public List<IUser> Find(IUserFilter filter)
        {
            // Change Dictionary to List for easy Linq syntax
            var matchedUsers = Users.Select(u => u.Value);

            if (filter.UserIdSeqNum.HasValue)
            {
                matchedUsers = matchedUsers.Where(u => u.UserIdSeqNum == filter.UserIdSeqNum);
            }
            if (!string.IsNullOrWhiteSpace(filter.UserId))
            {
                matchedUsers = matchedUsers.Where(u => u.UserId.Equals(filter.UserId, StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrWhiteSpace(filter.FullName))
            {
                matchedUsers = matchedUsers.Where(u => u.FullName.Equals(filter.FullName, StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrWhiteSpace(filter.Activity))
            {
                matchedUsers = matchedUsers.Where(u => u.Activity.Equals(filter.Activity, StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrWhiteSpace(filter.Subactivity))
            {
                matchedUsers = matchedUsers.Where(u => u.Subactivity.Equals(filter.Subactivity, StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrWhiteSpace(filter.Owner))
            {
                matchedUsers = matchedUsers.Where(u => u.Owner.Equals(filter.Owner, StringComparison.OrdinalIgnoreCase));
            }

            return matchedUsers.ToList();
        }
    }
}
