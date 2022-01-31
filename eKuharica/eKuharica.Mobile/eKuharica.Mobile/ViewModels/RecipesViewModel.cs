using System;
using eKuharica.Mobile.Models;
using eKuharica.Model.Entities;
using eKuharica.Model.Models;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using System.Linq;
using Plugin.Multilingual;

namespace eKuharica.Mobile.ViewModels
{
    public class RecipesViewModel : BaseViewModel
    {
        private readonly APIService _recipeService = new APIService("Recipe");
        private readonly APIService _recipeTranslationService = new APIService("RecipeTranslation");
        private readonly APIService _userService = new APIService("User");
        private readonly APIService _userFavouriteRecipeService = new APIService("UserFavouriteRecipe");
        public RecipesViewModel()
        {
            InitCommand = new Command(async () => await Init());
            TitleCommand = new Command(async () => await Init());
        }

        public ObservableCollection<RecipeDto> RecipeList { get; set; } = new ObservableCollection<RecipeDto>();
        public ObservableCollection<EnumItem> MealTypeList { get; set; } = new ObservableCollection<EnumItem>();
        EnumItem _selectedMealType = null;

        public ObservableCollection<EnumItem> PreparationTimeList { get; set; } = new ObservableCollection<EnumItem>();
        EnumItem _selectedPreparationTime = null;

        public ObservableCollection<EnumItem> WeightOfPreparationList { get; set; } = new ObservableCollection<EnumItem>();
        EnumItem _selectedWeightOfPreparation = null;

        string _title = string.Empty;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public EnumItem SelectedMealType
        {
            get { return _selectedMealType; }
            set
            {
                SetProperty(ref _selectedMealType, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }
        public EnumItem SelectedPreparationTime
        {
            get { return _selectedPreparationTime; }
            set
            {
                SetProperty(ref _selectedPreparationTime, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }
        public EnumItem SelectedWeightOfPreparation
        {
            get { return _selectedWeightOfPreparation; }
            set
            {
                SetProperty(ref _selectedWeightOfPreparation, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }
        public ICommand InitCommand { get; set; }
        public ICommand TitleCommand { get; set; }
        public async Task Init()
        {
            if (MealTypeList.Count == 0 && WeightOfPreparationList.Count == 0 && PreparationTimeList.Count == 0)
            {
                var mealTypeList = Helpers.Helper.MealTypeToList();
                var weightOfPreparationList = Helpers.Helper.WeightOfPreparationToList();
                var preparationTimeList = Helpers.Helper.PreparationTimeCategoryToList();

                foreach (var mealType in mealTypeList)
                {
                    MealTypeList.Add(mealType);
                }
                foreach (var weightOfPreparation in weightOfPreparationList)
                {
                    WeightOfPreparationList.Add(weightOfPreparation);
                }
                foreach (var preparationTime in preparationTimeList)
                {
                    PreparationTimeList.Add(preparationTime);
                }
            }

            if (SelectedMealType != null || SelectedPreparationTime != null || SelectedWeightOfPreparation != null || !string.IsNullOrWhiteSpace(Title))
            {
                RecipeSearchObject searchRequest = new RecipeSearchObject();
                searchRequest.MealType = SelectedMealType?.Index == 0 ? null: SelectedMealType?.Index;
                searchRequest.WeightOfPreparation = SelectedWeightOfPreparation?.Index == 0 ? null : SelectedWeightOfPreparation?.Index;
                searchRequest.PreparationTimeCategory = SelectedPreparationTime?.Index == 0 ? null : SelectedPreparationTime?.Index;
                searchRequest.Title = Title;

                var list = await _recipeService.Get<IEnumerable<RecipeDto>>(searchRequest);

                if (CrossMultilingual.Current.CurrentCultureInfo.Name == "en")
                {
                    var recipeIds = list.Select(x => x.Id).ToList();
                    var translationSearchRequest = new RecipeTranslationSearchRequest(){ RecipeIds = recipeIds };
                    var recipeTranslations = await _recipeTranslationService.Get<List<RecipeTranslationDto>>(translationSearchRequest);
                  
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

                RecipeList.Clear();

                var loggedUser = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);

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
