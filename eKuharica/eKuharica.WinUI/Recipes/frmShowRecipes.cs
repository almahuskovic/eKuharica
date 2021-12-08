using eKuharica.Model.DTO;
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
        APIService _userService = new APIService("User");
        public frmShowRecipes(RecipeDto recipe = null)
        {
            InitializeComponent();
            _recipe = recipe;
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

                var loggedUser = (await _userService.Get<List<UserDto>>(new UserSearchRequest() { UserName = APIService.Username }));
                lblAuthor.Text = loggedUser.FirstOrDefault().Username;
            }
        }
    }
}
