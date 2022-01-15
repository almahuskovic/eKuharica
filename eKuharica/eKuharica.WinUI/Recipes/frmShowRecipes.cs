using eKuharica.Model.DTO;
using eKuharica.Model.Enumerations;
using eKuharica.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKuharica.WinUI.Recipes
{
    public partial class frmShowRecipes : Form
    {
        private RecipeDto _recipe;
        private string _source;
        APIService _userService = new APIService("User");
        APIService _recipeService = new APIService("Recipe");
        APIService _userFavouriteRecipeService = new APIService("UserFavouriteRecipe");
        APIService _userRecipeRatingService = new APIService("UserRecipeRating");
        APIService _commentService = new APIService("Comment");
        public frmShowRecipes(RecipeDto recipe = null, string source="")
        {
            InitializeComponent();
            _recipe = recipe;
            _source = source;

            #region localizer

            btnClose.Text = Helpers.Helper.TranslationForBtnBack();

            if (Helpers.Helper.CurrentLanguage == "bs"){

                lblAdvice.Text = "Savijet";
                lblIngredients.Text = "Sastojci";
                lblMethod.Text = "Postupak";
                lblBack.Text = "Nazad";
                lblServing.Text = "Posluživanje";
                btnAddComment.Text = "Dodaj komentar";
                btnMethodMore.Text = "Pročitajte više->";
                btnAdviceMore.Text= "Pročitajte više->";
                btnServingMore.Text="Pročitajte više->";
            }
            else
            {
                lblAdvice.Text = "Advice";
                lblIngredients.Text = "Ingredients";
                lblMethod.Text = "Method";
                lblServing.Text = "Serving";
                lblBack.Text = "Back";
                btnAddComment.Text = "Add comment";
                btnMethodMore.Text = "Read more->";
                btnAdviceMore.Text = "Read more->";
                btnServingMore.Text = "Read more->";
            }

            #endregion
        }

        private void frmShowRecipes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            if (_recipe != null)
            {
                var loggedUser = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);

                rtbAdvice.Text = _recipe.Advice;
                rtbMethod.Text = _recipe.Method;
                rtbIntroduction.Text = _recipe.Introduction;
                rtbIngredients.Text = _recipe.Ingredients;
                rtbServing.Text = _recipe.Serving;
                pbPicture.Image = Helpers.Helper.ByteArrayToImage(_recipe.Picture);
                lblTitle.Text = _recipe.Title;
                gbAdvice.Visible = gbServing.Visible = true;
                lblPrepTime.Text = _recipe.PreparationTime.ToShortTimeString();
                lblMealType.Text = Enum.GetName(typeof(Enumerations.MealType), _recipe.MealType);
                lblWeightOfPrep.Text = Enum.GetName(typeof(Enumerations.WeightOfPreparation), _recipe.WeightOfPreparation);
                rcStar.Value = (await _userRecipeRatingService.Get<List<UserRecipeRatingDto>>(new UserRecipeRatingSearchRequest() { RecipeId = _recipe.Id, UserId = loggedUser.Id })).FirstOrDefault().Rating;
                rcAddFavourite.Value = (await _userFavouriteRecipeService.Get<List<UserFavouriteRecipeDto>>(new UserFavouriteRecipeSearchRequest() { RecipeId = _recipe.Id, UserId = loggedUser.Id })).Count()>0?1:0;
                rtbComments.Text = Helpers.Helper.GenerateCommentsDisplayList(await _commentService.Get<List<CommentDto>>(new CommentSearchRequest() { RecipeId = _recipe.Id }));
                lblLikesDisplay.Text = (await _userFavouriteRecipeService.Get<List<UserFavouriteRecipeDto>>(new UserFavouriteRecipeSearchRequest() { RecipeId = _recipe.Id })).Count().ToString();

                lblAuthor.Text = loggedUser.Username;

                if (_source != "" && (int)Enum.Parse(typeof(Enumerations.Source), _source) == (int)Enumerations.Source.Add)
                {
                    gbLike.Visible = rcStar.Visible = rcAddFavourite.Visible = gbComments.Visible = false;//rbtnComments.Visible = false;
                }
            }
        }

        private async void rcStar_Click(object sender, EventArgs e)
        {
            var loggedUser = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);
            var rating = int.Parse(rcStar.ToolTipSettings.Body.Text);

            var userRatingSearchRequest = new UserRecipeRatingSearchRequest() { UserId = loggedUser.Id, RecipeId = _recipe.Id };
            var exist = (await _userRecipeRatingService.Get<List<UserRecipeRatingDto>>(userRatingSearchRequest)).FirstOrDefault();

            if (exist != null && exist.Rating != rating)
            {
                exist.Rating = rating;
                await _userRecipeRatingService.Update<UserRecipeRatingUpsertRequest>(exist.Id, exist);
            }
            else
            {
                var userRating = new UserRecipeRatingUpsertRequest()
                {
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                    Rating = rating,
                    RecipeId = _recipe.Id,
                    UserId = loggedUser.Id
                };

                await _userRecipeRatingService.Insert<UserRecipeRatingUpsertRequest>(userRating);
            }
        }

        private async void rcAddFavourite_Click(object sender, EventArgs e)
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

        private async void btnAddComment_Click(object sender, EventArgs e)
        {
            try
            {
                var comment = new CommentUpsertRequest()
                {
                    Description = txtComment.Text,
                    IsDeleted = false,
                    ModifiedAt = DateTime.Now,
                    RecipeId = _recipe.Id,
                    UserId = (await Helpers.Helper.GetLoggedUser(_userService, APIService.Username)).Id
                };

                await _commentService.Insert<CommentUpsertRequest>(comment);

                MessageBox.Show("Komentar je uspješno spašen");
            }
            catch
            {
                MessageBox.Show("Dogodila se greška");
            }
        }

        private void btnMethodMore_Click(object sender, EventArgs e)
        {
            frmMoreToRead frmMoreToRead = new frmMoreToRead(_recipe.Method);
            frmMoreToRead.Owner = this;
            Enabled = false;
            frmMoreToRead.ShowDialog();
        }

        private void btnServingMore_Click(object sender, EventArgs e)
        {
            frmMoreToRead frmMoreToRead = new frmMoreToRead(_recipe.Serving);
            frmMoreToRead.Owner = this;
            Enabled = false;
            frmMoreToRead.ShowDialog();
        }

        private void btnAdviceMore_Click(object sender, EventArgs e)
        {
            frmMoreToRead frmMoreToRead = new frmMoreToRead(_recipe.Advice);
            frmMoreToRead.Owner = this;
            Enabled = false;
            frmMoreToRead.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_source == string.Empty)
            {
                Hide();
                return;
            }

            var isFavourite = (int)Enum.Parse(typeof(Enumerations.Source), _source) == (int)Enumerations.Source.Other;

            frmRecipes frmRecipes = new frmRecipes(isFavourite);
            frmRecipes.MdiParent = MdiParent;
            frmRecipes.WindowState = FormWindowState.Maximized;
            frmRecipes.Show();
        }
    }
}
