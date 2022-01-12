using System;
using eKuharica.WinUI.Recipes;
using System.Windows.Forms;
using eKuharica.WinUI.UserRecipes;
using eKuharica.WinUI.Users;
using eKuharica.WinUI.Articles;
using eKuharica.WinUI.Feedbacks;
using eKuharica.Model.DTO;
using static eKuharica.Model.Enumerations.Enumerations;
using System.Collections.Generic;
using eKuharica.WinUI.Reports;
using System.Resources;
using System.Reflection;
using System.Threading;
using System.Globalization;
using eKuharica.Model.Enumerations;

namespace eKuharica.WinUI
{
    public partial class frmWelcome : Form
    {
        APIService _userService = new APIService("User");
        public frmWelcome(string language = "")
        {
            if (!string.IsNullOrWhiteSpace(language))
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
                Helpers.Helper.CurrentLanguage = language;
            }
            else
                Helpers.Helper.CurrentLanguage = "bs";

            InitializeComponent();
            tsbFeedbacks.Visible = tsdReports.Visible = false;
            cmbTranslations.DataSource = Enum.GetValues(typeof(Languages));
            cmbTranslations.SelectedIndex = Helpers.Helper.CurrentLanguage == "bs" ? (int)Languages.BA : (int)Languages.ENG;
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmWelcome_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            var user = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);

            if (Helpers.Helper.IsAdministrator(user))
                tsbFeedbacks.Visible = tsdReports.Visible = true;
        }

        private void tsbRecipes_Click(object sender, EventArgs e)
        {
            Helpers.Helper.CloseAllOpenForms();

            frmRecipes frmRecipes = new frmRecipes();
            frmRecipes.MdiParent = this;
            frmRecipes.WindowState = FormWindowState.Maximized;
            frmRecipes.Show();
        }

        private void tsbUserRecipes_Click(object sender, EventArgs e)
        {
            Helpers.Helper.CloseAllOpenForms();

            frmUserRecipes frmRecipes = new frmUserRecipes();
            frmRecipes.MdiParent = this;
            frmRecipes.WindowState = FormWindowState.Maximized;
            frmRecipes.Show();
        }

        private void tsbUsers_Click(object sender, EventArgs e)
        {
            Helpers.Helper.CloseAllOpenForms();

            frmUsers frmUsers = new frmUsers();
            frmUsers.MdiParent = this;
            frmUsers.WindowState = FormWindowState.Maximized;
            frmUsers.Show();
        }

        private void tsbArticles_Click(object sender, EventArgs e)
        {
            Helpers.Helper.CloseAllOpenForms();

            frmArticles frmArticles = new frmArticles();
            frmArticles.MdiParent = this;
            frmArticles.WindowState = FormWindowState.Maximized;
            frmArticles.Show();
        }

        private void tsbFeedbacks_Click(object sender, EventArgs e)
        {
            Helpers.Helper.CloseAllOpenForms();

            frmFeedbacks frmFeedbacks = new frmFeedbacks();
            frmFeedbacks.MdiParent = this;
            frmFeedbacks.WindowState = FormWindowState.Maximized;
            frmFeedbacks.Show();
        }

        private void favouriteRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.Helper.CloseAllOpenForms();

            frmRecipes frmRecipes = new frmRecipes(true);
            frmRecipes.MdiParent = this;
            frmRecipes.WindowState = FormWindowState.Maximized;
            frmRecipes.Show();
        }

        private void followingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.Helper.CloseAllOpenForms();

            frmUsers frmUsers = new frmUsers(false,true);
            frmUsers.MdiParent = this;
            frmUsers.WindowState = FormWindowState.Maximized;
            frmUsers.Show();
        }

        private void followersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.Helper.CloseAllOpenForms();

            frmUsers frmUsers = new frmUsers(true, false);
            frmUsers.MdiParent = this;
            frmUsers.WindowState = FormWindowState.Maximized;
            frmUsers.Show();
        }

        private void sendRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.Helper.CloseAllOpenForms();

            frmAddRecipes frmSendRecipe = new frmAddRecipes(null,null,false,true);
            frmSendRecipe.MdiParent = this;
            frmSendRecipe.WindowState = FormWindowState.Maximized;
            frmSendRecipe.Show();
        }

        private void myRecipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.Helper.CloseAllOpenForms();

            frmRecipes frmRecipes = new frmRecipes(false, true);
            frmRecipes.MdiParent = this;
            frmRecipes.WindowState = FormWindowState.Maximized;
            frmRecipes.Show();
        }

        private async void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.Helper.CloseAllOpenForms();

            var user = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);
            frmAddUsers frmUsers = new frmAddUsers(user);
            frmUsers.MdiParent = this;
            frmUsers.WindowState = FormWindowState.Maximized;
            frmUsers.Show();
        }

        private void logOuttoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void bestRankedRecipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.Helper.CloseAllOpenForms();

            frmTop3BestRatedRecipes bestRatedRecipes = new frmTop3BestRatedRecipes();
            bestRatedRecipes.MdiParent = this;
            bestRatedRecipes.WindowState = FormWindowState.Maximized;
            bestRatedRecipes.Show();
        }

        private void mostLikedRecipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.Helper.CloseAllOpenForms();

            frmReportsByMealType mostLikedRecipes = new frmReportsByMealType();
            mostLikedRecipes.MdiParent = this;
            mostLikedRecipes.WindowState = FormWindowState.Maximized;
            mostLikedRecipes.Show();
        }

        private void numberOfNewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.Helper.CloseAllOpenForms();

            frmNewUsersPerMonth newUsersPerMonths = new frmNewUsersPerMonth();
            newUsersPerMonths.MdiParent = this;
            newUsersPerMonths.WindowState = FormWindowState.Maximized;
            newUsersPerMonths.Show();
        }

        private void numberOfNewRecipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.Helper.CloseAllOpenForms();

            frmMealTypeRatio mealTypeRatio = new frmMealTypeRatio();
            mealTypeRatio.MdiParent = this;
            mealTypeRatio.WindowState = FormWindowState.Maximized;
            mealTypeRatio.Show();
        }

        private void cmbTranslations_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Sve što niste spasili bit će izgubljeno");
            if (r == DialogResult.OK)
            {
                Helpers.Helper.CloseAllOpenForms();
                Helpers.Helper.CurrentLanguage = Enum.GetName(typeof(Languages), cmbTranslations.SelectedIndex) == Enum.GetName(typeof(Languages), Languages.BA)
                    ? "bs" : "en";
                Hide();
                frmWelcome frmWelcome = new frmWelcome(Helpers.Helper.CurrentLanguage);
                frmWelcome.Show();
            }
        }
    }
}
