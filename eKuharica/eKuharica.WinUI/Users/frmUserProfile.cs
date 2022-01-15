using eKuharica.Model.DTO;
using eKuharica.Model.Models;
using eKuharica.Model.Requests;
using eKuharica.WinUI.Recipes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKuharica.WinUI.Users
{
    public partial class frmUserProfile : Form
    {
        APIService _userService = new APIService("User");
        APIService _followService = new APIService("Follow");
        APIService _recipeService = new APIService("Recipe");
        private UserDto _user;
        public frmUserProfile(UserDto user)
        {
            InitializeComponent();
            _user = user;
            dgvRecipesSendByUser.AutoGenerateColumns = false;

            #region localizer
            btnClose.Text = Helpers.Helper.TranslationForBtnBack();

            if (Helpers.Helper.CurrentLanguage == "bs")
            {
                lblFollowers.Text = "Pratitelji";
                lblFollowing.Text = "Pratim";
                lblUserName.Text = "Korisničko ime";

                dgvRecipesSendByUser.Columns[0].HeaderText = "Recpet";
                dgvRecipesSendByUser.Columns[1].HeaderText = "Prikaži";
            }
            else
            {
                lblFollowers.Text = "Followers";
                lblFollowing.Text = "Following";
                lblUserName.Text = "Username";

                dgvRecipesSendByUser.Columns[0].HeaderText = "Recipe";
                dgvRecipesSendByUser.Columns[1].HeaderText = "Preview";
            }

            #endregion
        }

        private async void frmUserProfile_Load(object sender, EventArgs e)
        {
            var follows = await _followService.Get<List<FollowDto>>(new FollowSearchRequest() { UserId = _user.Id });
            var followers = await _followService.Get<List<FollowDto>>(new FollowSearchRequest() { FollowerId = _user.Id });
            var recipes = await _recipeService.Get<List<RecipeDto>>(new RecipeSearchObject() { LoggedUserId = _user.Id, MyRecipes = true });
            
            lblFollowersValue.Text = followers.Count().ToString();
            lblFollowingValue.Text = follows.Count().ToString();
            lblUserNameValue.Text = _user.Username;
            pbPicture.Image = Helpers.Helper.ByteArrayToImage(_user.Picture);
            dgvRecipesSendByUser.DataSource = recipes;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void dgvRecipesSendByUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvRecipesSendByUser.SelectedRows[0].DataBoundItem as RecipeDto;

                if (e.ColumnIndex == 1)
                {
                    frmShowRecipes frmShowRecipe = new frmShowRecipes(selectedRow);
                    frmShowRecipe.MdiParent = MdiParent;
                    frmShowRecipe.WindowState = FormWindowState.Maximized;
                    frmShowRecipe.Show();
                }
            }
        }
    }
}
