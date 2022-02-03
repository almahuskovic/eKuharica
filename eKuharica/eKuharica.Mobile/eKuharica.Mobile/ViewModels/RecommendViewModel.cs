using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using Plugin.Multilingual;
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
    public class RecommendViewModel : BaseViewModel
    {
        private readonly APIService _recipeService = new APIService("Recipe");
        private readonly APIService _recipeTranslationService = new APIService("RecipeTranslation");
        private readonly APIService _userService = new APIService("User");
        private readonly APIService _userFavouriteRecipeService = new APIService("UserFavouriteRecipe");
        public RecommendViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<RecipeDto> RecipeList { get; set; } = new ObservableCollection<RecipeDto>();
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var loggedUser = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);

            var list = await _recipeService.GetRecommended<IEnumerable<RecipeDto>>(loggedUser.Id);

            if (CrossMultilingual.Current.CurrentCultureInfo.Name == "en")
            {
                var recipeIds = list.Select(x => x.Id).ToList();
                var translationSearchRequest = new RecipeTranslationSearchRequest() { RecipeIds = recipeIds };
                var recipeTranslations = await _recipeTranslationService.Get<List<RecipeTranslationDto>>(translationSearchRequest);

                if (recipeTranslations.Any())
                {
                    list.ToList().ForEach(x =>
                    {
                        var temp = recipeTranslations.Where(t => t.RecipeId == x.Id).First();
                        x.Ingredients = temp.Ingredients;
                        x.Introduction = temp.Introduction;
                        x.Serving = temp.Serving;
                        x.Advice = temp.Advice;
                        x.Method = temp.Method;
                        x.Title = temp.Title;
                    });
                }
                else
                    list = null;
            }

            RecipeList.Clear();

            if (list != null)
            {
                foreach (var recipe in list)
                {
                    var userFavSearchRequest = new UserFavouriteRecipeSearchRequest() { UserId = loggedUser.Id, RecipeId = recipe.Id };
                    var exist = (await _userFavouriteRecipeService.Get<List<UserFavouriteRecipeDto>>(userFavSearchRequest)).FirstOrDefault();
                    recipe.IsLiked = exist != null ? !exist.IsDeleted : false;

                    RecipeList.Add(recipe);
                }
            }
        }
    }
}
