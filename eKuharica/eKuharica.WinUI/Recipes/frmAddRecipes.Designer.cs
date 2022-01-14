namespace eKuharica.WinUI.Recipes
{
    partial class frmAddRecipes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddRecipes));
            this.btnRecipePreview = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtIntroduction = new System.Windows.Forms.TextBox();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.pbCoverPicture = new System.Windows.Forms.PictureBox();
            this.lblCoverPicture = new System.Windows.Forms.Label();
            this.ofdPicture = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.lblPreparation = new System.Windows.Forms.Label();
            this.txtServing = new System.Windows.Forms.TextBox();
            this.lblServing = new System.Windows.Forms.Label();
            this.txtAdvice = new System.Windows.Forms.TextBox();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTags = new System.Windows.Forms.Label();
            this.lblPreparationTime = new System.Windows.Forms.Label();
            this.lblWeightOfPreparation = new System.Windows.Forms.Label();
            this.lblMealGroup = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.cmbWeightOfPreparation = new System.Windows.Forms.ComboBox();
            this.cmbMealType = new System.Windows.Forms.ComboBox();
            this.nudPreparationTime = new System.Windows.Forms.NumericUpDown();
            this.txtIngridients = new System.Windows.Forms.TextBox();
            this.gbTags = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreparationTime)).BeginInit();
            this.gbTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecipePreview
            // 
            resources.ApplyResources(this.btnRecipePreview, "btnRecipePreview");
            this.btnRecipePreview.Name = "btnRecipePreview";
            this.btnRecipePreview.UseVisualStyleBackColor = true;
            this.btnRecipePreview.Click += new System.EventHandler(this.btnRecipePreview_Click);
            // 
            // btnSubmit
            // 
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // txtTitle
            // 
            resources.ApplyResources(this.txtTitle, "txtTitle");
            this.txtTitle.Name = "txtTitle";
            // 
            // txtIntroduction
            // 
            resources.ApplyResources(this.txtIntroduction, "txtIntroduction");
            this.txtIntroduction.Name = "txtIntroduction";
            // 
            // lblIntroduction
            // 
            resources.ApplyResources(this.lblIntroduction, "lblIntroduction");
            this.lblIntroduction.Name = "lblIntroduction";
            // 
            // pbCoverPicture
            // 
            resources.ApplyResources(this.pbCoverPicture, "pbCoverPicture");
            this.pbCoverPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCoverPicture.Name = "pbCoverPicture";
            this.pbCoverPicture.TabStop = false;
            this.pbCoverPicture.Click += new System.EventHandler(this.pbCoverPicture_Click);
            // 
            // lblCoverPicture
            // 
            resources.ApplyResources(this.lblCoverPicture, "lblCoverPicture");
            this.lblCoverPicture.Name = "lblCoverPicture";
            // 
            // ofdPicture
            // 
            this.ofdPicture.FileName = "ofdPicture";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblIngredients
            // 
            resources.ApplyResources(this.lblIngredients, "lblIngredients");
            this.lblIngredients.Name = "lblIngredients";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // txtMethod
            // 
            resources.ApplyResources(this.txtMethod, "txtMethod");
            this.txtMethod.Name = "txtMethod";
            // 
            // lblPreparation
            // 
            resources.ApplyResources(this.lblPreparation, "lblPreparation");
            this.lblPreparation.Name = "lblPreparation";
            // 
            // txtServing
            // 
            resources.ApplyResources(this.txtServing, "txtServing");
            this.txtServing.Name = "txtServing";
            // 
            // lblServing
            // 
            resources.ApplyResources(this.lblServing, "lblServing");
            this.lblServing.Name = "lblServing";
            // 
            // txtAdvice
            // 
            resources.ApplyResources(this.txtAdvice, "txtAdvice");
            this.txtAdvice.Name = "txtAdvice";
            // 
            // lblAdvice
            // 
            resources.ApplyResources(this.lblAdvice, "lblAdvice");
            this.lblAdvice.Name = "lblAdvice";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // lblTags
            // 
            resources.ApplyResources(this.lblTags, "lblTags");
            this.lblTags.Name = "lblTags";
            // 
            // lblPreparationTime
            // 
            resources.ApplyResources(this.lblPreparationTime, "lblPreparationTime");
            this.lblPreparationTime.Name = "lblPreparationTime";
            // 
            // lblWeightOfPreparation
            // 
            resources.ApplyResources(this.lblWeightOfPreparation, "lblWeightOfPreparation");
            this.lblWeightOfPreparation.Name = "lblWeightOfPreparation";
            // 
            // lblMealGroup
            // 
            resources.ApplyResources(this.lblMealGroup, "lblMealGroup");
            this.lblMealGroup.Name = "lblMealGroup";
            // 
            // lblMin
            // 
            resources.ApplyResources(this.lblMin, "lblMin");
            this.lblMin.Name = "lblMin";
            // 
            // cmbWeightOfPreparation
            // 
            this.cmbWeightOfPreparation.FormattingEnabled = true;
            resources.ApplyResources(this.cmbWeightOfPreparation, "cmbWeightOfPreparation");
            this.cmbWeightOfPreparation.Name = "cmbWeightOfPreparation";
            // 
            // cmbMealType
            // 
            this.cmbMealType.FormattingEnabled = true;
            resources.ApplyResources(this.cmbMealType, "cmbMealType");
            this.cmbMealType.Name = "cmbMealType";
            // 
            // nudPreparationTime
            // 
            resources.ApplyResources(this.nudPreparationTime, "nudPreparationTime");
            this.nudPreparationTime.Name = "nudPreparationTime";
            // 
            // txtIngridients
            // 
            resources.ApplyResources(this.txtIngridients, "txtIngridients");
            this.txtIngridients.Name = "txtIngridients";
            // 
            // gbTags
            // 
            this.gbTags.Controls.Add(this.lblPreparationTime);
            this.gbTags.Controls.Add(this.lblTags);
            this.gbTags.Controls.Add(this.cmbMealType);
            this.gbTags.Controls.Add(this.nudPreparationTime);
            this.gbTags.Controls.Add(this.lblMealGroup);
            this.gbTags.Controls.Add(this.cmbWeightOfPreparation);
            this.gbTags.Controls.Add(this.lblMin);
            this.gbTags.Controls.Add(this.lblWeightOfPreparation);
            resources.ApplyResources(this.gbTags, "gbTags");
            this.gbTags.Name = "gbTags";
            this.gbTags.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblBack
            // 
            resources.ApplyResources(this.lblBack, "lblBack");
            this.lblBack.Name = "lblBack";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // frmAddRecipes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.gbTags);
            this.Controls.Add(this.txtIngridients);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtAdvice);
            this.Controls.Add(this.lblAdvice);
            this.Controls.Add(this.txtServing);
            this.Controls.Add(this.lblServing);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.lblPreparation);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCoverPicture);
            this.Controls.Add(this.pbCoverPicture);
            this.Controls.Add(this.txtIntroduction);
            this.Controls.Add(this.lblIntroduction);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnRecipePreview);
            this.Name = "frmAddRecipes";
            this.Load += new System.EventHandler(this.frmAddRecipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreparationTime)).EndInit();
            this.gbTags.ResumeLayout(false);
            this.gbTags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecipePreview;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtIntroduction;
        private System.Windows.Forms.Label lblIntroduction;
        private System.Windows.Forms.PictureBox pbCoverPicture;
        private System.Windows.Forms.Label lblCoverPicture;
        private System.Windows.Forms.OpenFileDialog ofdPicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.Label lblPreparation;
        private System.Windows.Forms.TextBox txtServing;
        private System.Windows.Forms.Label lblServing;
        private System.Windows.Forms.TextBox txtAdvice;
        private System.Windows.Forms.Label lblAdvice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.Label lblPreparationTime;
        private System.Windows.Forms.Label lblWeightOfPreparation;
        private System.Windows.Forms.Label lblMealGroup;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.ComboBox cmbWeightOfPreparation;
        private System.Windows.Forms.ComboBox cmbMealType;
        private System.Windows.Forms.NumericUpDown nudPreparationTime;
        private System.Windows.Forms.TextBox txtIngridients;
        private System.Windows.Forms.GroupBox gbTags;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblBack;
    }
}