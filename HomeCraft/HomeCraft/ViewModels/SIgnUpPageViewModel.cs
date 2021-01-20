using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeCraft.ViewModels
{
    public class SIgnUpPageViewModel : ViewModelBase
    {
        private DelegateCommand _gotoSignInPageCommand;
        public DelegateCommand GotoSignInPageCommand => _gotoSignInPageCommand ?? (_gotoSignInPageCommand = new DelegateCommand(GotoSignupPage));
        public SIgnUpPageViewModel(INavigationService navigationService) :
            base(navigationService)
        {

        }
        private async void GotoSignupPage()
        {
            await NavigationService.NavigateAsync("SiginInPage");
        }
    }
}
