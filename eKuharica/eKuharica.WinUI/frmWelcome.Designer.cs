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
            this.tsmiTranslate = new System.Windows.Forms.ToolStripMenuItem();
            this.bosanskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engleskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOuttoolStripMenuItem1,
            this.tsmiTranslate});
            this.menuStrip.Name = "menuStrip";
            this.toolTip.SetToolTip(this.menuStrip, resources.GetString("menuStrip.ToolTip"));
            // 
            // logOuttoolStripMenuItem1
            // 
            resources.ApplyResources(this.logOuttoolStripMenuItem1, "logOuttoolStripMenuItem1");
            this.logOuttoolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOuttoolStripMenuItem1.Name = "logOuttoolStripMenuItem1";
            this.logOuttoolStripMenuItem1.Click += new System.EventHandler(this.logOuttoolStripMenuItem1_Click);
            // 
            // tsmiTranslate
            // 
            resources.ApplyResources(this.tsmiTranslate, "tsmiTranslate");
            this.tsmiTranslate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiTranslate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bosanskiToolStripMenuItem,
            this.engleskiToolStripMenuItem});
            this.tsmiTranslate.Name = "tsmiTranslate";
            // 
            // bosanskiToolStripMenuItem
            // 
            resources.ApplyResources(this.bosanskiToolStripMenuItem, "bosanskiToolStripMenuItem");
            this.bosanskiToolStripMenuItem.Name = "bosanskiToolStripMenuItem";
            this.bosanskiToolStripMenuItem.Click += new System.EventHandler(this.bosanskiToolStripMenuItem_Click);
            // 
            // engleskiToolStripMenuItem
            // 
            resources.ApplyResources(this.engleskiToolStripMenuItem, "engleskiToolStripMenuItem");
            this.engleskiToolStripMenuItem.Name = "engleskiToolStripMenuItem";
            this.engleskiToolStripMenuItem.Click += new System.EventHandler(this.engleskiToolStripMenuItem_Click);
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
            this.toolTip.SetToolTip(this.toolStrip, resources.GetString("toolStrip.ToolTip"));
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
            resources.ApplyResources(this.tsdReports, "tsdReports");
            this.tsdReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestRankedRecipesToolStripMenuItem,
            this.mostLikedRecipesToolStripMenuItem,
            this.numberOfNewUsersToolStripMenuItem,
            this.numberOfNewRecipesToolStripMenuItem});
            this.tsdReports.Name = "tsdReports";
            // 
            // bestRankedRecipesToolStripMenuItem
            // 
            resources.ApplyResources(this.bestRankedRecipesToolStripMenuItem, "bestRankedRecipesToolStripMenuItem");
            this.bestRankedRecipesToolStripMenuItem.Name = "bestRankedRecipesToolStripMenuItem";
            this.bestRankedRecipesToolStripMenuItem.Click += new System.EventHandler(this.bestRankedRecipesToolStripMenuItem_Click);
            // 
            // mostLikedRecipesToolStripMenuItem
            // 
            resources.ApplyResources(this.mostLikedRecipesToolStripMenuItem, "mostLikedRecipesToolStripMenuItem");
            this.mostLikedRecipesToolStripMenuItem.Name = "mostLikedRecipesToolStripMenuItem";
            this.mostLikedRecipesToolStripMenuItem.Click += new System.EventHandler(this.mostLikedRecipesToolStripMenuItem_Click);
            // 
            // numberOfNewUsersToolStripMenuItem
            // 
            resources.ApplyResources(this.numberOfNewUsersToolStripMenuItem, "numberOfNewUsersToolStripMenuItem");
            this.numberOfNewUsersToolStripMenuItem.Name = "numberOfNewUsersToolStripMenuItem";
            this.numberOfNewUsersToolStripMenuItem.Click += new System.EventHandler(this.numberOfNewUsersToolStripMenuItem_Click);
            // 
            // numberOfNewRecipesToolStripMenuItem
            // 
            resources.ApplyResources(this.numberOfNewRecipesToolStripMenuItem, "numberOfNewRecipesToolStripMenuItem");
            this.numberOfNewRecipesToolStripMenuItem.Name = "numberOfNewRecipesToolStripMenuItem";
            this.numberOfNewRecipesToolStripMenuItem.Click += new System.EventHandler(this.numberOfNewRecipesToolStripMenuItem_Click);
            // 
            // tsbSettings
            // 
            resources.ApplyResources(this.tsbSettings, "tsbSettings");
            this.tsbSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favouriteRecipeToolStripMenuItem,
            this.followingToolStripMenuItem,
            this.followersToolStripMenuItem,
            this.myRecipesToolStripMenuItem,
            this.sendRecipeToolStripMenuItem,
            this.editProfileToolStripMenuItem});
            this.tsbSettings.Name = "tsbSettings";
            // 
            // favouriteRecipeToolStripMenuItem
            // 
            resources.ApplyResources(this.favouriteRecipeToolStripMenuItem, "favouriteRecipeToolStripMenuItem");
            this.favouriteRecipeToolStripMenuItem.Name = "favouriteRecipeToolStripMenuItem";
            this.favouriteRecipeToolStripMenuItem.Click += new System.EventHandler(this.favouriteRecipeToolStripMenuItem_Click);
            // 
            // followingToolStripMenuItem
            // 
            resources.ApplyResources(this.followingToolStripMenuItem, "followingToolStripMenuItem");
            this.followingToolStripMenuItem.Name = "followingToolStripMenuItem";
            this.followingToolStripMenuItem.Click += new System.EventHandler(this.followingToolStripMenuItem_Click);
            // 
            // followersToolStripMenuItem
            // 
            resources.ApplyResources(this.followersToolStripMenuItem, "followersToolStripMenuItem");
            this.followersToolStripMenuItem.Name = "followersToolStripMenuItem";
            this.followersToolStripMenuItem.Click += new System.EventHandler(this.followersToolStripMenuItem_Click);
            // 
            // myRecipesToolStripMenuItem
            // 
            resources.ApplyResources(this.myRecipesToolStripMenuItem, "myRecipesToolStripMenuItem");
            this.myRecipesToolStripMenuItem.Name = "myRecipesToolStripMenuItem";
            this.myRecipesToolStripMenuItem.Click += new System.EventHandler(this.myRecipesToolStripMenuItem_Click);
            // 
            // sendRecipeToolStripMenuItem
            // 
            resources.ApplyResources(this.sendRecipeToolStripMenuItem, "sendRecipeToolStripMenuItem");
            this.sendRecipeToolStripMenuItem.Name = "sendRecipeToolStripMenuItem";
            this.sendRecipeToolStripMenuItem.Click += new System.EventHandler(this.sendRecipeToolStripMenuItem_Click);
            // 
            // editProfileToolStripMenuItem
            // 
            resources.ApplyResources(this.editProfileToolStripMenuItem, "editProfileToolStripMenuItem");
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Click += new System.EventHandler(this.editProfileToolStripMenuItem_Click);
            // 
            // frmWelcome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmWelcome";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
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
        private System.Windows.Forms.ToolStripMenuItem tsmiTranslate;
        private System.Windows.Forms.ToolStripMenuItem bosanskiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engleskiToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsdReports;
        private System.Windows.Forms.ToolStripMenuItem bestRankedRecipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostLikedRecipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfNewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfNewRecipesToolStripMenuItem;
    }
}



