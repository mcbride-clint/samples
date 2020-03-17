using SimpleArchitecture.Models.DomainModels;
using SimpleArchitecture.Models.Filters;
using SimpleArchitecture.Models.Interfaces.Repositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SimpleArchitecture.DataAccess.Repositories
{
    public class UserRepositoryInMemory : IUserRepository
    {
        private Dictionary<long, User> Users { get; }
        public UserRepositoryInMemory()
        {
            Users = new Dictionary<long, User>();
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

        public User Insert(User entity)
        {
            entity.UserIdSeqNum = Users.Keys.Max() + 1;
            Users.Add(entity.UserIdSeqNum, entity);
            return entity;
        }

        public User Update(User entity)
        {
            Users.Remove(entity.UserIdSeqNum);
            Users.Add(entity.UserIdSeqNum, entity);
            return entity;
        }

        public void Delete(User entity)
        {
            Users.Remove(entity.UserIdSeqNum);
        }

        public User Find(long userSeqNum)
        {
            Users.TryGetValue(userSeqNum, out User matchedUser);
            return matchedUser;
        }

        public List<User> Find(UserFilter filter)
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
