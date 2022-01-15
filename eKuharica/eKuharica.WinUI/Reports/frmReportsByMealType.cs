using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Enumerations;
using eKuharica.Model.Models;
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
        APIService _userFavouriteRecipeService = new APIService("UserFavouriteRecipe");
        private List<UserFavouriteRecipeDto> _data = null;
        public frmReportsByMealType()
        {
            InitializeComponent();
            dgvReportData.AutoGenerateColumns = false;

            #region localizer

            if (Helpers.Helper.CurrentLanguage == "bs")
            {
                lblChooseMealType.Text = "Vrsta jela:";
                lblNote.Text = "*Prvo odaberite vrstu jela da bi se prikazali podaci";
                btnPrint.Text = "Printaj";
                dgvReportData.Columns[0].HeaderText = "Recept";
                dgvReportData.Columns[1].HeaderText = "Broj lajkova";
            }
            else
            {
                lblChooseMealType.Text = "Meal type:";
                lblNote.Text = "*You must choose a meal type first";
                btnPrint.Text = "Print";
                dgvReportData.Columns[0].HeaderText = "Recipe";
                dgvReportData.Columns[1].HeaderText = "Number of likes";
            }

            #endregion
        }

        private void frmReportsByMealType_Load(object sender, EventArgs e)
        {
            if (Helpers.Helper.CurrentLanguage == "bs")
                cmbChooseMealType.DataSource = Helpers.Helper.VrsteJelaToSelectList();
            else
                cmbChooseMealType.DataSource = Helpers.Helper.MealTypeToSelectList();

            dgvReportData.DataSource = _data = null;
        }

        private async void cmbChooseMealType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = cmbChooseMealType.SelectedIndex > 0 ? (int?)cmbChooseMealType.SelectedIndex : null;

            var data = await _userFavouriteRecipeService.Get<List<UserFavouriteRecipeDto>>(new UserFavouriteRecipeSearchRequest()
            {
                DataForReport = true,
                MealTypeId = selectedIndex != null ? selectedIndex : null
            });

            dgvReportData.DataSource = _data = data;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmMostLikedRecipes bestRatedRecipes = new frmMostLikedRecipes(_data.Take(3).ToList());
            bestRatedRecipes.WindowState = FormWindowState.Maximized;
            bestRatedRecipes.MdiParent = MdiParent;
            bestRatedRecipes.Text = "eKuharica";
            bestRatedRecipes.Show();
        }
    }
}
