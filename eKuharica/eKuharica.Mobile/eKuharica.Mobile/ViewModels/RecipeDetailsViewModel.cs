using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Enumerations;
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
    public class RecipeDetailsViewModel : BaseViewModel
    {
        private readonly APIService _commentService = new APIService("Comment");
        private readonly APIService _userService = new APIService("User");
        public RecipeDetailsViewModel()
        {
            InitCommand = new Command(async () => await Init());
            AddComment = new Command(async () => await CommentAdd());
        }
        public RecipeDto Recipe{ get; set; }

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
        public ICommand AddComment { get; set; }
        public async Task Init()
        {
            MealType = Enum.GetName(typeof(Enumerations.MealType), Recipe.MealType);
            WeightOfPreparation= Enum.GetName(typeof(Enumerations.WeightOfPreparation), Recipe.WeightOfPreparation);

            Comments = Helpers.Helper.GenerateCommentsDisplayList(await _commentService.Get<List<CommentDto>>(new CommentSearchRequest() { RecipeId = Recipe.Id }));
        }
        public async Task CommentAdd()
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
    }
}
