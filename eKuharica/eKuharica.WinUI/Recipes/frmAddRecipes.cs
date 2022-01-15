using Azure.Core;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Enumerations;
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
        private bool _send;
        private string _frmSource;

        public frmAddRecipes(RecipeDto recipe = null, RecipeTranslationDto recipeTranslation = null, bool translate = false, bool send = false, string frmSource = "frmRecipe")
        {
            InitializeComponent();
            _recipe = recipe;
            _recipeTranslation = recipeTranslation;
            _translate = translate;
            _send = send;
            _frmSource = frmSource;
        }

        private void frmAddRecipes_Load(object sender, EventArgs e)
        {
            if (Helpers.Helper.CurrentLanguage == "bs")
            {
                cmbMealType.DataSource = Helpers.Helper.VrsteJelaToSelectList();
                cmbWeightOfPreparation.DataSource = Helpers.Helper.TezinaPripremeToSelectList();
            }
            else
            {
                cmbMealType.DataSource = Helpers.Helper.MealTypeToSelectList();
                cmbWeightOfPreparation.DataSource = Helpers.Helper.WeightOfPreparationToSelectList();
            }

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
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                errorProvider1.SetError(txtTitle, "Required");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtIngridients.Text))
            {
                errorProvider1.SetError(txtIngridients, "Required");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtMethod.Text))
            {
                errorProvider1.SetError(txtMethod, "Required");
                isValid = false;
            }
            if (!isValid)
                return;
            else
                errorProvider1.Clear();

            var loggedUserId = (await Helpers.Helper.GetLoggedUser(_userService, APIService.Username)).Id;

            RecipeTranslationUpsertRequest recipeTranslationRequest = new RecipeTranslationUpsertRequest();
            RecipeUpsertRequest recipeRequest = new RecipeUpsertRequest();

            recipeTranslationRequest.Title = recipeRequest.Title = txtTitle.Text;
            recipeTranslationRequest.Ingredients = recipeRequest.Ingredients = txtIngridients.Text;
            recipeTranslationRequest.Introduction = recipeRequest.Introduction = txtIntroduction.Text;
            recipeTranslationRequest.Method = recipeRequest.Method = txtMethod.Text;
            recipeTranslationRequest.Advice = recipeRequest.Advice = txtAdvice.Text;
            recipeTranslationRequest.Serving = recipeRequest.Serving = txtServing.Text;
            recipeRequest.Picture = Helpers.Helper.ImageToByteArray(pbCoverPicture.Image);
            //recipeRequest.UserId = loggedUserId;
            recipeRequest.IsTranslated = _recipeTranslation != null ? true : false;
            recipeRequest.IsRead = true;
            //recipeRequest.IsSent = _send ? _send : _recipe.IsSent;

            if (!(_recipe != null && _recipe.IsSent))
            {
                recipeRequest.IsSent = _send;
                recipeRequest.UserId = loggedUserId;
            }
            else
            {
                recipeRequest.IsSent = _recipe.IsSent;
                recipeRequest.UserId = _recipe.UserId;
            }

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
                    recipeTranslationRequest.RecipeId = _recipe.Id;

                    await _recipeService.Update<RecipeDto>(_recipe.Id, _recipe);
                    await _recipeTranslationService.Insert<RecipeTranslationDto>(recipeTranslationRequest);
                }
                else
                {
                    recipeRequest.IsApproved = _send ? false : true;
                    await _recipeService.Insert<RecipeDto>(recipeRequest);
                }
            }
            else //edit
            {
                //TODO:preklopiti funkciju za convert datetime u odredjenu kategoriju
                recipeRequest.IsApproved = _recipe.IsApproved;
                recipeTranslationRequest.RecipeId = _recipe.Id;

                if (_translate)
                {
                    await _recipeTranslationService.Update<RecipeTranslationDto>(_recipeTranslation.Id, recipeTranslationRequest);
                }
                else
                {
                    await _recipeService.Update<RecipeDto>(_recipe.Id, recipeRequest);
                }
            }

            MessageBox.Show("Uspješno ste izmijenili podatke o receptu");

            if ((int)Enum.Parse(typeof(Enumerations.RecipeAddSource), _frmSource) != (int)Enumerations.RecipeAddSource.frmUserRecipe)//   _recipe != null && !_recipe.IsSent)
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

        private void btnRecipePreview_Click(object sender, EventArgs e)
        {
            var recipe = new RecipeDto()
            {
                Advice = txtAdvice.Text,
                Method = txtMethod.Text,
                Ingredients = txtIngridients.Text,
                Introduction = txtIntroduction.Text,
                Picture = Helpers.Helper.ImageToByteArray(pbCoverPicture.Image),
                Serving = txtServing.Text,
                Title = txtTitle.Text,
                WeightOfPreparation = cmbWeightOfPreparation.SelectedIndex,
                MealType = cmbMealType.SelectedIndex,
                PreparationTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)nudPreparationTime.Value / 60, (int)nudPreparationTime.Value % 60, 0),
                AuthorUserName = APIService.Username
            };

            frmShowRecipes frmShowRecipe = new frmShowRecipes(recipe, Enum.GetName(typeof(Enumerations.Source),Enumerations.Source.Add));
            frmShowRecipe.MdiParent = MdiParent;
            frmShowRecipe.WindowState = FormWindowState.Maximized;
            frmShowRecipe.Show();
            Hide();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            if (_send)
            {
                Helpers.Helper.CloseAllOpenForms();
                return;
            }

            if ((int)Enum.Parse(typeof(Enumerations.RecipeAddSource), _frmSource) == (int)Enumerations.RecipeAddSource.frmUserRecipe)//_recipe !=null &&  !_recipe.IsSent)
            {
                frmUserRecipes frmUserRecipes = new frmUserRecipes();
                frmUserRecipes.MdiParent = MdiParent;
                frmUserRecipes.WindowState = FormWindowState.Maximized;
                frmUserRecipes.Show();
                Hide();
                return;
            }

            var myRecipes = (int)Enum.Parse(typeof(Enumerations.RecipeAddSource), _frmSource) == (int)Enumerations.RecipeAddSource.frmMyRecipes;
            var favRecipes = (int)Enum.Parse(typeof(Enumerations.RecipeAddSource), _frmSource) == (int)Enumerations.RecipeAddSource.frmFavRecipes;
            frmRecipes frmRecipes = new frmRecipes(favRecipes, myRecipes);
            frmRecipes.MdiParent = MdiParent;
            frmRecipes.WindowState = FormWindowState.Maximized;
            frmRecipes.Show();
            Hide();
        }
    }
}
