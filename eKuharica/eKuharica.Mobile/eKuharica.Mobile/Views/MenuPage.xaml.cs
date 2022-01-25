using eKuharica.Mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                new HomeMenuItem {Id = MenuItemType.Recipe, Title="About" },
                new HomeMenuItem {Id = MenuItemType.Recipe, Title="Recipes" },
                new HomeMenuItem {Id = MenuItemType.Articles, Title="Articles" },
                new HomeMenuItem {Id = MenuItemType.FavouriteRecipes, Title="FavouriteRecipes" },
                new HomeMenuItem {Id = MenuItemType.Followers, Title="Followers" },
                new HomeMenuItem {Id = MenuItemType.Following, Title="Following" },
                new HomeMenuItem {Id = MenuItemType.SendRecipe, Title="SendRecipe" },
                new HomeMenuItem {Id = MenuItemType.MyRecipes, Title="MyRecipes" },
                new HomeMenuItem {Id = MenuItemType.Feedbacks, Title="Feedbacks" },
                new HomeMenuItem {Id = MenuItemType.Settings, Title="Settings" },
                new HomeMenuItem {Id = MenuItemType.LogOut, Title="LogOut" },
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