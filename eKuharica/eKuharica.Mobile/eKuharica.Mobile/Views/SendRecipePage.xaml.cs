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
    public partial class SendRecipePage : ContentPage
    {
        private SendRecipeViewModel model = null;
        public SendRecipePage()
        {
            InitializeComponent();
            BindingContext = model = new SendRecipeViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}