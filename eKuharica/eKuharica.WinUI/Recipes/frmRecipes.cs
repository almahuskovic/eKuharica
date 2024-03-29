﻿using System;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Enumerations;
using eKuharica.Model.Models;
using eKuharica.Model.Requests;
using Microsoft.SqlServer.Management.Sdk.Sfc;
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
    public partial class frmRecipes : Form
    {
        APIService _recipeService = new APIService("Recipe");
        APIService _recipeTranslationService = new APIService("RecipeTranslation");
        APIService _userService = new APIService("User");
        APIService _userFavouriteRecipeService = new APIService("UserFavouriteRecipe");
        private bool _isFavouriteRecipeList;
        private bool _myRecipes;
        public frmRecipes(bool isFav = false, bool myRecipes = false)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Helpers.Helper.CurrentLanguage);

            InitializeComponent();
            sdgvRecipes.AutoGenerateColumns = false;
            gbExtraFilters.Visible = false;
            _isFavouriteRecipeList = isFav;
            _myRecipes = myRecipes;

            if (Helpers.Helper.CurrentLanguage == "bs")
            {
                cmbMealType.DataSource = Helpers.Helper.VrsteJelaToSelectList();
                cmbWeightOfPreparation.DataSource = Helpers.Helper.TezinaPripremeToSelectList();
                cmbPreparationTime.DataSource = Helpers.Helper.VrijemePripremeKategorijeToSelectList();
            }
            else
            {
                cmbMealType.DataSource = Helpers.Helper.MealTypeToSelectList();
                cmbWeightOfPreparation.DataSource = Helpers.Helper.WeightOfPreparationToSelectList();
                cmbPreparationTime.DataSource = Helpers.Helper.PreparationTimeCategoryToSelectList();
            }


            if(_isFavouriteRecipeList)
            {
                btnNewRecipe.Visible = false;

                sdgvRecipes.Columns["Prevedi"].Visible = sdgvRecipes.Columns["Prevod"].Visible = 
                sdgvRecipes.Columns["Uredi"].Visible = sdgvRecipes.Columns["Obrisi"].Visible = false;
            }
        }

        private void LoadData(List<RecipeDto> data)
        {
            if (!data.Any())
                sdgvRecipes.DataSource = null;
            else
            {
                sdgvRecipes.DataSource = data;
                Helpers.Helper.TranslationForDgvButtons(this, sdgvRecipes);

                sdgvRecipes.PageSize = 10;
                DataTable dt = Helpers.Helper.ToDataTable(data);
                sdgvRecipes.SetPagedDataSource(dt, bindingNavigator1);
            }
        }
        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var loggedUser = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);
            RecipeSearchObject request = new RecipeSearchObject()
            {
                Title = txtSearch.Text,
                MealType = cmbMealType.SelectedIndex > 0 ? (int?)cmbMealType.SelectedIndex : null,
                PreparationTimeCategory = cmbPreparationTime.SelectedIndex > 0 ? (int?)cmbPreparationTime.SelectedIndex : null,
                WeightOfPreparation = cmbWeightOfPreparation.SelectedIndex > 0 ? (int?)cmbWeightOfPreparation.SelectedIndex : null,
                MyRecipes = _myRecipes,
                LoggedUserId = loggedUser.Id,
                LoggedUserHasPermissions =  Helpers.Helper.IsAdminOrEmployee(loggedUser)
            };

            var data = await _recipeService.Get<List<RecipeDto>>(request);
            LoadData(data);
        }

        private async void frmRecipes_Load(object sender, EventArgs e)
        {
            var loggedUser = (await Helpers.Helper.GetLoggedUser(_userService, APIService.Username));

            var data = new List<RecipeDto>();
            var searchObj = new RecipeSearchObject() {
                LoggedUserId = loggedUser.Id, 
                MyRecipes = _myRecipes ,
                LoggedUserHasPermissions = Helpers.Helper.IsAdminOrEmployee(loggedUser)
            };

            if (_isFavouriteRecipeList)
            {
                var searchRequest = new UserFavouriteRecipeSearchRequest() { 
                    UserId = loggedUser.Id
                };

                searchObj.RecipeIds = (await _userFavouriteRecipeService.Get<List<UserFavouriteRecipeDto>>(searchRequest))
                    .Where(x => !x.IsDeleted)
                    .Select(x => x.RecipeId)
                    .ToList();
                searchObj.IsFavouriteRecipeSearch = true;
            }

            data = await _recipeService.Get<List<RecipeDto>>(searchObj);
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

        private async void sdgvRecipes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var currentRow = bindingNavigator1.BindingSource.Current as DataTable;
                //TODO:mozda ce trebati dodati 1 na index
                var elementIndex = (currentRow.Rows.Count / 10) <= 1 ? e.RowIndex : (currentRow.Rows.Count / 10) * 10 + e.RowIndex;
                var selectedRow = Helpers.Helper.CreateItemFromRow<RecipeDto>(currentRow.Rows[elementIndex]);

                var searchR = new RecipeTranslationSearchRequest() { RecipeId = selectedRow.Id };
                var recipeTranslation = await _recipeTranslationService.Get<List<RecipeTranslationDto>>(searchR);
                var _recipeTranslation = recipeTranslation.Any() ? recipeTranslation.First() : null;

                var user = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);

                if (!Helpers.Helper.IsAdministrator(user) && !selectedRow.IsCreatedByLoggedUser &&
                    (e.ColumnIndex == 2 || e.ColumnIndex == 4 || e.ColumnIndex == 5))
                {
                    MessageBox.Show("Nemate permisije");
                    return;
                }

                if (e.ColumnIndex == 2)//prevod
                {
                    frmAddRecipes frmEditRecipe = new frmAddRecipes(selectedRow, _recipeTranslation, true, false, RecipeAddSource.frmRecipe.ToString());
                    frmEditRecipe.MdiParent = MdiParent;
                    frmEditRecipe.WindowState = FormWindowState.Maximized;
                    frmEditRecipe.Show();
                    Hide();
                }
                if (e.ColumnIndex == 3) //prikazi
                {
                    var source = _isFavouriteRecipeList ?
                        Enum.GetName(typeof(Source), Source.Other) :
                        Enum.GetName(typeof(Source), Source.Index);

                    frmShowRecipes frmShowRecipe = new frmShowRecipes(selectedRow, source);
                    frmShowRecipe.MdiParent = MdiParent;
                    frmShowRecipe.WindowState = FormWindowState.Maximized;
                    frmShowRecipe.Show();
                    Hide();
                }
                if (e.ColumnIndex == 4)//edit
                {
                    var source = _myRecipes ? RecipeAddSource.frmMyRecipes.ToString() : (_isFavouriteRecipeList ? RecipeAddSource.frmFavRecipes.ToString() : RecipeAddSource.frmRecipe.ToString());
                    frmAddRecipes frmEditRecipe = new frmAddRecipes(selectedRow, _recipeTranslation, false, false, source);
                    frmEditRecipe.MdiParent = MdiParent;
                    frmEditRecipe.WindowState = FormWindowState.Maximized;
                    frmEditRecipe.Show();
                    Hide();
                }
                if (e.ColumnIndex == 5)//brisanje
                {
                    if (await _recipeService.Delete<RecipeDto>(selectedRow.Id))
                        txtSearch_TextChanged(sender,e);
                }
            }
        }

    }
}
