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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddRecipes));
            this.btnRecipePreview = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtIntroduction = new System.Windows.Forms.TextBox();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.pbCoverPicture = new System.Windows.Forms.PictureBox();
            this.lblCoverPicture = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreparationTime)).BeginInit();
            this.gbTags.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecipePreview
            // 
            this.btnRecipePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecipePreview.Location = new System.Drawing.Point(545, 26);
            this.btnRecipePreview.Name = "btnRecipePreview";
            this.btnRecipePreview.Size = new System.Drawing.Size(135, 33);
            this.btnRecipePreview.TabIndex = 0;
            this.btnRecipePreview.Text = "Pregledaj recept";
            this.btnRecipePreview.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(698, 26);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 33);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Spremi";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(26, 65);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(51, 17);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Naslov";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(29, 99);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(744, 22);
            this.txtTitle.TabIndex = 3;
            // 
            // txtIntroduction
            // 
            this.txtIntroduction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIntroduction.Location = new System.Drawing.Point(29, 172);
            this.txtIntroduction.Multiline = true;
            this.txtIntroduction.Name = "txtIntroduction";
            this.txtIntroduction.Size = new System.Drawing.Size(744, 50);
            this.txtIntroduction.TabIndex = 5;
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.AutoSize = true;
            this.lblIntroduction.Location = new System.Drawing.Point(26, 138);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(41, 17);
            this.lblIntroduction.TabIndex = 4;
            this.lblIntroduction.Text = "Uvod";
            // 
            // pbCoverPicture
            // 
            this.pbCoverPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCoverPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCoverPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCoverPicture.InitialImage")));
            this.pbCoverPicture.Location = new System.Drawing.Point(29, 266);
            this.pbCoverPicture.Name = "pbCoverPicture";
            this.pbCoverPicture.Size = new System.Drawing.Size(744, 50);
            this.pbCoverPicture.TabIndex = 6;
            this.pbCoverPicture.TabStop = false;
            // 
            // lblCoverPicture
            // 
            this.lblCoverPicture.AutoSize = true;
            this.lblCoverPicture.Location = new System.Drawing.Point(26, 246);
            this.lblCoverPicture.Name = "lblCoverPicture";
            this.lblCoverPicture.Size = new System.Drawing.Size(142, 17);
            this.lblCoverPicture.TabIndex = 7;
            this.lblCoverPicture.Text = "Naslovana fotografija";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(29, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 3);
            this.panel1.TabIndex = 8;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(26, 355);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(57, 17);
            this.lblIngredients.TabIndex = 9;
            this.lblIngredients.Text = "Sastojci";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(29, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 3);
            this.panel2.TabIndex = 9;
            // 
            // txtMethod
            // 
            this.txtMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMethod.Location = new System.Drawing.Point(29, 569);
            this.txtMethod.Multiline = true;
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(744, 50);
            this.txtMethod.TabIndex = 12;
            // 
            // lblPreparation
            // 
            this.lblPreparation.AutoSize = true;
            this.lblPreparation.Location = new System.Drawing.Point(26, 535);
            this.lblPreparation.Name = "lblPreparation";
            this.lblPreparation.Size = new System.Drawing.Size(65, 17);
            this.lblPreparation.TabIndex = 11;
            this.lblPreparation.Text = "Priprema";
            // 
            // txtServing
            // 
            this.txtServing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServing.Location = new System.Drawing.Point(29, 667);
            this.txtServing.Multiline = true;
            this.txtServing.Name = "txtServing";
            this.txtServing.Size = new System.Drawing.Size(744, 50);
            this.txtServing.TabIndex = 14;
            // 
            // lblServing
            // 
            this.lblServing.AutoSize = true;
            this.lblServing.Location = new System.Drawing.Point(26, 638);
            this.lblServing.Name = "lblServing";
            this.lblServing.Size = new System.Drawing.Size(87, 17);
            this.lblServing.TabIndex = 13;
            this.lblServing.Text = "Posluživanje";
            // 
            // txtAdvice
            // 
            this.txtAdvice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdvice.Location = new System.Drawing.Point(29, 765);
            this.txtAdvice.Multiline = true;
            this.txtAdvice.Name = "txtAdvice";
            this.txtAdvice.Size = new System.Drawing.Size(744, 50);
            this.txtAdvice.TabIndex = 16;
            // 
            // lblAdvice
            // 
            this.lblAdvice.AutoSize = true;
            this.lblAdvice.Location = new System.Drawing.Point(26, 731);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(47, 17);
            this.lblAdvice.TabIndex = 15;
            this.lblAdvice.Text = "Savjet";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Location = new System.Drawing.Point(29, 832);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 3);
            this.panel3.TabIndex = 10;
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(6, 25);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(57, 17);
            this.lblTags.TabIndex = 17;
            this.lblTags.Text = "Oznake";
            // 
            // lblPreparationTime
            // 
            this.lblPreparationTime.AutoSize = true;
            this.lblPreparationTime.Location = new System.Drawing.Point(6, 66);
            this.lblPreparationTime.Name = "lblPreparationTime";
            this.lblPreparationTime.Size = new System.Drawing.Size(115, 17);
            this.lblPreparationTime.TabIndex = 18;
            this.lblPreparationTime.Text = "Vrijeme pripreme";
            // 
            // lblWeightOfPreparation
            // 
            this.lblWeightOfPreparation.AutoSize = true;
            this.lblWeightOfPreparation.Location = new System.Drawing.Point(245, 66);
            this.lblWeightOfPreparation.Name = "lblWeightOfPreparation";
            this.lblWeightOfPreparation.Size = new System.Drawing.Size(111, 17);
            this.lblWeightOfPreparation.TabIndex = 19;
            this.lblWeightOfPreparation.Text = "Težina pripreme";
            // 
            // lblMealGroup
            // 
            this.lblMealGroup.AutoSize = true;
            this.lblMealGroup.Location = new System.Drawing.Point(464, 66);
            this.lblMealGroup.Name = "lblMealGroup";
            this.lblMealGroup.Size = new System.Drawing.Size(74, 17);
            this.lblMealGroup.TabIndex = 20;
            this.lblMealGroup.Text = "Grupa jela";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(115, 86);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(30, 17);
            this.lblMin.TabIndex = 22;
            this.lblMin.Text = "min";
            // 
            // cmbWeightOfPreparation
            // 
            this.cmbWeightOfPreparation.FormattingEnabled = true;
            this.cmbWeightOfPreparation.Location = new System.Drawing.Point(248, 86);
            this.cmbWeightOfPreparation.Name = "cmbWeightOfPreparation";
            this.cmbWeightOfPreparation.Size = new System.Drawing.Size(121, 24);
            this.cmbWeightOfPreparation.TabIndex = 23;
            // 
            // cmbMealType
            // 
            this.cmbMealType.FormattingEnabled = true;
            this.cmbMealType.Location = new System.Drawing.Point(467, 86);
            this.cmbMealType.Name = "cmbMealType";
            this.cmbMealType.Size = new System.Drawing.Size(121, 24);
            this.cmbMealType.TabIndex = 24;
            // 
            // nudPreparationTime
            // 
            this.nudPreparationTime.Location = new System.Drawing.Point(9, 86);
            this.nudPreparationTime.Name = "nudPreparationTime";
            this.nudPreparationTime.Size = new System.Drawing.Size(100, 22);
            this.nudPreparationTime.TabIndex = 26;
            // 
            // txtIngridients
            // 
            this.txtIngridients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIngridients.Location = new System.Drawing.Point(28, 375);
            this.txtIngridients.Multiline = true;
            this.txtIngridients.Name = "txtIngridients";
            this.txtIngridients.Size = new System.Drawing.Size(744, 125);
            this.txtIngridients.TabIndex = 27;
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
            this.gbTags.Location = new System.Drawing.Point(29, 835);
            this.gbTags.Name = "gbTags";
            this.gbTags.Size = new System.Drawing.Size(743, 128);
            this.gbTags.TabIndex = 28;
            this.gbTags.TabStop = false;
            // 
            // frmAddRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 977);
            this.ControlBox = false;
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
            this.Text = "frmAddRecipes";
            this.Load += new System.EventHandler(this.frmAddRecipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreparationTime)).EndInit();
            this.gbTags.ResumeLayout(false);
            this.gbTags.PerformLayout();
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
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
    }
}