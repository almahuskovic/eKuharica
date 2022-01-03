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
    public partial class frmReports : Form
    {
        APIService _recipeRatingService = new APIService("UserRecipeRating");
        private bool _isRecipeRating;
        public frmReports(bool isRecipeRating = false)
        {
            InitializeComponent();
            _isRecipeRating = isRecipeRating;
        }

        private async void frmReports_Load(object sender, EventArgs e)
        {
            if (_isRecipeRating)
            {
                var data = await _recipeRatingService.Get<IEnumerable<UserRecipeRatingDto>>(new UserRecipeRatingSearchRequest() { GetTop3 = true });
                var rds = new ReportDataSource();
                rds.Name = "dseKuharica";
                rds.Value = data;

                reportViewer1.LocalReport.DataSources.Add(rds);
            }
           
            reportViewer1.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
