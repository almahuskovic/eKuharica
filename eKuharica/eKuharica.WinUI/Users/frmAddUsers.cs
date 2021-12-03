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

        public frmAddUsers()
        {
            InitializeComponent();
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
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var selectedRoles = clbRoles.CheckedItems.Cast<RoleDto>().Select(x => x.Id).ToList();

            UserInsertRequest userInsertRequest = new UserInsertRequest()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                Username = txtUserName.Text,
                Password = txtPassword.Text,
                PasswordConfirm = txtConfirmPassword.Text,
                Roles = selectedRoles,
                PhoneNumber = txtPhoneNumber.Text
            };

            await _userService.Insert<UserDto>(userInsertRequest);

            frmUsers frmUsers = new frmUsers();
            frmUsers.MdiParent = MdiParent;
            frmUsers.WindowState = FormWindowState.Maximized;
            frmUsers.Show();
            Hide();
        }
    }
}
