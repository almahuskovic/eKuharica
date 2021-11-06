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
        APIService _recipeTranslationService = new APIService("RecipeTranslation");

        private RecipeDto _recipe;
        private RecipeTranslationDto _recipeTranslation;
        private bool _translate;

        public frmAddRecipes(RecipeDto recipe = null, RecipeTranslationDto recipeTranslation = null, bool translate = false)
        {
            InitializeComponent();
            _recipe = recipe;
            _recipeTranslation = recipeTranslation;
            _translate = translate;
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
                cmbMealType.SelectedIndex = _recipe.MealType;
                cmbWeightOfPreparation.SelectedIndex = _recipe.WeightOfPreparation;
                nudPreparationTime.Value = int.Parse((_recipe.PreparationTime.Hour * 60 + _recipe.PreparationTime.Minute).ToString());
            }
            if (_recipeTranslation != null)
            {
                txtTitle.Text = _recipeTranslation.Title;
                txtIntroduction.Text = _recipeTranslation.Introduction;
                txtIngridients.Text = _recipeTranslation.Ingredients;
                txtAdvice.Text = _recipeTranslation.Advice;
                txtMethod.Text = _recipeTranslation.Method;
                txtServing.Text = _recipeTranslation.Serving;

                gbTags.Hide();
            }
            #region Translations

            #endregion
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_recipe == null || _recipeTranslation == null)//add
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
                    PreparationTime = new DateTime((int)nudPreparationTime.Value / 60, (int)nudPreparationTime.Value % 60, 0),
                    WeightOfPreparation = cmbWeightOfPreparation.SelectedIndex,
                    IsTranslated = _translate
                    //UserId=
                };

                if (_translate)
                {
                    _recipe.IsTranslated = true;
                    await _recipeService.Update<RecipeDto>(_recipe.Id, _recipe);
                    await _recipeTranslationService.Insert<RecipeDto>(request);
                }
                else
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
                    //TODO:preklopiti funkciju za convert datetime u odredjenu kategoriju
                    PreparationTime = new DateTime((int)nudPreparationTime.Value / 60, (int)nudPreparationTime.Value % 60, 0),
                    WeightOfPreparation = cmbWeightOfPreparation.SelectedIndex,
                    //UserId= uzimanje logiranog
                };

                if (_translate)
                {
                    await _recipeTranslationService.Update<RecipeTranslationDto>(_recipeTranslation.Id, request);
                }
                else
                    await _recipeService.Update<RecipeDto>(_recipe.Id, request);
            }
            frmRecipes frmRecipes = new frmRecipes();
            frmRecipes.MdiParent = MdiParent;
            frmRecipes.WindowState = FormWindowState.Maximized;
            frmRecipes.Show();
            Hide();
        }
    }
}
