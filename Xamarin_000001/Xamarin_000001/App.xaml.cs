using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_000001.Vues;

namespace Xamarin_000001
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TourneeVue();
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
