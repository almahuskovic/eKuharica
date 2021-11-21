namespace eKuharica.WinUI.Recipes
{
    partial class frmShowRecipes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowRecipes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLike = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblLikesDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbIntroduction = new System.Windows.Forms.RichTextBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1016, 228);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBack);
            this.groupBox1.Controls.Add(this.lblLike);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.lblAuthor);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1022, 249);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(19, 171);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(46, 17);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "label1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(19, 200);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 17);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "label2";
            // 
            // lblLike
            // 
            this.lblLike.AutoSize = true;
            this.lblLike.Image = ((System.Drawing.Image)(resources.GetObject("lblLike.Image")));
            this.lblLike.Location = new System.Drawing.Point(952, 36);
            this.lblLike.Name = "lblLike";
            this.lblLike.Size = new System.Drawing.Size(12, 17);
            this.lblLike.TabIndex = 5;
            this.lblLike.Text = ".";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(19, 36);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(46, 17);
            this.lblBack.TabIndex = 6;
            this.lblBack.Text = "label2";
            // 
            // lblLikesDisplay
            // 
            this.lblLikesDisplay.AutoSize = true;
            this.lblLikesDisplay.Location = new System.Drawing.Point(31, 277);
            this.lblLikesDisplay.Name = "lblLikesDisplay";
            this.lblLikesDisplay.Size = new System.Drawing.Size(46, 17);
            this.lblLikesDisplay.TabIndex = 7;
            this.lblLikesDisplay.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(964, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Zvijezde?";
            // 
            // rtbIntroduction
            // 
            this.rtbIntroduction.Location = new System.Drawing.Point(15, 327);
            this.rtbIntroduction.Name = "rtbIntroduction";
            this.rtbIntroduction.ReadOnly = true;
            this.rtbIntroduction.Size = new System.Drawing.Size(1016, 93);
            this.rtbIntroduction.TabIndex = 9;
            this.rtbIntroduction.Text = "";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(31, 451);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(46, 17);
            this.lblIngredients.TabIndex = 10;
            this.lblIngredients.Text = "label2";
            // 
            // frmShowRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 726);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.rtbIntroduction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLikesDisplay);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmShowRecipes";
            this.Text = "frmShowRecipes";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblLike;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblLikesDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbIntroduction;
        private System.Windows.Forms.Label lblIngredients;
    }
}