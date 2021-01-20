using HomeCraft.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace HomeCraft.ViewModels
{
    public class BlogPageViewModel : ViewModelBase
    {
        public BlogPageViewModel(INavigationService navigationService) :
            base(navigationService)
        {

        }
        private DelegateCommand _shellFlyoutCommmand;
        public DelegateCommand ShellFlyoutCommmand => _shellFlyoutCommmand ?? (_shellFlyoutCommmand = new DelegateCommand(Flyout));

        public ObservableCollection<DesignStyles> DesignStyless { get => GetStyles(); }

        void Flyout()
        {
            Shell.Current.FlyoutIsPresented = true;
        }

        private ObservableCollection<DesignStyles> GetStyles()
        {
            var styleList = new ObservableCollection<DesignStyles>()
            {
                new DesignStyles
                {
                    Name="Han jou",
                    Place="Germany",
                    Image="background.jpg"
                },
                new DesignStyles
                {
                    Name="Han jou",
                    Place="Germany",
                    Image="backgroundtwo.jpg"
                },
                new DesignStyles
                {
                    Name="Han jou",
                    Place="Germany",
                    Image="backgroundthree.jpg"
                },
                 new DesignStyles
                {
                    Name="Han jou",
                    Place="Germany",
                    Image="backgroundfour.jpg"
                },
                new DesignStyles
                {
                    Name="Han jou",
                    Place="Germany",
                    Image="backgroundfive.jpg"
                },
                 new DesignStyles
                {
                    Name="Han jou",
                    Place="Germany",
                    Image="backgroundsix.jpg"
                },
                new DesignStyles
                {
                    Name="Han jou",
                    Place="Germany",
                    Image="backgroundseven.jpg"
                },
                 new DesignStyles
                {
                    Name="Han jou",
                    Place="Germany",
                    Image="backgroundeight.jpg"
                }

            };

            return styleList;
        }
    }
}

