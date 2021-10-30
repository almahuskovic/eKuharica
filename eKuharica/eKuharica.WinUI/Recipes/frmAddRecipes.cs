using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;
using eKuharica.WinUI.Properties;
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
    public partial class frmAddRecipes : Form
    {
        APIService _recipeService = new APIService("Recipe");

        private RecipeDto _recipe;

        public frmAddRecipes(RecipeDto recipe = null)
        {
            InitializeComponent();
            _recipe = recipe;
        }

        private void frmAddRecipes_Load(object sender, EventArgs e)
        {
            cmbMealType.DataSource = Helpers.Helper.MealTypeToSelectList();
            cmbWeightOfPreparation.DataSource = Helpers.Helper.WeightOfPreparationToSelectList();

            if (_recipe != null)
            {
                txtTitle.Text = _recipe.Title;
                txtIntroduction.Text = _recipe.Introduction;
                txtIngridients.Text = _recipe.Ingredients;
                txtAdvice.Text = _recipe.Advice;
                txtMethod.Text = _recipe.Method;
                txtServing.Text = _recipe.Serving;
                cmbMealType.SelectedValue = _recipe.MealType;
                cmbWeightOfPreparation.SelectedValue = _recipe.WeightOfPreparation;
                nudPreparationTime.Value = int.Parse(_recipe.PreparationTime.ToString());
            }

            #region Translations
            
            #endregion
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_recipe == null)//add
            {
                RecipeInsertRequest request = new RecipeInsertRequest()
                {
                    Title = txtTitle.Text,
                    Ingredients = txtIngridients.Text,
                    Introduction = txtIntroduction.Text,
                    Method = txtMethod.Text,
                    Advice = txtAdvice.Text,
                    Serving = txtServing.Text,
                    MealType = cmbMealType.SelectedIndex,
                    //PreparationTime= new TimeSpan(nudPreparationTime.Value),
                    WeightOfPreparation = cmbWeightOfPreparation.SelectedIndex,
                };

                await _recipeService.Insert<RecipeDto>(request);
            }
            else //edit
            {
                RecipeUpdateRequest request = new RecipeUpdateRequest()
                {
                    Title = txtTitle.Text,
                    Ingredients = txtIngridients.Text,
                    Introduction = txtIntroduction.Text,
                    Method = txtMethod.Text,
                    Advice = txtAdvice.Text,
                    Serving = txtServing.Text,
                    MealType = cmbMealType.SelectedIndex,
                    //PreparationTime= new TimeSpan(nudPreparationTime.Value),
                    WeightOfPreparation = cmbWeightOfPreparation.SelectedIndex,
                };

                await _recipeService.Update<RecipeDto>(_recipe.Id, request);
            }
        }
    }
}
