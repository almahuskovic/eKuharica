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
            this.txtDescription.Location = new System.Drawing.Point(12, 103);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(595, 141);
            this.txtDescription.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 258);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(46, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "label1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(532, 352);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCreatedTime
            // 
            this.lblCreatedTime.AutoSize = true;
            this.lblCreatedTime.Location = new System.Drawing.Point(561, 74);
            this.lblCreatedTime.Name = "lblCreatedTime";
            this.lblCreatedTime.Size = new System.Drawing.Size(46, 17);
            this.lblCreatedTime.TabIndex = 4;
            this.lblCreatedTime.Text = "label1";
            // 
            // ratingControl1
            // 
            this.ratingControl1.Images = customImageCollection1;
            this.ratingControl1.ItemSize = new System.Drawing.Size(20, 20);
            this.ratingControl1.Location = new System.Drawing.Point(455, 258);
            this.ratingControl1.Name = "ratingControl1";
            this.ratingControl1.ReadOnly = true;
            this.ratingControl1.ResetButton = resetButton1;
            this.ratingControl1.Size = new System.Drawing.Size(153, 26);
            this.ratingControl1.TabIndex = 5;
            this.ratingControl1.Text = "ratingControl1";
            // 
            // frmFeedbackDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 387);
            this.Controls.Add(this.ratingControl1);
            this.Controls.Add(this.lblCreatedTime);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtDescription);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFeedbackDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmFeedbackDetails";
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