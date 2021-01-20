using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Essentials;

namespace HomeCraft.ViewModels
{
    public class PrismShellPageViewModel : ViewModelBase
    {
        public PrismShellPageViewModel(INavigationService navigationService) :
            base(navigationService)
        {

        }
        private DelegateCommand _logOutCommand;
        public DelegateCommand LogOutCommand => _logOutCommand ?? (_logOutCommand = new DelegateCommand(LogOut));

        private DelegateCommand _callUsCommand;
        public DelegateCommand CallUsCommand => _callUsCommand ?? (_callUsCommand = new DelegateCommand(CallUs));


        async void LogOut()
        {
            await NavigationService.NavigateAsync("/LandingPage");
        }

         void CallUs()
        {
           PhoneDialer.Open("08120759252");
        }


    }
}
