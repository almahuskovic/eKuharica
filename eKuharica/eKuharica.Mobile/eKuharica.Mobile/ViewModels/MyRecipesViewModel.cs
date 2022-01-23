using eKuharica.Model.DTO;
using eKuharica.Model.Models;
using eKuharica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKuharica.Mobile.ViewModels
{
    public class MyRecipesViewModel : BaseViewModel
    {
        private readonly APIService _recipeService = new APIService("Recipe");
        private readonly APIService _userFavouriteRecipeService = new APIService("UserFavouriteRecipe");
        private readonly APIService _userService = new APIService("User");
        bool _displayFavourite;
        public MyRecipesViewModel(bool displayFavourite = false)
        {
            InitCommand = new Command(async () => await Init());
            _displayFavourite = displayFavourite;
        }

        public ObservableCollection<RecipeDto> RecipesList { get; set; } = new ObservableCollection<RecipeDto>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var loggedUser = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);

            var searchObj = new RecipeSearchObject()
            {
                LoggedUserId = loggedUser.Id
            };

            if (_displayFavourite)
            {
                var searchRequest = new UserFavouriteRecipeSearchRequest()
                {
                    UserId = loggedUser.Id
                };

                searchObj.RecipeIds = (await _userFavouriteRecipeService.Get<List<UserFavouriteRecipeDto>>(searchRequest))
                   .Where(x => !x.IsDeleted)
                   .Select(x => x.RecipeId)
                   .ToList();
                searchObj.IsFavouriteRecipeSearch = true;
            }
            else
                searchObj.MyRecipes = true;
            

            var list = await _recipeService.Get<List<RecipeDto>>(searchObj);

            RecipesList.Clear();
            foreach (var recipe in list)
            {
                RecipesList.Add(recipe);
            }

        }
    }
}
