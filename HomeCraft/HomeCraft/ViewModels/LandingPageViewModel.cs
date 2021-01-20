using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeCraft.ViewModels
{
    public class LandingPageViewModel : ViewModelBase
    {
        public LandingPageViewModel(INavigationService navigationService) :
            base(navigationService)
        {

        }
        private DelegateCommand _startShoppingCommand;
        public DelegateCommand StartShoppingCommand => _startShoppingCommand ?? (_startShoppingCommand = new DelegateCommand(StartShoppingClick));

        private async void StartShoppingClick()
        {
            await NavigationService.NavigateAsync("SiginInPage");
        }

    }
}
