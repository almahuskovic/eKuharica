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
            this.languageBatoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.languageENtoolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.prevediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bosanskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engleskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbRecipes = new System.Windows.Forms.ToolStripButton();
            this.tsbUserRecipes = new System.Windows.Forms.ToolStripButton();
            this.tsbUsers = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbArticles = new System.Windows.Forms.ToolStripButton();
            this.tsbFeedbacks = new System.Windows.Forms.ToolStripButton();
            this.tsbReports = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOuttoolStripMenuItem1,
            this.languageBatoolStripMenuItem2,
            this.prevediToolStripMenuItem});
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
            // languageBatoolStripMenuItem2
            // 
            this.languageBatoolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.languageBatoolStripMenuItem2, "languageBatoolStripMenuItem2");
            this.languageBatoolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.languageBatoolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageENtoolStripMenuItem3});
            this.languageBatoolStripMenuItem2.Name = "languageBatoolStripMenuItem2";
            this.languageBatoolStripMenuItem2.Padding = new System.Windows.Forms.Padding(0);
            // 
            // languageENtoolStripMenuItem3
            // 
            this.languageENtoolStripMenuItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.languageENtoolStripMenuItem3, "languageENtoolStripMenuItem3");
            this.languageENtoolStripMenuItem3.Name = "languageENtoolStripMenuItem3";
            // 
            // prevediToolStripMenuItem
            // 
            this.prevediToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bosanskiToolStripMenuItem,
            this.engleskiToolStripMenuItem});
            this.prevediToolStripMenuItem.Name = "prevediToolStripMenuItem";
            resources.ApplyResources(this.prevediToolStripMenuItem, "prevediToolStripMenuItem");
            // 
            // bosanskiToolStripMenuItem
            // 
            this.bosanskiToolStripMenuItem.Name = "bosanskiToolStripMenuItem";
            resources.ApplyResources(this.bosanskiToolStripMenuItem, "bosanskiToolStripMenuItem");
            // 
            // engleskiToolStripMenuItem
            // 
            this.engleskiToolStripMenuItem.Name = "engleskiToolStripMenuItem";
            resources.ApplyResources(this.engleskiToolStripMenuItem, "engleskiToolStripMenuItem");
            // 
            // toolStrip
            // 
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRecipes,
            this.tsbUserRecipes,
            this.tsbUsers,
            this.toolStripSeparator1,
            this.tsbArticles,
            this.tsbFeedbacks,
            this.tsbReports,
            this.toolStripSeparator2,
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
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
            // tsbReports
            // 
            resources.ApplyResources(this.tsbReports, "tsbReports");
            this.tsbReports.Name = "tsbReports";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
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
            // frmWelcome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbRecipes;
        private System.Windows.Forms.ToolStripButton tsbUserRecipes;
        private System.Windows.Forms.ToolStripButton tsbUsers;
        private System.Windows.Forms.ToolStripButton tsbArticles;
        private System.Windows.Forms.ToolStripButton tsbFeedbacks;
        private System.Windows.Forms.ToolStripButton tsbReports;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem logOuttoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem languageBatoolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem languageENtoolStripMenuItem3;
        private System.Windows.Forms.ToolStripDropDownButton tsbSettings;
        private System.Windows.Forms.ToolStripMenuItem favouriteRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem followingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem followersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myRecipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prevediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bosanskiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engleskiToolStripMenuItem;
    }
}



