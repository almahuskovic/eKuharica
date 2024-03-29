﻿using eKuharica.Mobile.Models;
using eKuharica.Mobile.ViewModels;
using eKuharica.Model.DTO;
using Plugin.Multilingual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static eKuharica.Model.Enumerations.Enumerations;

namespace eKuharica.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipesPage : ContentPage, INotifyPropertyChanged
    {
        private RecipesViewModel model = null;
        public RecipesPage()
        {
            InitializeComponent();
            BindingContext = model = new RecipesViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
       
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as RecipeDto;
           
            await Navigation.PushAsync(new RecipesPreviewPage(item));
        }
    }
}