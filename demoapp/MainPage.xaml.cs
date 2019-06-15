using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace demoapp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// 
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void Login_Click(object sender, EventArgs eventArgs)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
                Crashes.TrackError(ex,
                    new Dictionary<string, string>
                {
                    {"Login", "ClicarBotaoLogin"}
                });
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            try
            {
                Analytics.TrackEvent("ESQUECI-MINHA-SENHA",
                    new Dictionary<string, string>
                    {
                        {"Evento", "EsqueciMinhaSenha" }
                    });
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
                Crashes.TrackError(ex,
                    new Dictionary<string, string>
                {
                    {"EsqueciMinhaSenha", "ClicarLabelEsqueciMinhaSenha"}
                });
            }
        }
    }
}