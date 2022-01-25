using eKuharica.Mobile.Models;
using eKuharica.Mobile.Views;
using eKuharica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKuharica.Mobile.ViewModels
{
    public class SendRecipeViewModel : BaseViewModel
    {
        private readonly APIService _recipeService = new APIService("Recipe");
        private readonly APIService _userService = new APIService("User");
     
        public SendRecipeViewModel()
        {
            InitCommand = new Command(async () => await Init());
            SendCommand = new Command(async () => await Send());
        }


        string _title = string.Empty;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        string _introduction = string.Empty;
        public string Introduction
        {
            get { return _introduction; }
            set { SetProperty(ref _introduction, value); }
        }

        string _ingredients = string.Empty;
        public string Ingredients
        {
            get { return _ingredients; }
            set { SetProperty(ref _ingredients, value); }
        }

        string _method = string.Empty;
        public string Method
        {
            get { return _method; }
            set { SetProperty(ref _method, value); }
        }

        string _serving = string.Empty;
        public string Serving
        {
            get { return _serving; }
            set { SetProperty(ref _serving, value); }
        }

        string _advice = string.Empty;
        public string Advice
        {
            get { return _advice; }
            set { SetProperty(ref _advice, value); }
        }

        string _preparationTime = string.Empty;
        public string PreparationTime
        {
            get { return _preparationTime; }
            set { SetProperty(ref _preparationTime, value); }
        }

        public ObservableCollection<EnumItem> MealTypeList { get; set; } = new ObservableCollection<EnumItem>();
        EnumItem _selectedMealType = null;

        public ObservableCollection<EnumItem> WeightOfPreparationList { get; set; } = new ObservableCollection<EnumItem>();
        EnumItem _selectedWeightOfPreparation = null;

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

        public ICommand SendCommand { get; set; }
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if(MealTypeList.Count == 0 && WeightOfPreparationList.Count == 0)
            {
                var mealTypeList = Helpers.Helper.MealTypeToList();
                var weightOfPreparationList = Helpers.Helper.WeightOfPreparationToList();

                foreach (var mealType in mealTypeList)
                {
                    MealTypeList.Add(mealType);
                }
                foreach (var weightOfPreparation in weightOfPreparationList)
                {
                    WeightOfPreparationList.Add(weightOfPreparation);
                }
            }
        }

        public async Task Send()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(PreparationTime) || SelectedMealType?.Index == null || SelectedWeightOfPreparation?.Index == null ||
                    string.IsNullOrWhiteSpace(Ingredients) || string.IsNullOrWhiteSpace(Method) || string.IsNullOrWhiteSpace(Title) ||
                    !int.TryParse(PreparationTime, out int n))
                {
                    throw new Exception();
                }

                var loggedUser = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);
                var recipe = new RecipeUpsertRequest()
                {
                    Advice = Advice,
                    Method = Method,
                    Ingredients = Ingredients,
                    Introduction = Introduction,
                    IsSent = true,
                    Serving = Serving,
                    Title = Title,
                    UserId = loggedUser.Id,
                    WeightOfPreparation = SelectedWeightOfPreparation.Index,
                    MealType = SelectedMealType.Index,
                    PreparationTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(PreparationTime)/ 60, int.Parse(PreparationTime) % 60, 0) 
                };

                await _recipeService.Insert<RecipeUpsertRequest>(recipe);
                await Application.Current.MainPage.DisplayAlert("Uspješno", "Recept uspješno spremljen", "OK");

                Routing.RegisterRoute("feedbackPage", typeof(FeedbackPage));
                await Shell.Current.GoToAsync($"../views/feedbackPage");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                await Application.Current.MainPage.DisplayAlert("Greška", "Dogodila se greška prilikom slanja recepta", "OK");
                return;
            }
           
        }
    }
}
