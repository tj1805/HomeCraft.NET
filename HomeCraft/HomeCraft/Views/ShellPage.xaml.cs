using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeCraft.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShellPage : Shell 
    {
        protected INavigationService NavigationService { get; private set; }

        public ShellPage(INavigationService navigationService)
        {
            NavigationService = navigationService;
            InitializeComponent();
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            await NavigationService.NavigateAsync("/LandingPage");
        }
    }
}