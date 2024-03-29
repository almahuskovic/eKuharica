﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eKuharica.Mobile.Services;
using eKuharica.Mobile.Views;
using eKuharica.Mobile.Extensions;
using System.Resources;

namespace eKuharica.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
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
