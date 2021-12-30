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

namespace eKuharica.WinUI.Users
{
    public partial class frmUserDetails : Form
    {
        private UserDto _user;
        APIService _followService = new APIService("Follow");
        public frmUserDetails(UserDto user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Owner.Enabled = true;
            Hide();
        }

        private async void frmUserDetails_Load(object sender, EventArgs e)
        {
            if (_user != null)
            {
                var follows = await _followService.Get<List<FollowDto>>(new FollowSearchRequest() { UserId = _user.Id });
                var followers = await _followService.Get<List<FollowDto>>(new FollowSearchRequest() { FollowerId = _user.Id });

                lblFollowersValue.Text = followers.Count().ToString();
                lblFollowingValue.Text = follows.Count().ToString();
                lblCreatedAtValue.Text = _user.CreatedAt.ToShortDateString();
                lblUserName.Text = _user.FullName;
                pbUserProfilePicture.Image = _user.Picture != null ? Helpers.Helper.ByteArrayToImage(_user.Picture) : null;
            }
        }

        private void lblUserName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserProfile frmUserProfile = new frmUserProfile(_user);
            frmUserProfile.MdiParent = MdiParent;
            frmUserProfile.WindowState = FormWindowState.Maximized;
            frmUserProfile.Show();
            //Hide();
        }
    }
}
