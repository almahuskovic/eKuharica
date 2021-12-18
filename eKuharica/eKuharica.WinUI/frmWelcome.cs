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
        public frmWelcome()
        {
            InitializeComponent();

        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
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
            frmRecipes frmRecipes = new frmRecipes();
            frmRecipes.MdiParent = this;
            frmRecipes.WindowState = FormWindowState.Maximized;
            frmRecipes.Text = "eKuharica";
            frmRecipes.Show();
        }
    }
}
