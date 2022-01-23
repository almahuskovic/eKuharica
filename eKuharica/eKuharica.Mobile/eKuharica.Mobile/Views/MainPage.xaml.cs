﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using eKuharica.Mobile.Models;

namespace eKuharica.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.Recipe:
                        MenuPages.Add(id, new NavigationPage(new RecipesPage()));
                        break;
                    case (int)MenuItemType.Articles:
                        MenuPages.Add(id, new NavigationPage(new ArticlesPage()));
                        break;
                    case (int)MenuItemType.FavouriteRecipes:
                        MenuPages.Add(id, new NavigationPage(new MyRecipesPage(true)));
                        break;
                    case (int)MenuItemType.Followers:
                        MenuPages.Add(id, new NavigationPage(new FollowsPage(true)));
                        break;
                    case (int)MenuItemType.Following:
                        MenuPages.Add(id, new NavigationPage(new FollowsPage(false)));
                        break;
                    case (int)MenuItemType.MyRecipes:
                        MenuPages.Add(id, new NavigationPage(new MyRecipesPage()));
                        break;
                    case (int)MenuItemType.SendRecipe:
                        MenuPages.Add(id, new NavigationPage(new SendRecipePage()));
                        break;
                    case (int)MenuItemType.Settings:
                        MenuPages.Add(id, new NavigationPage(new ProfileSettingsPage()));
                        break;
                    case (int)MenuItemType.Feedbacks:
                        MenuPages.Add(id, new NavigationPage(new FeedbackPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}