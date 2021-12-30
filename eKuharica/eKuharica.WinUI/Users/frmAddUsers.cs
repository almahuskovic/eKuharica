using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKuharica.WinUI.Users
{
    public partial class frmAddUsers : Form
    {
        APIService _roleService = new APIService("Role");
        APIService _userService = new APIService("User");
        private UserDto _user;
        public frmAddUsers(UserDto user = null)
        {
            InitializeComponent();
            _user = user;

            if (_user != null)
                gbRoles.Visible = gbPassword.Visible = false;
        }

        private void pbPicture_Click(object sender, EventArgs e)
        {
            var result = ofdPicture.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = ofdPicture.FileName;
                var file = File.ReadAllBytes(fileName);

                pbPicture.Image = Image.FromFile(fileName);
            }
        }

        private async void frmAddUsers_Load(object sender, EventArgs e)
        {
            var roleList = await _roleService.Get<List<RoleDto>>();
            clbRoles.DataSource = roleList;
            clbRoles.DisplayMember = "Name";

            if (_user != null)
            {
                txtFirstName.Text = _user.FirstName;
                txtLastName.Text = _user.LastName;
                txtPhoneNumber.Text = _user.PhoneNumber;
                txtEmail.Text = _user.Email;
                txtUserName.Text = _user.Username;
                pbPicture.Image = Helpers.Helper.ByteArrayToImage(_user.Picture);

                txtUserName.ReadOnly = true;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var selectedRoles = clbRoles.CheckedItems.Cast<RoleDto>().Select(x => x.Id).ToList();

            if (_user != null)
            {
                UserUpdateRequest userInsertRequest = new UserUpdateRequest()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    PasswordConfirm = txtConfirmPassword.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Picture = Helpers.Helper.ImageToByteArray(pbPicture.Image)
                };

                await _userService.Update<UserDto>(_user.Id, userInsertRequest);
            }
            else
            {
                var usernameValidation = await _userService.Get<List<UserDto>>(new UserSearchRequest() { UserName=txtUserName.Text});
                if (usernameValidation.Count > 0)
                {
                    DialogResult r = MessageBox.Show("Korisničko ime je zauzeto!");
                    if (r == DialogResult.OK)
                    {
                        txtUserName.Text = "";
                    }
                }
                else
                {
                    UserInsertRequest userInsertRequest = new UserInsertRequest()
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Email = txtEmail.Text,
                        Username = txtUserName.Text,
                        Password = txtPassword.Text,
                        PasswordConfirm = txtConfirmPassword.Text,
                        Roles = selectedRoles,
                        PhoneNumber = txtPhoneNumber.Text,
                        Picture = Helpers.Helper.ImageToByteArray(pbPicture.Image)
                    };

                    await _userService.Insert<UserDto>(userInsertRequest);
                }
            }
            MessageBox.Show("Uspješno ste spremili podatke o korisniku");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_user == null)
            {
                frmUsers frmUsers = new frmUsers();
                frmUsers.MdiParent = MdiParent;
                frmUsers.WindowState = FormWindowState.Maximized;
                frmUsers.Show();
            }

            Hide();
        }
    }
}
