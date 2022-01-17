using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKuharica.Mobile.ViewModels
{
    public class RecipesViewModel
    {
        private readonly APIService _recipeService = new APIService("Recipe");
        public RecipesViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Recipe> RecipeList { get; set; } = new ObservableCollection<Recipe>();
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _recipeService.Get<IEnumerable<Recipe>>(null);
            RecipeList.Clear();
            foreach (var recipe in list)
            {
                RecipeList.Add(recipe);
            }
        }
    }
}
