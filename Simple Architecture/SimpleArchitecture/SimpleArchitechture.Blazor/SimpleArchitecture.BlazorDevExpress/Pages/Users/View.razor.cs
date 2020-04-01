using Microsoft.AspNetCore.Components;
using SimpleArchitecture.BlazorDevExpress.Extensions;
using SimpleArchitecture.BlazorDevExpress.ViewModel;
using SimpleArchitecture.Services;

namespace SimpleArchitecture.BlazorDevExpress.Pages.Users
{
    public class ViewBase : ComponentBase
    {
        [Inject] UserService UserService { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }

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
            //Toaster.Add($"{User.UserId} Saved Successfully", MatToastType.Success, icon: "edit");
            RefreshPage();
        }

        protected void RefreshPage()
        {
            OnInitialized();
            this.StateHasChanged();
        }
    }
}
