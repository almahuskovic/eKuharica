using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Recipe,
        Articles,
        FavouriteRecipes,
        Followers,
        Following,
        Settings,
        SendRecipe,
        MyRecipes,
        Feedbacks,
        LogOut
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
