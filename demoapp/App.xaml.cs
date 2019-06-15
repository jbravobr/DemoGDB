using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace demoapp
{
    /// <summary>
    /// 
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// 
        /// </summary>
        public App()
        {
            InitializeComponent();

            AppCenter.Start("android=dc9b4eec-b41d-4b45-9344-bdc090b5189d;" +
                  "ios={Your iOS App secret here}",
                  typeof(Analytics), typeof(Crashes));

#if DEBUG
            HotReloader.Current.Run(this);
#endif

            MainPage = new MainPage();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
