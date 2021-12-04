using Azure.Core;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;
using eKuharica.WinUI.Properties;
using eKuharica.WinUI.UserRecipes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKuharica.WinUI.Recipes
{
    public partial class frmAddRecipes : Form
    {
        APIService _recipeService = new APIService("Recipe");
        APIService _userService = new APIService("User");
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

            if (_recipe != null && !_translate)
            {
                txtTitle.Text = _recipe.Title;
                txtIntroduction.Text = _recipe.Introduction;
                txtIngridients.Text = _recipe.Ingredients;
                txtAdvice.Text = _recipe.Advice;
                txtMethod.Text = _recipe.Method;
                txtServing.Text = _recipe.Serving;
                pbCoverPicture.Image = Helpers.Helper.ByteArrayToImage(_recipe.Picture);
                cmbMealType.SelectedIndex = _recipe.MealType;
                cmbWeightOfPreparation.SelectedIndex = _recipe.WeightOfPreparation;
                nudPreparationTime.Value = int.Parse((_recipe.PreparationTime.Hour * 60 + _recipe.PreparationTime.Minute).ToString());
            }
            else if (_recipeTranslation != null)
            {
                txtTitle.Text = _recipeTranslation.Title;
                txtIntroduction.Text = _recipeTranslation.Introduction;
                txtIngridients.Text = _recipeTranslation.Ingredients;
                txtAdvice.Text = _recipeTranslation.Advice;
                txtMethod.Text = _recipeTranslation.Method;
                txtServing.Text = _recipeTranslation.Serving;

            }

            if(_translate)
                gbTags.Hide();

            #region Translations

            #endregion
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        { 
            var loggedUser = (await _userService.Get<List<UserDto>>(new UserSearchRequest() { UserName = APIService.Username }));
            var userId = loggedUser.FirstOrDefault().Id;

            RecipeTranslationUpsertRequest recipeTranslationRequest = new RecipeTranslationUpsertRequest();
            RecipeUpsertRequest recipeRequest = new RecipeUpsertRequest();

            recipeTranslationRequest.Title = recipeRequest.Title = txtTitle.Text;
            recipeTranslationRequest.Ingredients = recipeRequest.Ingredients = txtIngridients.Text;
            recipeTranslationRequest.Introduction = recipeRequest.Introduction = txtIntroduction.Text;
            recipeTranslationRequest.Method = recipeRequest.Method = txtMethod.Text;
            recipeTranslationRequest.Advice = recipeRequest.Advice = txtAdvice.Text;
            recipeTranslationRequest.Serving = recipeRequest.Serving = txtServing.Text;
            recipeRequest.Picture = Helpers.Helper.ImageToByteArray(pbCoverPicture.Image);
            recipeRequest.UserId = userId;//logovanog uzimati
            recipeRequest.IsTranslated = _recipeTranslation != null ? true : false;
            recipeTranslationRequest.RecipeId = _recipe.Id;
            recipeRequest.IsRead = true;
            recipeRequest.IsSent = _recipe.IsSent;
            recipeRequest.IsApproved = _recipe.IsApproved;

            if (!_translate) //dodijeli parametre ako je otvoren recept
            {
                recipeRequest.MealType = cmbMealType.SelectedIndex;
                recipeRequest.WeightOfPreparation = cmbWeightOfPreparation.SelectedIndex;
                recipeRequest.PreparationTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)nudPreparationTime.Value / 60, (int)nudPreparationTime.Value % 60, 0);
            }

            if (_recipe == null || (_recipeTranslation == null && _translate))//add
            {
                if (_translate)
                {
                    _recipe.IsTranslated = true;
                    
                    await _recipeService.Update<RecipeDto>(_recipe.Id, _recipe);
                    await _recipeTranslationService.Insert<RecipeTranslationDto>(recipeTranslationRequest);
                }
                else
                {
                    recipeRequest.IsApproved = true;
                    await _recipeService.Insert<RecipeDto>(recipeRequest);
                }
            }
            else //edit
            {
                //TODO:preklopiti funkciju za convert datetime u odredjenu kategoriju

                if (_translate)
                {
                    await _recipeTranslationService.Update<RecipeTranslationDto>(_recipeTranslation.Id, recipeTranslationRequest);
                }
                else
                {
                    await _recipeService.Update<RecipeDto>(_recipe.Id, recipeRequest);
                }
            }

            if (!_recipe.IsSent)
            {
                frmRecipes frmRecipes = new frmRecipes();
                frmRecipes.MdiParent = MdiParent;
                frmRecipes.WindowState = FormWindowState.Maximized;
                frmRecipes.Show();
                Hide();
            }
            else
            {
                frmUserRecipes frmUserRecipes = new frmUserRecipes();
                frmUserRecipes.MdiParent = MdiParent;
                frmUserRecipes.WindowState = FormWindowState.Maximized;
                frmUserRecipes.Show();
                Hide();
            } 
        }

        private void pbCoverPicture_Click(object sender, EventArgs e)
        {
            var result = ofdPicture.ShowDialog();

            if(result == DialogResult.OK)
            {
                var fileName = ofdPicture.FileName;
                var file = File.ReadAllBytes(fileName);

                pbCoverPicture.Image = Image.FromFile(fileName);
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            if (!_recipe.IsSent)
            {
                frmUserRecipes frmUserRecipes = new frmUserRecipes();
                frmUserRecipes.MdiParent = MdiParent;
                frmUserRecipes.WindowState = FormWindowState.Maximized;
                frmUserRecipes.Show();
                Hide();
                //return;
            }

            frmRecipes frmRecipes = new frmRecipes();
            frmRecipes.MdiParent = MdiParent;
            frmRecipes.WindowState = FormWindowState.Maximized;
            frmRecipes.Show();
            Hide();
        }
    }
}
