namespace eKuharica.WinUI
{
    partial class frmWelcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.logOuttoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbRecipes = new System.Windows.Forms.ToolStripButton();
            this.tsbUserRecipes = new System.Windows.Forms.ToolStripButton();
            this.tsbUsers = new System.Windows.Forms.ToolStripButton();
            this.tsbArticles = new System.Windows.Forms.ToolStripButton();
            this.tsbFeedbacks = new System.Windows.Forms.ToolStripButton();
            this.tsdReports = new System.Windows.Forms.ToolStripDropDownButton();
            this.bestRankedRecipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostLikedRecipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfNewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfNewRecipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.favouriteRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.followingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.followersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myRecipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmbTranslations = new System.Windows.Forms.ComboBox();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOuttoolStripMenuItem1});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // logOuttoolStripMenuItem1
            // 
            this.logOuttoolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.logOuttoolStripMenuItem1, "logOuttoolStripMenuItem1");
            this.logOuttoolStripMenuItem1.Name = "logOuttoolStripMenuItem1";
            this.logOuttoolStripMenuItem1.Click += new System.EventHandler(this.logOuttoolStripMenuItem1_Click);
            // 
            // toolStrip
            // 
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRecipes,
            this.tsbUserRecipes,
            this.tsbUsers,
            this.tsbArticles,
            this.tsbFeedbacks,
            this.tsdReports,
            this.tsbSettings});
            this.toolStrip.Name = "toolStrip";
            // 
            // tsbRecipes
            // 
            resources.ApplyResources(this.tsbRecipes, "tsbRecipes");
            this.tsbRecipes.Name = "tsbRecipes";
            this.tsbRecipes.Click += new System.EventHandler(this.tsbRecipes_Click);
            // 
            // tsbUserRecipes
            // 
            resources.ApplyResources(this.tsbUserRecipes, "tsbUserRecipes");
            this.tsbUserRecipes.Name = "tsbUserRecipes";
            this.tsbUserRecipes.Click += new System.EventHandler(this.tsbUserRecipes_Click);
            // 
            // tsbUsers
            // 
            resources.ApplyResources(this.tsbUsers, "tsbUsers");
            this.tsbUsers.Name = "tsbUsers";
            this.tsbUsers.Click += new System.EventHandler(this.tsbUsers_Click);
            // 
            // tsbArticles
            // 
            resources.ApplyResources(this.tsbArticles, "tsbArticles");
            this.tsbArticles.Name = "tsbArticles";
            this.tsbArticles.Click += new System.EventHandler(this.tsbArticles_Click);
            // 
            // tsbFeedbacks
            // 
            resources.ApplyResources(this.tsbFeedbacks, "tsbFeedbacks");
            this.tsbFeedbacks.Name = "tsbFeedbacks";
            this.tsbFeedbacks.Click += new System.EventHandler(this.tsbFeedbacks_Click);
            // 
            // tsdReports
            // 
            this.tsdReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestRankedRecipesToolStripMenuItem,
            this.mostLikedRecipesToolStripMenuItem,
            this.numberOfNewUsersToolStripMenuItem,
            this.numberOfNewRecipesToolStripMenuItem});
            resources.ApplyResources(this.tsdReports, "tsdReports");
            this.tsdReports.Name = "tsdReports";
            // 
            // bestRankedRecipesToolStripMenuItem
            // 
            this.bestRankedRecipesToolStripMenuItem.Name = "bestRankedRecipesToolStripMenuItem";
            resources.ApplyResources(this.bestRankedRecipesToolStripMenuItem, "bestRankedRecipesToolStripMenuItem");
            this.bestRankedRecipesToolStripMenuItem.Click += new System.EventHandler(this.bestRankedRecipesToolStripMenuItem_Click);
            // 
            // mostLikedRecipesToolStripMenuItem
            // 
            this.mostLikedRecipesToolStripMenuItem.Name = "mostLikedRecipesToolStripMenuItem";
            resources.ApplyResources(this.mostLikedRecipesToolStripMenuItem, "mostLikedRecipesToolStripMenuItem");
            this.mostLikedRecipesToolStripMenuItem.Click += new System.EventHandler(this.mostLikedRecipesToolStripMenuItem_Click);
            // 
            // numberOfNewUsersToolStripMenuItem
            // 
            this.numberOfNewUsersToolStripMenuItem.Name = "numberOfNewUsersToolStripMenuItem";
            resources.ApplyResources(this.numberOfNewUsersToolStripMenuItem, "numberOfNewUsersToolStripMenuItem");
            this.numberOfNewUsersToolStripMenuItem.Click += new System.EventHandler(this.numberOfNewUsersToolStripMenuItem_Click);
            // 
            // numberOfNewRecipesToolStripMenuItem
            // 
            this.numberOfNewRecipesToolStripMenuItem.Name = "numberOfNewRecipesToolStripMenuItem";
            resources.ApplyResources(this.numberOfNewRecipesToolStripMenuItem, "numberOfNewRecipesToolStripMenuItem");
            this.numberOfNewRecipesToolStripMenuItem.Click += new System.EventHandler(this.numberOfNewRecipesToolStripMenuItem_Click);
            // 
            // tsbSettings
            // 
            this.tsbSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favouriteRecipeToolStripMenuItem,
            this.followingToolStripMenuItem,
            this.followersToolStripMenuItem,
            this.myRecipesToolStripMenuItem,
            this.sendRecipeToolStripMenuItem,
            this.editProfileToolStripMenuItem});
            resources.ApplyResources(this.tsbSettings, "tsbSettings");
            this.tsbSettings.Name = "tsbSettings";
            // 
            // favouriteRecipeToolStripMenuItem
            // 
            this.favouriteRecipeToolStripMenuItem.Name = "favouriteRecipeToolStripMenuItem";
            resources.ApplyResources(this.favouriteRecipeToolStripMenuItem, "favouriteRecipeToolStripMenuItem");
            this.favouriteRecipeToolStripMenuItem.Click += new System.EventHandler(this.favouriteRecipeToolStripMenuItem_Click);
            // 
            // followingToolStripMenuItem
            // 
            this.followingToolStripMenuItem.Name = "followingToolStripMenuItem";
            resources.ApplyResources(this.followingToolStripMenuItem, "followingToolStripMenuItem");
            this.followingToolStripMenuItem.Click += new System.EventHandler(this.followingToolStripMenuItem_Click);
            // 
            // followersToolStripMenuItem
            // 
            this.followersToolStripMenuItem.Name = "followersToolStripMenuItem";
            resources.ApplyResources(this.followersToolStripMenuItem, "followersToolStripMenuItem");
            this.followersToolStripMenuItem.Click += new System.EventHandler(this.followersToolStripMenuItem_Click);
            // 
            // myRecipesToolStripMenuItem
            // 
            this.myRecipesToolStripMenuItem.Name = "myRecipesToolStripMenuItem";
            resources.ApplyResources(this.myRecipesToolStripMenuItem, "myRecipesToolStripMenuItem");
            this.myRecipesToolStripMenuItem.Click += new System.EventHandler(this.myRecipesToolStripMenuItem_Click);
            // 
            // sendRecipeToolStripMenuItem
            // 
            this.sendRecipeToolStripMenuItem.Name = "sendRecipeToolStripMenuItem";
            resources.ApplyResources(this.sendRecipeToolStripMenuItem, "sendRecipeToolStripMenuItem");
            this.sendRecipeToolStripMenuItem.Click += new System.EventHandler(this.sendRecipeToolStripMenuItem_Click);
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            resources.ApplyResources(this.editProfileToolStripMenuItem, "editProfileToolStripMenuItem");
            this.editProfileToolStripMenuItem.Click += new System.EventHandler(this.editProfileToolStripMenuItem_Click);
            // 
            // cmbTranslations
            // 
            resources.ApplyResources(this.cmbTranslations, "cmbTranslations");
            this.cmbTranslations.FormattingEnabled = true;
            this.cmbTranslations.Name = "cmbTranslations";
            this.cmbTranslations.SelectionChangeCommitted += new System.EventHandler(this.cmbTranslations_SelectionChangeCommitted);
            // 
            // frmWelcome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbTranslations);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmWelcome";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbRecipes;
        private System.Windows.Forms.ToolStripButton tsbUserRecipes;
        private System.Windows.Forms.ToolStripButton tsbUsers;
        private System.Windows.Forms.ToolStripButton tsbArticles;
        private System.Windows.Forms.ToolStripButton tsbFeedbacks;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem logOuttoolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton tsbSettings;
        private System.Windows.Forms.ToolStripMenuItem favouriteRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem followingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem followersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myRecipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsdReports;
        private System.Windows.Forms.ToolStripMenuItem bestRankedRecipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostLikedRecipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfNewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfNewRecipesToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbTranslations;
    }
}



