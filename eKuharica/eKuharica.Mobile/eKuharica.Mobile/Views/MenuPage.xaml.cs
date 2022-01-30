using eKuharica.Mobile.Extensions;
using eKuharica.Mobile.Models;
using Plugin.Multilingual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKuharica.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Home, Title = new TranslateExtension(){ Text="Početna" }.ProvideValue().ToString() },
                new HomeMenuItem {Id = MenuItemType.Recipe, Title =  new TranslateExtension(){Text = "Recepti" }.ProvideValue().ToString() },
                new HomeMenuItem {Id = MenuItemType.Articles, Title = new TranslateExtension(){Text = "Članci" }.ProvideValue().ToString() },
                new HomeMenuItem {Id = MenuItemType.FavouriteRecipes, Title = new TranslateExtension(){Text = "OmiljeniRecepti" }.ProvideValue().ToString() },
                new HomeMenuItem {Id = MenuItemType.Followers, Title = new TranslateExtension(){Text = "Pratitelji" }.ProvideValue().ToString() },
                new HomeMenuItem {Id = MenuItemType.Following, Title = new TranslateExtension(){Text = "Pratim" }.ProvideValue().ToString() },
                new HomeMenuItem {Id = MenuItemType.SendRecipe, Title = new TranslateExtension(){Text = "PošaljiRecept" }.ProvideValue().ToString() },
                new HomeMenuItem {Id = MenuItemType.MyRecipes, Title = new TranslateExtension(){Text = "MojiRecepti" }.ProvideValue().ToString() },
                new HomeMenuItem {Id = MenuItemType.Feedbacks, Title = new TranslateExtension(){Text = "OstaviDojam" }.ProvideValue().ToString() },
                new HomeMenuItem {Id = MenuItemType.Settings, Title = new TranslateExtension(){Text = "Postavke" }.ProvideValue().ToString() },
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}