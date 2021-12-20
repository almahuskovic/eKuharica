using eKuharica.Model.DTO;
using eKuharica.Model.Enumerations;
using eKuharica.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public frmShowRecipes(RecipeDto recipe = null, string source="")
        {
            InitializeComponent();
            _recipe = recipe;
            _source = source;
        }

        private void frmShowRecipes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            if (_recipe != null)
            {
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
                rcStar.Value = _recipe.Rating;

                var loggedUser = (await _userService.Get<List<UserDto>>(new UserSearchRequest() { UserName = APIService.Username }));
                lblAuthor.Text = loggedUser.FirstOrDefault().Username;

                if (_source != "" && (int)Enum.Parse(typeof(Enumerations.Source), _source) == (int)Enumerations.Source.Add)
                {
                    gbLike.Visible = rcStar.Visible = false;//rbtnComments.Visible = false;
                }
            }
        }

        private async void rcLike_Click(object sender, EventArgs e)
        {
            var loggedUser = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);

            var userFavSearchRequest = new UserFavouriteRecipeSearchRequest() { UserId = loggedUser.Id, RecipeId = _recipe.Id };
            var exist = await _userFavouriteRecipeService.Get<UserFavouriteRecipeDto>(userFavSearchRequest);

            exist.IsDeleted = !exist.IsDeleted;
            await _userFavouriteRecipeService.Update<UserFavouriteRecipeDto>(exist.Id, exist);
        }

        private async void rcStar_Click(object sender, EventArgs e)
        {
            var loggedUser = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);

            //var userFavSearchRequest = new UserFavouriteRecipeSearchRequest() { UserId = loggedUser.Id, RecipeId = _recipe.Id };
            //var exist = await _userFavouriteRecipeService.Get<UserFavouriteRecipeDto>(userFavSearchRequest);

            //await _userFavouriteRecipeService.Update<UserFavouriteRecipeDto>(exist.Id, exist);
        }
    }
}
