namespace eKuharica.WinUI.Articles
{
    partial class frmAddArticles
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.lblPicture = new System.Windows.Forms.Label();
            this.txtKeyWords = new System.Windows.Forms.TextBox();
            this.lblKeyWords = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.ofdPicture = new System.Windows.Forms.OpenFileDialog();
            this.gbPicture = new System.Windows.Forms.GroupBox();
            this.gbKeyWords = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.gbPicture.SuspendLayout();
            this.gbKeyWords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(24, 89);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(51, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Naslov";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(27, 122);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(715, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(667, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.Location = new System.Drawing.Point(568, 40);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 34);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Prikaži";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Location = new System.Drawing.Point(27, 202);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(715, 222);
            this.txtContent.TabIndex = 5;
            // 
            // lblContent
            // 
            this.lblContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(24, 169);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(56, 17);
            this.lblContent.TabIndex = 4;
            this.lblContent.Text = "Sadržaj";
            // 
            // pbPicture
            // 
            this.pbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicture.Location = new System.Drawing.Point(0, 50);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(715, 64);
            this.pbPicture.TabIndex = 6;
            this.pbPicture.TabStop = false;
            this.pbPicture.Click += new System.EventHandler(this.pbPicture_Click);
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(6, 18);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(134, 17);
            this.lblPicture.TabIndex = 7;
            this.lblPicture.Text = "Naslovna fotografija";
            // 
            // txtKeyWords
            // 
            this.txtKeyWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyWords.Location = new System.Drawing.Point(0, 67);
            this.txtKeyWords.Name = "txtKeyWords";
            this.txtKeyWords.Size = new System.Drawing.Size(715, 22);
            this.txtKeyWords.TabIndex = 9;
            // 
            // lblKeyWords
            // 
            this.lblKeyWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKeyWords.AutoSize = true;
            this.lblKeyWords.Location = new System.Drawing.Point(-3, 34);
            this.lblKeyWords.Name = "lblKeyWords";
            this.lblKeyWords.Size = new System.Drawing.Size(87, 17);
            this.lblKeyWords.TabIndex = 8;
            this.lblKeyWords.Text = "Ključne riječi";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(24, 688);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 17);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "label5";
            // 
            // ofdPicture
            // 
            this.ofdPicture.FileName = "ofdPicture";
            // 
            // gbPicture
            // 
            this.gbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPicture.Controls.Add(this.pbPicture);
            this.gbPicture.Controls.Add(this.lblPicture);
            this.gbPicture.ForeColor = System.Drawing.Color.Black;
            this.gbPicture.Location = new System.Drawing.Point(27, 446);
            this.gbPicture.Name = "gbPicture";
            this.gbPicture.Size = new System.Drawing.Size(715, 120);
            this.gbPicture.TabIndex = 11;
            this.gbPicture.TabStop = false;
            // 
            // gbKeyWords
            // 
            this.gbKeyWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbKeyWords.Controls.Add(this.lblKeyWords);
            this.gbKeyWords.Controls.Add(this.txtKeyWords);
            this.gbKeyWords.Location = new System.Drawing.Point(27, 566);
            this.gbKeyWords.Name = "gbKeyWords";
            this.gbKeyWords.Size = new System.Drawing.Size(715, 106);
            this.gbKeyWords.TabIndex = 12;
            this.gbKeyWords.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 723);
            this.ControlBox = false;
            this.Controls.Add(this.gbKeyWords);
            this.Controls.Add(this.gbPicture);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddArticles";
            this.Text = "frmAddArticles";
            this.Load += new System.EventHandler(this.frmAddArticles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.gbPicture.ResumeLayout(false);
            this.gbPicture.PerformLayout();
            this.gbKeyWords.ResumeLayout(false);
            this.gbKeyWords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.TextBox txtKeyWords;
        private System.Windows.Forms.Label lblKeyWords;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.OpenFileDialog ofdPicture;
        private System.Windows.Forms.GroupBox gbPicture;
        private System.Windows.Forms.GroupBox gbKeyWords;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}