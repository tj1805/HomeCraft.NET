using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeCraft.ViewModels
{
    public class ForgetPasswordPageViewModel : ViewModelBase
    {
        private DelegateCommand _goBackCommand;
        public DelegateCommand GoBackCommand => _goBackCommand ?? (_goBackCommand = new DelegateCommand(GoBack));

        public ForgetPasswordPageViewModel( INavigationService navigationService) :
            base(navigationService)

        {

        }
        private async void GoBack()
        {
            await NavigationService.GoBackAsync();
        }
    }
}
