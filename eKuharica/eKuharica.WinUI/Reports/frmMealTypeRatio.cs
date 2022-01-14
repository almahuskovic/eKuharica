using eKuharica.Model.DTO;
using eKuharica.Model.Enumerations;
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
    public partial class frmMealTypeRatio : Form
    {
        APIService _recipeService = new APIService("Recipe");
        public frmMealTypeRatio()
        {
            InitializeComponent();
            btnClose.Text = Helpers.Helper.TranslationForBtnBack();
        }

        private async void frmMealTypeRatio_Load(object sender, EventArgs e)
        {
            var data = (await _recipeService.Get<List<RecipeDto>>())?.GroupBy(x => x.MealType).Select(x => new ReportDataByMealType()
            {
                Name = Enum.GetName(typeof(Enumerations.MealType), x.Key),
                CountOf = x.Count()
            }).ToList();

            var rds = new ReportDataSource();
            rds.Name = "dsRatio";
            rds.Value = data;
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
