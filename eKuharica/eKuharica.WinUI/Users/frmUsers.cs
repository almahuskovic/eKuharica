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
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            UserSearchRequest request = new UserSearchRequest()
            {
                FirstName = txtFirstName.Text
            };
            dgvUsers.DataSource = await _serviceUsers.Get<List<UserDto>>(request);
        }

        private async void frmUsers_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = await _serviceUsers.Get<List<UserDto>>();
        }
    }
}
