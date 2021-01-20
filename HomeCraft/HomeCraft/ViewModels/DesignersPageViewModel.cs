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
    public class DesignersPageViewModel : ViewModelBase
    {
        private DelegateCommand _shellFlyoutCommmand;
        public DelegateCommand ShellFlyoutCommmand => _shellFlyoutCommmand ?? (_shellFlyoutCommmand = new DelegateCommand(Flyout));

        public ObservableCollection<Designer> Designers { get => GetDesigners(); } 
        public DesignersPageViewModel(INavigationService navigationService) :
            base(navigationService)
        {

        }
       
        void Flyout()
        {
            Shell.Current.FlyoutIsPresented = true;
        }

        private ObservableCollection<Designer> GetDesigners()
{
            var designerList = new ObservableCollection<Designer>()
            {
                new Designer
                {
                    Name = "Jame Iron",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum dui vitae maximus ultrices consectetur adipiscing",
                    Country = "Nigeria",
                    state = "Lagos",
                    Image = "profilefive.jpg"
                },
                new Designer
                {
                    Name = "West Johns",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum dui vitae maximus ultrices consectetur adipiscing",
                    Country = "Nigeria",
                    state = "Ogun",
                    Image = "profilepic.jpg",
                },
                new Designer
                {
                    Name = "Isaac East",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum dui vitae maximus ultrices consectetur adipiscing",
                    Country = "Nigeria",
                    state = "Osun",
                    Image = "profilesix.jpg"
                },
                new Designer
                {
                    Name = "West Light",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum dui vitae maximus ultrices consectetur adipiscing",
                    Country = "Nigeria",
                    state = "Oyo",
                    Image = "profilonee.jpg"
                },
                new Designer
                {
                    Name = "Jame Iron",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum dui vitae maximus ultrices consectetur adipiscing",
                    Country = "Nigeria",
                    state = "Lagos",
                    Image = "profilefour.jpg"
                },
                new Designer
                {
                    Name = "Jame Light",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum dui vitae maximus ultrices consectetur adipiscing",
                    Country = "Nigeria",
                    state = "Lagos",
                    Image = "progiletwo.jpg",
                },
                new Designer
                {
                    Name = "Jame Iron",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum dui vitae maximus ultrices consectetur adipiscing",
                    Country = "Nigeria",
                    state = "Lagos",
                    Image = "profilethree.jpg"
                },
                 new Designer
                {
                    Name = "Jame Iron",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum dui vitae maximus ultrices consectetur adipiscing",
                    Country = "Nigeria",
                    state = "Lagos",
                    Image = "profileseven.jpg"
                },
                new Designer
                {
                    Name = "Jame Iron",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque condimentum dui vitae maximus ultrices consectetur adipiscing",
                    Country = "Nigeria",
                    state = "ogun",
                    Image = "profileeight.jpg"
                }
            };
            return designerList;
        }
       

    }
}
