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
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.gbCover = new System.Windows.Forms.GroupBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblLike = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblLikesDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbIntroduction = new System.Windows.Forms.RichTextBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.gbIngredients = new System.Windows.Forms.GroupBox();
            this.rtbIngredients = new System.Windows.Forms.RichTextBox();
            this.gbMethod = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbMethod = new System.Windows.Forms.RichTextBox();
            this.gbAdvice = new System.Windows.Forms.GroupBox();
            this.rtbAdvice = new System.Windows.Forms.RichTextBox();
            this.gbServing = new System.Windows.Forms.GroupBox();
            this.rtbServing = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrepTime = new System.Windows.Forms.Label();
            this.lblMealType = new System.Windows.Forms.Label();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.lblServing = new System.Windows.Forms.Label();
            this.lblWeightOfPrep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.gbCover.SuspendLayout();
            this.gbIngredients.SuspendLayout();
            this.gbMethod.SuspendLayout();
            this.gbAdvice.SuspendLayout();
            this.gbServing.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPicture
            // 
            this.pbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPicture.Location = new System.Drawing.Point(3, 18);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(986, 228);
            this.pbPicture.TabIndex = 1;
            this.pbPicture.TabStop = false;
            // 
            // gbCover
            // 
            this.gbCover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCover.Controls.Add(this.lblBack);
            this.gbCover.Controls.Add(this.lblLike);
            this.gbCover.Controls.Add(this.lblTitle);
            this.gbCover.Controls.Add(this.lblAuthor);
            this.gbCover.Controls.Add(this.pbPicture);
            this.gbCover.Location = new System.Drawing.Point(12, 12);
            this.gbCover.Name = "gbCover";
            this.gbCover.Size = new System.Drawing.Size(992, 249);
            this.gbCover.TabIndex = 2;
            this.gbCover.TabStop = false;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(19, 200);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 17);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "label2";
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
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(934, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Zvijezde?";
            // 
            // rtbIntroduction
            // 
            this.rtbIntroduction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbIntroduction.Location = new System.Drawing.Point(15, 327);
            this.rtbIntroduction.Name = "rtbIntroduction";
            this.rtbIntroduction.ReadOnly = true;
            this.rtbIntroduction.Size = new System.Drawing.Size(986, 69);
            this.rtbIntroduction.TabIndex = 9;
            this.rtbIntroduction.Text = "";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(3, 10);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(46, 17);
            this.lblIngredients.TabIndex = 10;
            this.lblIngredients.Text = "label2";
            // 
            // gbIngredients
            // 
            this.gbIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbIngredients.Controls.Add(this.rtbIngredients);
            this.gbIngredients.Controls.Add(this.lblIngredients);
            this.gbIngredients.Location = new System.Drawing.Point(3, 3);
            this.gbIngredients.Name = "gbIngredients";
            this.gbIngredients.Size = new System.Drawing.Size(392, 439);
            this.gbIngredients.TabIndex = 11;
            this.gbIngredients.TabStop = false;
            // 
            // rtbIngredients
            // 
            this.rtbIngredients.Location = new System.Drawing.Point(6, 30);
            this.rtbIngredients.Name = "rtbIngredients";
            this.rtbIngredients.Size = new System.Drawing.Size(386, 409);
            this.rtbIngredients.TabIndex = 11;
            this.rtbIngredients.Text = "";
            // 
            // gbMethod
            // 
            this.gbMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMethod.Controls.Add(this.label2);
            this.gbMethod.Controls.Add(this.rtbMethod);
            this.gbMethod.Location = new System.Drawing.Point(401, 3);
            this.gbMethod.Name = "gbMethod";
            this.gbMethod.Size = new System.Drawing.Size(582, 439);
            this.gbMethod.TabIndex = 12;
            this.gbMethod.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // rtbMethod
            // 
            this.rtbMethod.Location = new System.Drawing.Point(6, 30);
            this.rtbMethod.Name = "rtbMethod";
            this.rtbMethod.Size = new System.Drawing.Size(570, 409);
            this.rtbMethod.TabIndex = 12;
            this.rtbMethod.Text = "";
            // 
            // gbAdvice
            // 
            this.gbAdvice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAdvice.Controls.Add(this.lblAdvice);
            this.gbAdvice.Controls.Add(this.rtbAdvice);
            this.gbAdvice.Location = new System.Drawing.Point(3, 448);
            this.gbAdvice.Name = "gbAdvice";
            this.gbAdvice.Size = new System.Drawing.Size(392, 163);
            this.gbAdvice.TabIndex = 13;
            this.gbAdvice.TabStop = false;
            // 
            // rtbAdvice
            // 
            this.rtbAdvice.Location = new System.Drawing.Point(0, 34);
            this.rtbAdvice.Name = "rtbAdvice";
            this.rtbAdvice.Size = new System.Drawing.Size(395, 129);
            this.rtbAdvice.TabIndex = 13;
            this.rtbAdvice.Text = "";
            // 
            // gbServing
            // 
            this.gbServing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbServing.Controls.Add(this.lblServing);
            this.gbServing.Controls.Add(this.rtbServing);
            this.gbServing.Location = new System.Drawing.Point(401, 448);
            this.gbServing.Name = "gbServing";
            this.gbServing.Size = new System.Drawing.Size(582, 163);
            this.gbServing.TabIndex = 14;
            this.gbServing.TabStop = false;
            // 
            // rtbServing
            // 
            this.rtbServing.Location = new System.Drawing.Point(6, 34);
            this.rtbServing.Name = "rtbServing";
            this.rtbServing.Size = new System.Drawing.Size(570, 129);
            this.rtbServing.TabIndex = 14;
            this.rtbServing.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.40609F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.59391F));
            this.tableLayoutPanel1.Controls.Add(this.gbServing, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbMethod, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbIngredients, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbAdvice, 0, 1);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 435);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.48841F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.51159F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 614);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // lblPrepTime
            // 
            this.lblPrepTime.AutoSize = true;
            this.lblPrepTime.Location = new System.Drawing.Point(946, 399);
            this.lblPrepTime.Name = "lblPrepTime";
            this.lblPrepTime.Size = new System.Drawing.Size(46, 17);
            this.lblPrepTime.TabIndex = 15;
            this.lblPrepTime.Text = "label3";
            // 
            // lblMealType
            // 
            this.lblMealType.AutoSize = true;
            this.lblMealType.Location = new System.Drawing.Point(31, 399);
            this.lblMealType.Name = "lblMealType";
            this.lblMealType.Size = new System.Drawing.Size(46, 17);
            this.lblMealType.TabIndex = 16;
            this.lblMealType.Text = "label3";
            // 
            // lblAdvice
            // 
            this.lblAdvice.AutoSize = true;
            this.lblAdvice.Location = new System.Drawing.Point(6, 14);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(46, 17);
            this.lblAdvice.TabIndex = 12;
            this.lblAdvice.Text = "label2";
            // 
            // lblServing
            // 
            this.lblServing.AutoSize = true;
            this.lblServing.Location = new System.Drawing.Point(6, 14);
            this.lblServing.Name = "lblServing";
            this.lblServing.Size = new System.Drawing.Size(46, 17);
            this.lblServing.TabIndex = 13;
            this.lblServing.Text = "label5";
            // 
            // lblWeightOfPrep
            // 
            this.lblWeightOfPrep.AutoSize = true;
            this.lblWeightOfPrep.Location = new System.Drawing.Point(422, 399);
            this.lblWeightOfPrep.Name = "lblWeightOfPrep";
            this.lblWeightOfPrep.Size = new System.Drawing.Size(46, 17);
            this.lblWeightOfPrep.TabIndex = 17;
            this.lblWeightOfPrep.Text = "label3";
            // 
            // frmShowRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1046, 1069);
            this.ControlBox = false;
            this.Controls.Add(this.lblPrepTime);
            this.Controls.Add(this.lblWeightOfPrep);
            this.Controls.Add(this.lblMealType);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.rtbIntroduction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLikesDisplay);
            this.Controls.Add(this.gbCover);
            this.Name = "frmShowRecipes";
            this.Text = "frmShowRecipes";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmShowRecipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.gbCover.ResumeLayout(false);
            this.gbCover.PerformLayout();
            this.gbIngredients.ResumeLayout(false);
            this.gbIngredients.PerformLayout();
            this.gbMethod.ResumeLayout(false);
            this.gbMethod.PerformLayout();
            this.gbAdvice.ResumeLayout(false);
            this.gbAdvice.PerformLayout();
            this.gbServing.ResumeLayout(false);
            this.gbServing.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.GroupBox gbCover;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblLike;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblLikesDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbIntroduction;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.GroupBox gbIngredients;
        private System.Windows.Forms.RichTextBox rtbIngredients;
        private System.Windows.Forms.GroupBox gbMethod;
        private System.Windows.Forms.GroupBox gbAdvice;
        private System.Windows.Forms.GroupBox gbServing;
        private System.Windows.Forms.RichTextBox rtbMethod;
        private System.Windows.Forms.RichTextBox rtbAdvice;
        private System.Windows.Forms.RichTextBox rtbServing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPrepTime;
        private System.Windows.Forms.Label lblAdvice;
        private System.Windows.Forms.Label lblServing;
        private System.Windows.Forms.Label lblMealType;
        private System.Windows.Forms.Label lblWeightOfPrep;
    }
}