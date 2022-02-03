using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DevExpressControlsTest
{
    public partial class App : Application
    {
        public App()
        {
            DevExpress.XamarinForms.Navigation.Initializer.Init();
            DevExpress.XamarinForms.Editors.Initializer.Init();
            InitializeComponent();

            MainPage = new MainPage();
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
