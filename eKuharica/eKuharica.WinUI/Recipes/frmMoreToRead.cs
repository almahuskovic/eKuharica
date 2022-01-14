using eKuharica.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eKuharica.Model.Enumerations.Enumerations;

namespace eKuharica.WinUI.Recipes
{
    public partial class frmMoreToRead : Form
    {
        private string _text;
        public frmMoreToRead(string text)
        {
            btnClose.Text = Helpers.Helper.TranslationForBtnBack();

            InitializeComponent();
            _text = text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Owner.Enabled = true;
            Hide();
        }

        private void frmMoreToRead_Load(object sender, EventArgs e)
        {
            rtbText.Text = _text;
        }
    }
}
