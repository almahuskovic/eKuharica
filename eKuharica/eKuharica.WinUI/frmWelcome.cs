using System;
using eKuharica.WinUI.Recipes;
using System.Windows.Forms;
using eKuharica.WinUI.UserRecipes;
using eKuharica.WinUI.Users;
using eKuharica.WinUI.Articles;
using eKuharica.WinUI.Feedbacks;

namespace eKuharica.WinUI
{
    public partial class frmWelcome : Form
    {
        APIService _userService = new APIService("User");
        public frmWelcome()
        {
            InitializeComponent();

        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void tsbRecipes_Click(object sender, EventArgs e)
        {
            frmRecipes frmRecipes = new frmRecipes();
            frmRecipes.MdiParent = this;
            frmRecipes.WindowState = FormWindowState.Maximized;
            frmRecipes.Text = "eKuharica";
            frmRecipes.Show();
        }

        private void tsbUserRecipes_Click(object sender, EventArgs e)
        {
            frmUserRecipes frmRecipes = new frmUserRecipes();
            frmRecipes.MdiParent = this;
            frmRecipes.WindowState = FormWindowState.Maximized;
            frmRecipes.Text = "eKuharica";
            frmRecipes.Show();
        }

        private void tsbUsers_Click(object sender, EventArgs e)
        {
            frmUsers frmUsers = new frmUsers();
            frmUsers.MdiParent = this;
            frmUsers.WindowState = FormWindowState.Maximized;
            frmUsers.Text = "eKuharica";
            frmUsers.Show();
        }

        private void tsbArticles_Click(object sender, EventArgs e)
        {
            frmArticles frmArticles = new frmArticles();
            frmArticles.MdiParent = this;
            frmArticles.WindowState = FormWindowState.Maximized;
            frmArticles.Text = "eKuharica";
            frmArticles.Show();
        }

        private void tsbFeedbacks_Click(object sender, EventArgs e)
        {
            frmFeedbacks frmFeedbacks = new frmFeedbacks();
            frmFeedbacks.MdiParent = this;
            frmFeedbacks.WindowState = FormWindowState.Maximized;
            frmFeedbacks.Text = "eKuharica";
            frmFeedbacks.Show();
        }

        private void favouriteRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecipes frmRecipes = new frmRecipes(true);
            frmRecipes.MdiParent = this;
            frmRecipes.WindowState = FormWindowState.Maximized;
            frmRecipes.Text = "eKuharica";
            frmRecipes.Show();
        }

        private void followingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers frmUsers = new frmUsers(false,true);
            frmUsers.MdiParent = this;
            frmUsers.WindowState = FormWindowState.Maximized;
            frmUsers.Text = "eKuharica";
            frmUsers.Show();
        }

        private void followersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers frmUsers = new frmUsers(true, false);
            frmUsers.MdiParent = this;
            frmUsers.WindowState = FormWindowState.Maximized;
            frmUsers.Text = "eKuharica";
            frmUsers.Show();
        }

        private void sendRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddRecipes frmSendRecipe = new frmAddRecipes(null,null,false,true);
            frmSendRecipe.MdiParent = this;
            frmSendRecipe.WindowState = FormWindowState.Maximized;
            frmSendRecipe.Text = "eKuharica";
            frmSendRecipe.Show();
        }

        private void myRecipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecipes frmRecipes = new frmRecipes(false, true);
            frmRecipes.MdiParent = this;
            frmRecipes.WindowState = FormWindowState.Maximized;
            frmRecipes.Text = "eKuharica";
            frmRecipes.Show();
        }

        private async void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);
            frmAddUsers frmUsers = new frmAddUsers(user);
            frmUsers.MdiParent = this;
            frmUsers.WindowState = FormWindowState.Maximized;
            frmUsers.Text = "eKuharica";
            frmUsers.Show();
        }
    }
}
