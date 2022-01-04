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

namespace eKuharica.WinUI.Reports
{
    public partial class frmReportsByMealType : Form
    {
        APIService _recipeService = new APIService("Recipe");
        APIService _userFavouriteRecipeService = new APIService("UserFavouriteRecipe");
        private bool _byLikes;
        private List<UserFavouriteRecipeDto> _data=null;
        public frmReportsByMealType(bool byLikes = false)
        {
            InitializeComponent();
            _byLikes = byLikes;
            dgvReportData.AutoGenerateColumns = false;
        }

        private void frmReportsByMealType_Load(object sender, EventArgs e)
        {
            cmbChooseMealType.DataSource = Helpers.Helper.MealTypeToSelectList();
            dgvReportData.DataSource = _data = null;
        }

        private async void cmbChooseMealType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = cmbChooseMealType.SelectedIndex > 0 ? (int?)cmbChooseMealType.SelectedIndex : null;
            var data = await _userFavouriteRecipeService.Get<List<UserFavouriteRecipeDto>>(new UserFavouriteRecipeSearchRequest() {
                DataForReport = true,
                MealTypeId = selectedIndex != null ? selectedIndex : null
            });
    
            dgvReportData.DataSource = _data = data;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReports bestRatedRecipes = new frmReports(false, _data.Take(3).ToList());
            bestRatedRecipes.WindowState = FormWindowState.Maximized;
            bestRatedRecipes.MdiParent = MdiParent;
            bestRatedRecipes.Text = "eKuharica";
            bestRatedRecipes.Show();
        }
    }
}
