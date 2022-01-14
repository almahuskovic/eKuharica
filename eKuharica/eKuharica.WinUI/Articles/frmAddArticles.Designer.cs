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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddArticles));
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
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.errorProvider1.SetError(this.lblTitle, resources.GetString("lblTitle.Error"));
            this.errorProvider1.SetIconAlignment(this.lblTitle, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTitle.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblTitle, ((int)(resources.GetObject("lblTitle.IconPadding"))));
            this.lblTitle.Name = "lblTitle";
            // 
            // txtTitle
            // 
            resources.ApplyResources(this.txtTitle, "txtTitle");
            this.errorProvider1.SetError(this.txtTitle, resources.GetString("txtTitle.Error"));
            this.errorProvider1.SetIconAlignment(this.txtTitle, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtTitle.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtTitle, ((int)(resources.GetObject("txtTitle.IconPadding"))));
            this.txtTitle.Name = "txtTitle";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.errorProvider1.SetError(this.btnSave, resources.GetString("btnSave.Error"));
            this.errorProvider1.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding"))));
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            resources.ApplyResources(this.btnShow, "btnShow");
            this.errorProvider1.SetError(this.btnShow, resources.GetString("btnShow.Error"));
            this.errorProvider1.SetIconAlignment(this.btnShow, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnShow.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnShow, ((int)(resources.GetObject("btnShow.IconPadding"))));
            this.btnShow.Name = "btnShow";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtContent
            // 
            resources.ApplyResources(this.txtContent, "txtContent");
            this.errorProvider1.SetError(this.txtContent, resources.GetString("txtContent.Error"));
            this.errorProvider1.SetIconAlignment(this.txtContent, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtContent.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtContent, ((int)(resources.GetObject("txtContent.IconPadding"))));
            this.txtContent.Name = "txtContent";
            // 
            // lblContent
            // 
            resources.ApplyResources(this.lblContent, "lblContent");
            this.errorProvider1.SetError(this.lblContent, resources.GetString("lblContent.Error"));
            this.errorProvider1.SetIconAlignment(this.lblContent, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblContent.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblContent, ((int)(resources.GetObject("lblContent.IconPadding"))));
            this.lblContent.Name = "lblContent";
            // 
            // pbPicture
            // 
            resources.ApplyResources(this.pbPicture, "pbPicture");
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorProvider1.SetError(this.pbPicture, resources.GetString("pbPicture.Error"));
            this.errorProvider1.SetIconAlignment(this.pbPicture, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pbPicture.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.pbPicture, ((int)(resources.GetObject("pbPicture.IconPadding"))));
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.TabStop = false;
            this.pbPicture.Click += new System.EventHandler(this.pbPicture_Click);
            // 
            // lblPicture
            // 
            resources.ApplyResources(this.lblPicture, "lblPicture");
            this.errorProvider1.SetError(this.lblPicture, resources.GetString("lblPicture.Error"));
            this.errorProvider1.SetIconAlignment(this.lblPicture, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPicture.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblPicture, ((int)(resources.GetObject("lblPicture.IconPadding"))));
            this.lblPicture.Name = "lblPicture";
            // 
            // txtKeyWords
            // 
            resources.ApplyResources(this.txtKeyWords, "txtKeyWords");
            this.errorProvider1.SetError(this.txtKeyWords, resources.GetString("txtKeyWords.Error"));
            this.errorProvider1.SetIconAlignment(this.txtKeyWords, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtKeyWords.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtKeyWords, ((int)(resources.GetObject("txtKeyWords.IconPadding"))));
            this.txtKeyWords.Name = "txtKeyWords";
            // 
            // lblKeyWords
            // 
            resources.ApplyResources(this.lblKeyWords, "lblKeyWords");
            this.errorProvider1.SetError(this.lblKeyWords, resources.GetString("lblKeyWords.Error"));
            this.errorProvider1.SetIconAlignment(this.lblKeyWords, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblKeyWords.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblKeyWords, ((int)(resources.GetObject("lblKeyWords.IconPadding"))));
            this.lblKeyWords.Name = "lblKeyWords";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.errorProvider1.SetError(this.lblDate, resources.GetString("lblDate.Error"));
            this.errorProvider1.SetIconAlignment(this.lblDate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblDate.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblDate, ((int)(resources.GetObject("lblDate.IconPadding"))));
            this.lblDate.Name = "lblDate";
            // 
            // ofdPicture
            // 
            this.ofdPicture.FileName = "ofdPicture";
            resources.ApplyResources(this.ofdPicture, "ofdPicture");
            // 
            // gbPicture
            // 
            resources.ApplyResources(this.gbPicture, "gbPicture");
            this.gbPicture.Controls.Add(this.pbPicture);
            this.gbPicture.Controls.Add(this.lblPicture);
            this.errorProvider1.SetError(this.gbPicture, resources.GetString("gbPicture.Error"));
            this.gbPicture.ForeColor = System.Drawing.Color.Black;
            this.errorProvider1.SetIconAlignment(this.gbPicture, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("gbPicture.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.gbPicture, ((int)(resources.GetObject("gbPicture.IconPadding"))));
            this.gbPicture.Name = "gbPicture";
            this.gbPicture.TabStop = false;
            // 
            // gbKeyWords
            // 
            resources.ApplyResources(this.gbKeyWords, "gbKeyWords");
            this.gbKeyWords.Controls.Add(this.lblKeyWords);
            this.gbKeyWords.Controls.Add(this.txtKeyWords);
            this.errorProvider1.SetError(this.gbKeyWords, resources.GetString("gbKeyWords.Error"));
            this.errorProvider1.SetIconAlignment(this.gbKeyWords, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("gbKeyWords.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.gbKeyWords, ((int)(resources.GetObject("gbKeyWords.IconPadding"))));
            this.gbKeyWords.Name = "gbKeyWords";
            this.gbKeyWords.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // frmAddArticles
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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