﻿using eKuharica.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKuharica.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileSettingsPage : ContentPage
    {
        private ProfileSettingsViewModel model = null;
        public ProfileSettingsPage()
        {
            InitializeComponent();
            BindingContext = model = new ProfileSettingsViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}