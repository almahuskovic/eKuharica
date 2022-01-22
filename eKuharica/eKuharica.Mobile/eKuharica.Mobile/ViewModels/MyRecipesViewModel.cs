using eKuharica.Model.DTO;
using eKuharica.Model.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKuharica.Mobile.ViewModels
{
    public class MyRecipesViewModel : BaseViewModel
    {
        private readonly APIService _recipeService = new APIService("Recipe");
        private readonly APIService _userService = new APIService("User");
        public MyRecipesViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<RecipeDto> RecipesList { get; set; } = new ObservableCollection<RecipeDto>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var loggedUser = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);

            var list = await _recipeService.Get<List<RecipeDto>>(new RecipeSearchObject() { MyRecipes = true, LoggedUserId = loggedUser.Id });

            RecipesList.Clear();
            foreach (var recipe in list)
            {
                RecipesList.Add(recipe);
            }

        }
    }
}
