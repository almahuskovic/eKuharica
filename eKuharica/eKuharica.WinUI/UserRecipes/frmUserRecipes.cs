using eKuharica.Model.DTO;
using eKuharica.Model.Enumerations;
using eKuharica.Model.Models;
using eKuharica.Model.Requests;
using eKuharica.WinUI.Recipes;
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

namespace eKuharica.WinUI.UserRecipes
{
    public partial class frmUserRecipes : Form
    {
        APIService _recipeService = new APIService("Recipe");
        APIService _userService = new APIService("User");
        public frmUserRecipes()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Helpers.Helper.CurrentLanguage);

            InitializeComponent();
            sdgvUserRecipes.AutoGenerateColumns = false;
        }

        private void frmUserRecipes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            var loggedUser = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);

            var request = new RecipeSearchObject() { ByUsers = true, LoggedUserHasPermissions= Helpers.Helper.IsAdminOrEmployee(loggedUser) };
            var data = await _recipeService.Get<List<RecipeDto>>(request);

            if (!data.Any())
                sdgvUserRecipes.DataSource = null;
            else
            {
                sdgvUserRecipes.DataSource = data;
                sdgvUserRecipes.PageSize = 10;
                DataTable dt = Helpers.Helper.ToDataTable(data);
                sdgvUserRecipes.SetPagedDataSource(dt, bindingNavigator1);
            }
        }

        private async void sdgvUserRecipes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = bindingNavigator1.BindingSource.Current as DataTable;
            var elementIndex = (currentRow.Rows.Count / 10) <= 1 ? e.RowIndex : (currentRow.Rows.Count / 10) * 10 + e.RowIndex;
            var selectedRow = Helpers.Helper.CreateItemFromRow<RecipeDto>(currentRow.Rows[elementIndex]);

            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 1)//odobri
                {
                    selectedRow.IsApproved = true;
                    await _recipeService.Update<RecipeDto>(selectedRow.Id, selectedRow);
                    LoadData();
                }
                else if (e.ColumnIndex == 2)//uredi
                {
                    frmAddRecipes frmEditRecipe = new frmAddRecipes(selectedRow, null, false,false,Enumerations.RecipeAddSource.frmUserRecipe.ToString());
                    frmEditRecipe.MdiParent = MdiParent;
                    frmEditRecipe.WindowState = FormWindowState.Maximized;
                    frmEditRecipe.Show();
                    Hide();
                }
                else if (e.ColumnIndex == 3)//brisanje
                {
                    if (await _recipeService.Delete<RecipeDto>(selectedRow.Id))
                        LoadData();
                }
            }
        }
    }
}
