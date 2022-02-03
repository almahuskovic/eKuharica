using eKuharica.Model.DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKuharica.WinUI.Reports
{
    public partial class frmMostLikedRecipes : Form
    {
        private List<UserFavouriteRecipeDto> _data = null;
        public frmMostLikedRecipes(List<UserFavouriteRecipeDto> data)
        {
            InitializeComponent();

            btnClose.Text = Helpers.Helper.TranslationForBtnBack();
            _data = data;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void frmMostLikedRecipes_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource();
            rds.Name = "dsLikes";
            rds.Value = _data;
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
