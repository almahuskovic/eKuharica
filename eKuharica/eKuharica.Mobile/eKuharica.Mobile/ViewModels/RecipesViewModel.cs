using System;
using eKuharica.Mobile.Models;
using eKuharica.Model.Entities;
using eKuharica.Model.Models;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKuharica.Mobile.ViewModels
{
    public class RecipesViewModel : BaseViewModel
    {
        private readonly APIService _recipeService = new APIService("Recipe");
        public RecipesViewModel()
        {
            InitCommand = new Command(async () => await Init());
            TitleCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Recipe> RecipeList { get; set; } = new ObservableCollection<Recipe>();
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

                var list = await _recipeService.Get<IEnumerable<Recipe>>(searchRequest);
                RecipeList.Clear();
                foreach (var recipe in list)
                {
                    RecipeList.Add(recipe);
                }
            }
        }
    }
}
