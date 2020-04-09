using SimpleArchitecture.Blazor.ViewModel;
using SimpleArchitecture.Domain.Interfaces;
using SimpleArchitecture.Models.DomainModels;
using System.Collections.Generic;
using System.Linq;

namespace SimpleArchitecture.Blazor.Extensions
{
    public static class UserExtensions
    {
        public static UserVM ToViewModel(this IUser user)
        {
            return new UserVM()
            {
                Activity = user.Activity,
                FullName = user.FullName,
                Owner = user.Owner,
                PhoneNumber = user.PhoneNumber,
                Subactivity = user.Subactivity,
                UserId = user.UserId,
                UserIdSeqNum = user.UserIdSeqNum
            };
        }

        public static User ToDomainModel(this UserVM userVM)
        {
            return new User()
            {
                Activity = userVM.Activity,
                FullName = userVM.FullName,
                Owner = userVM.Owner,
                PhoneNumber = userVM.PhoneNumber,
                Subactivity = userVM.Subactivity,
                UserId = userVM.UserId,
                UserIdSeqNum = userVM.UserIdSeqNum
            };
        }


        public static IEnumerable<UserVM> ToViewModel(this IEnumerable<IUser> users)
        {
            return users.Select(u => u.ToViewModel());
        }
    }
}
