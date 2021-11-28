using eKuharica.Model.DTO;
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
            var roleList= await _roleService.Get<List<RoleDto>>();
            clbRoles.DataSource = roleList;
            clbRoles.DisplayMember = "Name";
        }
    }
}
