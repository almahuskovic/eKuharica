namespace eKuharica.WinUI.Articles
{
    partial class frmShowArticles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowArticles));
            this.gbCover = new System.Windows.Forms.GroupBox();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.lblKeyWords = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.gbCover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCover
            // 
            resources.ApplyResources(this.gbCover, "gbCover");
            this.gbCover.Controls.Add(this.pbPicture);
            this.gbCover.Name = "gbCover";
            this.gbCover.TabStop = false;
            // 
            // pbPicture
            // 
            resources.ApplyResources(this.pbPicture, "pbPicture");
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.TabStop = false;
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // rtbContent
            // 
            resources.ApplyResources(this.rtbContent, "rtbContent");
            this.rtbContent.Name = "rtbContent";
            // 
            // lblKeyWords
            // 
            resources.ApplyResources(this.lblKeyWords, "lblKeyWords");
            this.lblKeyWords.Name = "lblKeyWords";
            // 
            // lblAuthor
            // 
            resources.ApplyResources(this.lblAuthor, "lblAuthor");
            this.lblAuthor.Name = "lblAuthor";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate";
            // 
            // frmShowArticles
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblKeyWords);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbCover);
            this.Name = "frmShowArticles";
            this.Load += new System.EventHandler(this.frmShowArticles_Load);
            this.gbCover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCover;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Label lblKeyWords;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblDate;
    }
}