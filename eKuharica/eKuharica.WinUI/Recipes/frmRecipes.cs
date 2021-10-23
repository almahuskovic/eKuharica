using eKuharica.Model.DTO;
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

namespace eKuharica.WinUI.Recipes
{
    public partial class frmRecipes : Form
    {
        APIService _serviceRecipe = new APIService("Recipe");
        private int childFormNumber = 0;
        public frmRecipes()
        {
            InitializeComponent();
            dgvRecipes.AutoGenerateColumns = false;
            gbExtraFilters.Visible = false;
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RecipeSearchObject request = new RecipeSearchObject()
            {
                Title = txtSearch.Text,
                MealType = cmbMealType.SelectedIndex < 0 ? (int?)cmbMealType.SelectedIndex : null,
                PreparationTimeCategory = cmbPreparationTime.SelectedIndex < 0 ? (int?)cmbPreparationTime.SelectedIndex : null,
                WeightOfPreparation = cmbWeightOfPreparation.SelectedIndex < 0 ? (int?)cmbWeightOfPreparation.SelectedIndex : null
            };

            dgvRecipes.DataSource = await _serviceRecipe.Get<List<RecipeDto>>(request);
        }

        private async void frmRecipes_Load(object sender, EventArgs e)
        {
            dgvRecipes.DataSource = await _serviceRecipe.Get<List<RecipeDto>>();
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            gbExtraFilters.Visible = !gbExtraFilters.Visible;
        }

        private void btnNewRecipe_Click(object sender, EventArgs e)
        {
            //ovo ne raadi, kako napraviti da otvori formu u mdi
            this.Hide();
            frmAddRecipes frmAddRecipes = new frmAddRecipes();
            frmAddRecipes.WindowState = FormWindowState.Maximized;
            frmAddRecipes.Text = "Window " + childFormNumber++;
            frmAddRecipes.Show();
        }
    }
}
