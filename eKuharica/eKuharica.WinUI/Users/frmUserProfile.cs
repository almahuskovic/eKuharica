using eKuharica.Model.DTO;
using eKuharica.Model.Models;
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
        }

        private async void frmUserProfile_Load(object sender, EventArgs e)
        {
            var follows = await _followService.Get<List<FollowDto>>(new FollowSearchRequest() { UserId = _user.Id });
            var followers = await _followService.Get<List<FollowDto>>(new FollowSearchRequest() { FollowerId = _user.Id });
            var recipes = await _recipeService.Get<List<RecipeDto>>(new RecipeSearchObject() {LoggedUserId=_user.Id, ByUsers=true });

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
    }
}
