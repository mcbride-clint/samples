using Microsoft.AspNetCore.Components;
using Radzen;
using SimpleArchitecture.Blazor.Extensions;
using SimpleArchitecture.Blazor.ViewModel;
using SimpleArchitecture.Services;

namespace SimpleArchitecture.Blazor.Pages.Users2
{
    public class ViewBase : ComponentBase
    {
        [Inject] UserService UserService { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }
        [Inject] NotificationService NotificationService { get; set; }

        [Parameter] public int UserIdSeqNum { get; set; }


        public UserVM User;

        public bool IsReadonly { get; set; }

        protected override void OnInitialized()
        {
            IsReadonly = true;
            User = UserService.Find(UserIdSeqNum).ToViewModel();
        }

        protected void ToggleEdit()
        {
            IsReadonly = !IsReadonly;
        }

        protected void Submit()
        {
            UserService.Save(User.ToDomainModel());
            NotificationService.Notify(NotificationSeverity.Success, $"{User.UserId} Saved Successfully", duration: 3000);
            RefreshPage();
        }

        protected void RefreshPage()
        {
            OnInitialized();
            this.StateHasChanged();
        }
    }
}
