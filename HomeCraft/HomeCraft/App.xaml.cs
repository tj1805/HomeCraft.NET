using System;
using HomeCraft.ViewModels;
using HomeCraft.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: ExportFont("Lemonada-Bold.ttf", Alias = "BoldFont")]
[assembly: ExportFont("Lemonada-SemiBold.ttf", Alias = "SemiBoldFont")]
[assembly: ExportFont("Lemonada-Medium.ttf", Alias = "MediumFont")]
[assembly: ExportFont("Lemonada-Regular.ttf", Alias = "RegularFont")]
[assembly: ExportFont("materialdesignicons-webfont.ttf", Alias ="IconFont" )]
namespace HomeCraft
{

    //public partial class App : Application
    //{
    //    public App()
    //    {
    //        InitializeComponent();
    //        XF.Material.Forms.Material.Init(this);

    //        MainPage = new MainPage();
    //    }

    //    protected override void OnStart()
    //    {
    //    }

    //    protected override void OnSleep()
    //    {
    //    }

    //    protected override void OnResume()
    //    {
    //    }
    //}

    public partial class App
    {
        public App() : this(null)
        {

        }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            XF.Material.Forms.Material.Init(this);
            await NavigationService.NavigateAsync("NavigationPage/LandingPage");
            //await NavigationService.NavigateAsync("LandingPage");

            //Snack bar configuration

        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
          // containerRegistry.RegisterForNavigation<LandingPage, LandingPageViewModel>();
            containerRegistry.RegisterForNavigation<ShellPage>();
            containerRegistry.RegisterForNavigation<LandingPage, LandingPageViewModel>();
            containerRegistry.RegisterForNavigation<SIgnUpPage, SIgnUpPageViewModel>();
            containerRegistry.RegisterForNavigation<SiginInPage, SiginInPageViewModel>();
            containerRegistry.RegisterForNavigation<ForgetPasswordPage, ForgetPasswordPageViewModel>();
            containerRegistry.RegisterForNavigation<FurniturePage, FurniturePageViewModel>();
            containerRegistry.RegisterForNavigation<DesignersPage, DesignersPageViewModel>();
            containerRegistry.RegisterForNavigation<BlogPage, BlogPageViewModel>();
            containerRegistry.RegisterForNavigation<ProfilePage, ProfilePageViewModel>();
            containerRegistry.RegisterForNavigation<PrismShellPage, PrismShellPageViewModel>();
        }

        protected override void OnStart()
        {
            base.OnResume();
        }

        protected override void OnSleep()
        {
            base.OnSleep();
        }

        protected override void OnResume()
        {
            base.OnResume();
        }
    }
}
