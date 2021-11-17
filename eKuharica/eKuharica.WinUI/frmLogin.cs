using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKuharica.WinUI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _aPIService = new APIService("User");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;

            try
            {
                //nemam pojma cemu bi ovo trebalo da sluzi
                //var result = await _aPIService.Get<List<UserDto>>();

                frmWelcome frm = new frmWelcome();
                frm.Show();
                Hide();
            }
            catch
            {
                MessageBox.Show("Pogrešan username ili password");
            }
        }
    }
}
