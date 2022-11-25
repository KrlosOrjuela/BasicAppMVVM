using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApp
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            var AppNavidation = new NavigationPage(new Views.LoginPage());
            AppNavidation.BarBackgroundColor = (Color) App.Current.Resources["BarBackgroundColor"];
            AppNavidation.BarTextColor = Color.White; /// para ios es necesario configurar en el info.plis Status bar style y View controller-based status bar appearance
            MainPage = AppNavidation;
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

