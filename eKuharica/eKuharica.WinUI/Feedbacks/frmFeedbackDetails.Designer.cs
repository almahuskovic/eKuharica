namespace eKuharica.WinUI.Feedbacks
{
    partial class frmFeedbackDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeedbackDetails));
            Syncfusion.Windows.Forms.Tools.CustomImageCollection customImageCollection1 = new Syncfusion.Windows.Forms.Tools.CustomImageCollection();
            Syncfusion.Windows.Forms.Tools.ResetButton resetButton1 = new Syncfusion.Windows.Forms.Tools.ResetButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCreatedTime = new System.Windows.Forms.Label();
            this.ratingControl1 = new Syncfusion.Windows.Forms.Tools.RatingControl();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.Name = "txtDescription";
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.Name = "lblUsername";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCreatedTime
            // 
            resources.ApplyResources(this.lblCreatedTime, "lblCreatedTime");
            this.lblCreatedTime.Name = "lblCreatedTime";
            // 
            // ratingControl1
            // 
            resources.ApplyResources(this.ratingControl1, "ratingControl1");
            this.ratingControl1.Images = customImageCollection1;
            this.ratingControl1.ItemSize = new System.Drawing.Size(20, 20);
            this.ratingControl1.Name = "ratingControl1";
            this.ratingControl1.ReadOnly = true;
            this.ratingControl1.ResetButton = resetButton1;
            // 
            // frmFeedbackDetails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ratingControl1);
            this.Controls.Add(this.lblCreatedTime);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtDescription);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFeedbackDetails";
            this.Load += new System.EventHandler(this.frmFeedbackDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCreatedTime;
        private Syncfusion.Windows.Forms.Tools.RatingControl ratingControl1;
    }
}