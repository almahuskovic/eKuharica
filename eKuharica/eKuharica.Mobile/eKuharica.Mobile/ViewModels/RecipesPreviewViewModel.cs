using eKuharica.Mobile.Extensions;
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
        private readonly APIService _userRecipeRatingService = new APIService("UserRecipeRating");
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

        int _grade = 0;
        public int Grade
        {
            get { return _grade; }
            set { SetProperty(ref _grade, value); }
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

        string _numberOfLikes = string.Empty;
        public string NumberOfLikes
        {
            get { return _numberOfLikes; }
            set { SetProperty(ref _numberOfLikes, value); }
        }
        public ICommand InitCommand { get; set; }
        public ICommand AddCommentCommand { get; set; }
        public async Task Init()
        {
            var loggedUser = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);

            if (GradesList.Count == 0)
            {
                for (int i = 1; i < 6; i++)
                {
                    GradesList.Add(new EnumItem() { Index = i, Value = i.ToString() });
                }

                var userRatingSearchRequest = new UserRecipeRatingSearchRequest() { UserId = loggedUser.Id, RecipeId = _recipe.Id };
                var exist = (await _userRecipeRatingService.Get<List<UserRecipeRatingDto>>(userRatingSearchRequest)).FirstOrDefault();

                Grade = exist != null ? exist.Rating : 0;
            }

            NumberOfLikes = (await _userFavouriteRecipeService.Get<List<UserFavouriteRecipeDto>>(new UserFavouriteRecipeSearchRequest() { RecipeId = _recipe.Id })).Count().ToString();
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
                await Application.Current.MainPage.DisplayAlert(
                    new TranslateExtension() { Text = "Uspješno" }.ProvideValue().ToString(),
                    new TranslateExtension() { Text = "KomentarUspješnoSpašen" }.ProvideValue().ToString(),
                    new TranslateExtension() { Text = "OK" }.ProvideValue().ToString());
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert(
                    new TranslateExtension() { Text = "Greška" }.ProvideValue().ToString(),
                    new TranslateExtension() { Text = "DogodilaSeGreškaPrilikomDodavanjaKomentara" }.ProvideValue().ToString(),
                    new TranslateExtension() { Text = "OK" }.ProvideValue().ToString());
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
        public async Task Rating()
        {
            var loggedUser = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);

            var userRatingSearchRequest = new UserRecipeRatingSearchRequest() { UserId = loggedUser.Id, RecipeId = _recipe.Id };
            var exist = (await _userRecipeRatingService.Get<List<UserRecipeRatingDto>>(userRatingSearchRequest)).FirstOrDefault();

            if (exist != null && exist.Rating != Grade)
            {
                exist.Rating = Grade;
                await _userRecipeRatingService.Update<UserRecipeRatingUpsertRequest>(exist.Id, exist);

                await Application.Current.MainPage.DisplayAlert(
                  new TranslateExtension() { Text = "Uspješno" }.ProvideValue().ToString(),
                  new TranslateExtension() { Text = "OcjenaUspješnoSpašena" }.ProvideValue().ToString(),
                  new TranslateExtension() { Text = "OK" }.ProvideValue().ToString());
            }
            else if (exist == null)
            {
                var userRating = new UserRecipeRatingUpsertRequest()
                {
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                    Rating = Grade,
                    RecipeId = _recipe.Id,
                    UserId = loggedUser.Id
                };

                await _userRecipeRatingService.Insert<UserRecipeRatingUpsertRequest>(userRating);

                await Application.Current.MainPage.DisplayAlert(
                   new TranslateExtension() { Text = "Uspješno" }.ProvideValue().ToString(),
                   new TranslateExtension() { Text = "OcjenaUspješnoSpašena" }.ProvideValue().ToString(),
                   new TranslateExtension() { Text = "OK" }.ProvideValue().ToString());
            }
        }

    }
}
