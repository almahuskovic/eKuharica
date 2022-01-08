using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
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
    public partial class frmTop3BestRatedRecipes : Form
    {
        APIService _recipeRatingService = new APIService("UserRecipeRating");
        public frmTop3BestRatedRecipes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private async void frmTop3BestRatedRecipes_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource();
            rds.Name = "dsRating";

            var data = await _recipeRatingService.Get<IEnumerable<UserRecipeRatingDto>>(new UserRecipeRatingSearchRequest() { GetTop3 = true });

            rds.Value = data;
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
