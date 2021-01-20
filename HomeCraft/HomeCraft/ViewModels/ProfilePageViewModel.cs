using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace HomeCraft.ViewModels
{
    public class ProfilePageViewModel : ViewModelBase
    {
        public ProfilePageViewModel(INavigationService navigationService) :
            base(navigationService)
        {
            
        }
        private DelegateCommand _shellFlyoutCommmand;
        public DelegateCommand ShellFlyoutCommmand => _shellFlyoutCommmand ?? (_shellFlyoutCommmand = new DelegateCommand(Flyout));


        void Flyout()
        {
             Shell.Current.FlyoutIsPresented = true;
        }
    }
}
