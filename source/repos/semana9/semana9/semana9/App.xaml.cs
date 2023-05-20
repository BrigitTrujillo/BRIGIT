using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using semana9;


namespace semana9
{
    public partial class App : Application
    {
        public static float ScreenHeight { get; private set; }
        public static float ScreenWidth { get; private set; }


        public App()
        {
            InitializeComponent();


            DependencyService.Register<MockDataStore>();
            MainPage= new TapDemo();
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
