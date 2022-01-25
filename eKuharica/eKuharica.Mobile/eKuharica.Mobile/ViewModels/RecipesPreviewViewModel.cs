using eKuharica.Mobile.Models;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Enumerations;
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
    public class RecipesPreviewViewModel : BaseViewModel
    {
        private readonly APIService _commentService = new APIService("Comment");
        private readonly APIService _userService = new APIService("User");
        private readonly APIService _recipeService = new APIService("Recipe");
        private readonly APIService _userFavouriteRecipeService = new APIService("UserFavouriteRecipe");
        public RecipesPreviewViewModel()
        {
            InitCommand = new Command(async () => await Init());
            AddCommentCommand = new Command(async () => await AddComment());
        }

        RecipeDto _recipe = null;
        public RecipeDto Recipe
        {
            get { return _recipe; }
            set { SetProperty(ref _recipe, value); }
        }

        public ObservableCollection<EnumItem> GradesList { get; set; } = new ObservableCollection<EnumItem>();
        EnumItem _selectedGrade = null;
        public EnumItem SelectedGrade
        {
            get { return _selectedGrade; }
            set
            {
                SetProperty(ref _selectedGrade, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }
        string _comment = string.Empty;
        public string Comment
        {
            get { return _comment; }
            set { SetProperty(ref _comment, value); }
        }

        string _comments = string.Empty;
        public string Comments
        {
            get { return _comments; }
            set { SetProperty(ref _comments, value); }
        }
        string _weightOfPreparation = string.Empty;
        public string WeightOfPreparation
        {
            get { return _weightOfPreparation; }
            set { SetProperty(ref _weightOfPreparation, value); }
        }

        string _mealType = string.Empty;
        public string MealType
        {
            get { return _mealType; }
            set { SetProperty(ref _mealType, value); }
        }
        public ICommand InitCommand { get; set; }
        public ICommand AddCommentCommand { get; set; }
        public async Task Init()
        {
            var loggedUser = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);
            var userFavSearchRequest = new UserFavouriteRecipeSearchRequest() { UserId = loggedUser.Id, RecipeId = _recipe.Id };
            var exist = (await _userFavouriteRecipeService.Get<List<UserFavouriteRecipeDto>>(userFavSearchRequest)).FirstOrDefault();
            Recipe.IsLiked = exist != null ? exist.IsDeleted : false;

            if (GradesList.Count == 0)
            {
                for (int i = 1; i < 6; i++)
                {
                    GradesList.Add(new EnumItem() { Index = i, Value = i.ToString() });
                }
            }

            MealType = Enum.GetName(typeof(Enumerations.MealType), Recipe.MealType);
            WeightOfPreparation = Enum.GetName(typeof(Enumerations.WeightOfPreparation), Recipe.WeightOfPreparation);

            Comments = Helpers.Helper.GenerateCommentsDisplayList(await _commentService.Get<List<CommentDto>>(new CommentSearchRequest() { RecipeId = Recipe.Id }));
        }
        public async Task AddComment()
        {
            if (!string.IsNullOrWhiteSpace(Comment))
            {
                var myComment = new CommentUpsertRequest()
                {
                    Description = Comment,
                    IsDeleted = false,
                    ModifiedAt = DateTime.Now,
                    RecipeId = Recipe.Id,
                    UserId = (await Helpers.Helper.GetLoggedUser(_userService, APIService.Username)).Id
                };
                await _commentService.Insert<CommentUpsertRequest>(myComment);
                await Application.Current.MainPage.DisplayAlert("Uspješno", "Komentar uspješno spašen", "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Dogodila se greška prilikom dodavanja komentara", "OK");
                return;
            }
        }
        public async Task Like()
        {
            var loggedUser = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);

            var userFavSearchRequest = new UserFavouriteRecipeSearchRequest() { UserId = loggedUser.Id, RecipeId = _recipe.Id };
            var exist = (await _userFavouriteRecipeService.Get<List<UserFavouriteRecipeDto>>(userFavSearchRequest)).FirstOrDefault();

            if (exist != null)
            {
                exist.IsDeleted = !exist.IsDeleted;
                await _userFavouriteRecipeService.Update<UserFavouriteRecipeUpsertRequest>(exist.Id, exist);
            }
            else
            {
                var userFavourite = new UserFavouriteRecipeUpsertRequest()
                {
                    IsDeleted = false,
                    RecipeId = _recipe.Id,
                    UserId = loggedUser.Id
                };
                await _userFavouriteRecipeService.Insert<UserFavouriteRecipeUpsertRequest>(userFavourite);
            }

        }
    }
}
