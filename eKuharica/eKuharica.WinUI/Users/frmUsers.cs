using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
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
    public partial class frmUsers : Form
    {
        APIService _serviceUsers = new APIService("User");
        public frmUsers()
        {
            InitializeComponent();
            sdgvUsers.AutoGenerateColumns = false;
        }

        private async void frmUsers_Load(object sender, EventArgs e)
        {
            var data= await _serviceUsers.Get<List<UserDto>>();
            sdgvUsers.DataSource = data;//data.Where(x=>x.UserRoles.Contains())- hocu da displaya sve osim admina
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            UserSearchRequest request = new UserSearchRequest()
            {
                FirstName = txtSearch.Text,
                LastName = txtSearch.Text,
            };

            sdgvUsers.DataSource = await _serviceUsers.Get<List<UserDto>>(request);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUsers frmAddUsers = new frmAddUsers();
            frmAddUsers.MdiParent = MdiParent;
            frmAddUsers.WindowState = FormWindowState.Maximized;
            frmAddUsers.Show();
            Hide();
        }
    }
}
