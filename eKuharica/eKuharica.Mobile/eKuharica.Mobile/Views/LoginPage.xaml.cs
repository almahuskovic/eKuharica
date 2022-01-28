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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            //BindingContext = new LoginViewModel(); //moze se bindati i na ovaj nacin
            Application.Current.MainPage = new NavigationPage(new AboutPage());
        }
    }
}