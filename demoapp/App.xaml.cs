﻿using Xamarin.Forms;

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
