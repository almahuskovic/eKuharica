namespace eKuharica.WinUI.Users
{
    partial class frmUserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserDetails));
            this.pbUserProfilePicture = new System.Windows.Forms.PictureBox();
            this.lblFollowers = new System.Windows.Forms.Label();
            this.lblFollowing = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lblFollowersValue = new System.Windows.Forms.Label();
            this.lblFollowingValue = new System.Windows.Forms.Label();
            this.lblCreatedAtValue = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbUserProfilePicture
            // 
            resources.ApplyResources(this.pbUserProfilePicture, "pbUserProfilePicture");
            this.pbUserProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUserProfilePicture.Name = "pbUserProfilePicture";
            this.pbUserProfilePicture.TabStop = false;
            // 
            // lblFollowers
            // 
            resources.ApplyResources(this.lblFollowers, "lblFollowers");
            this.lblFollowers.Name = "lblFollowers";
            // 
            // lblFollowing
            // 
            resources.ApplyResources(this.lblFollowing, "lblFollowing");
            this.lblFollowing.Name = "lblFollowing";
            // 
            // lblCreatedAt
            // 
            resources.ApplyResources(this.lblCreatedAt, "lblCreatedAt");
            this.lblCreatedAt.Name = "lblCreatedAt";
            // 
            // lblFollowersValue
            // 
            resources.ApplyResources(this.lblFollowersValue, "lblFollowersValue");
            this.lblFollowersValue.Name = "lblFollowersValue";
            // 
            // lblFollowingValue
            // 
            resources.ApplyResources(this.lblFollowingValue, "lblFollowingValue");
            this.lblFollowingValue.Name = "lblFollowingValue";
            // 
            // lblCreatedAtValue
            // 
            resources.ApplyResources(this.lblCreatedAtValue, "lblCreatedAtValue");
            this.lblCreatedAtValue.Name = "lblCreatedAtValue";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.TabStop = true;
            this.lblUserName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblUserName_LinkClicked);
            // 
            // frmUserDetails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCreatedAtValue);
            this.Controls.Add(this.lblFollowingValue);
            this.Controls.Add(this.lblFollowersValue);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.lblFollowing);
            this.Controls.Add(this.lblFollowers);
            this.Controls.Add(this.pbUserProfilePicture);
            this.Name = "frmUserDetails";
            this.Load += new System.EventHandler(this.frmUserDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUserProfilePicture;
        private System.Windows.Forms.Label lblFollowers;
        private System.Windows.Forms.Label lblFollowing;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label lblFollowersValue;
        private System.Windows.Forms.Label lblFollowingValue;
        private System.Windows.Forms.Label lblCreatedAtValue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lblUserName;
    }
}