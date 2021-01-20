using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeCraft.ViewModels
{
    public class SiginInPageViewModel : ViewModelBase
    {
        private DelegateCommand _gotoSignupPageCommand;
        public DelegateCommand GotoSignupPageCommand => _gotoSignupPageCommand ?? (_gotoSignupPageCommand = new DelegateCommand(GotoSignupPage));
     
        private DelegateCommand _fogetClickCommand;
        public DelegateCommand FogetClickCommand => _fogetClickCommand ?? (_fogetClickCommand = new DelegateCommand(FogetClick));

         private DelegateCommand _signinCOmmand;
        public DelegateCommand SigninCOmmand => _signinCOmmand ?? (_signinCOmmand = new DelegateCommand(SignIn));
        
        
        

        public SiginInPageViewModel(INavigationService navigationService) :
            base(navigationService)
        {

        }


        private async void GotoSignupPage()
        {
           await NavigationService.NavigateAsync("SIgnUpPage");
        }
        private async void FogetClick()
        {
            await NavigationService.NavigateAsync("ForgetPasswordPage");
        }
         private async void SignIn()
        {
         //   await NavigationService.NavigateAsync("/ShellPage");
            await NavigationService.NavigateAsync("/PrismShellPage");
        }


    }
}
