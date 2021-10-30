﻿using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Models;
using eKuharica.Model.Requests;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eKuharica.Model.Enumerations.Enumerations;

namespace eKuharica.WinUI.Recipes
{
    public partial class frmRecipes : Form
    {
        APIService _recipeService = new APIService("Recipe");
        private int childFormNumber = 0;
       
        public frmRecipes()
        {
            InitializeComponent();
            sdgvRecipes.AutoGenerateColumns = false;
            gbExtraFilters.Visible = false;

            cmbMealType.DataSource = Helpers.Helper.MealTypeToSelectList();
            cmbPreparationTime.DataSource = Helpers.Helper.PreparationTimeCategoryToSelectList();
            cmbWeightOfPreparation.DataSource = Helpers.Helper.WeightOfPreparationToSelectList();
        }

        private void LoadData(List<RecipeDto> data)
        {
            if (!data.Any())
                sdgvRecipes.DataSource = null;
            else
            {
                sdgvRecipes.PageSize = 10;
                DataTable dt = Helpers.Helper.ToDataTable(data);
                sdgvRecipes.SetPagedDataSource(dt, bindingNavigator1);
            }
        }
        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RecipeSearchObject request = new RecipeSearchObject()
            {
                Title = txtSearch.Text,
                MealType = cmbMealType.SelectedIndex > 0 ? (int?)cmbMealType.SelectedIndex : null,
                PreparationTimeCategory = cmbPreparationTime.SelectedIndex > 0 ? (int?)cmbPreparationTime.SelectedIndex : null,
                WeightOfPreparation = cmbWeightOfPreparation.SelectedIndex > 0 ? (int?)cmbWeightOfPreparation.SelectedIndex : null
            };

            var data = await _recipeService.Get<List<RecipeDto>>(request);
            LoadData(data);
        }

        private async void frmRecipes_Load(object sender, EventArgs e)
        {
            var data = await _recipeService.Get<List<RecipeDto>>();
            LoadData(data);
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            gbExtraFilters.Visible = !gbExtraFilters.Visible;

            if (!gbExtraFilters.Visible)
            {
                cmbMealType.SelectedIndex = cmbPreparationTime.SelectedIndex = cmbWeightOfPreparation.SelectedIndex = 0;
                txtSearch_TextChanged(sender, e);
            }
        }

        private void btnNewRecipe_Click(object sender, EventArgs e)
        {
            Hide();
            frmAddRecipes frmAddRecipes = new frmAddRecipes();
            frmAddRecipes.MdiParent = MdiParent;
            frmAddRecipes.WindowState = FormWindowState.Maximized;
            frmAddRecipes.Text = "Window " + childFormNumber++;
            frmAddRecipes.Show();
        }

        private void cmbMealType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gbExtraFilters.Visible)
                txtSearch_TextChanged(sender, e);
        }

        private void cmbWeightOfPreparation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gbExtraFilters.Visible)
                txtSearch_TextChanged(sender, e);
        }

        private void cmbPreparationTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gbExtraFilters.Visible)
                txtSearch_TextChanged(sender, e);
        }

        private void sdgvRecipes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var see = sdgvRecipes.SelectedRows[0];
                var item = see.DataBoundItem as RecipeDto;

                if (e.ColumnIndex == 2)
                {
                    //prevod
                }
                if (e.ColumnIndex == 3)
                {
                    //prikazi
                }
                if (e.ColumnIndex == 4)//edit
                {
                    frmAddRecipes frmEditRecipe = new frmAddRecipes(item as RecipeDto);
                    frmEditRecipe.MdiParent = MdiParent;
                    frmEditRecipe.WindowState = FormWindowState.Maximized;
                    frmEditRecipe.Show();
                    Hide();
                }
                if (e.ColumnIndex == 5)
                {
                    //brisanje
                }
            }
        }
    }
}
