using Expensometer.Core.Views;
using Expensometer.Core.Views.Phone;
using Expensometer.Core.Views.Tablet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Expensometer.Core
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            if (Xamarin.Forms.Device.Idiom == Xamarin.Forms.TargetIdiom.Phone)
            {
                Debug.WriteLine("Phone");
                MainPage = new MainPagePhone();
            }
            else
            {
                MainPage = new MainPageTablet();
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
