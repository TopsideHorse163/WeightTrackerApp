using System;
using WeightTracker.Services;
using WeightTracker.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeightTracker
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
