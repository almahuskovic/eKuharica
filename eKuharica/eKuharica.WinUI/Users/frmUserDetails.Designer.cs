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
            this.pbUserProfilePicture = new System.Windows.Forms.PictureBox();
            this.lblFollowers = new System.Windows.Forms.Label();
            this.lblFollowing = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lblFollowersValue = new System.Windows.Forms.Label();
            this.lblFollowingValue = new System.Windows.Forms.Label();
            this.lblCreatedAtValue = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbUserProfilePicture
            // 
            this.pbUserProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUserProfilePicture.Location = new System.Drawing.Point(40, 35);
            this.pbUserProfilePicture.Name = "pbUserProfilePicture";
            this.pbUserProfilePicture.Size = new System.Drawing.Size(185, 171);
            this.pbUserProfilePicture.TabIndex = 0;
            this.pbUserProfilePicture.TabStop = false;
            // 
            // lblFollowers
            // 
            this.lblFollowers.AutoSize = true;
            this.lblFollowers.Location = new System.Drawing.Point(337, 69);
            this.lblFollowers.Name = "lblFollowers";
            this.lblFollowers.Size = new System.Drawing.Size(58, 17);
            this.lblFollowers.TabIndex = 1;
            this.lblFollowers.Text = "Pratitelji";
            // 
            // lblFollowing
            // 
            this.lblFollowing.AutoSize = true;
            this.lblFollowing.Location = new System.Drawing.Point(337, 106);
            this.lblFollowing.Name = "lblFollowing";
            this.lblFollowing.Size = new System.Drawing.Size(37, 17);
            this.lblFollowing.TabIndex = 2;
            this.lblFollowing.Text = "Prati";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Location = new System.Drawing.Point(337, 143);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(83, 17);
            this.lblCreatedAt.TabIndex = 3;
            this.lblCreatedAt.Text = "Pridruzio se";
            // 
            // lblFollowersValue
            // 
            this.lblFollowersValue.AutoSize = true;
            this.lblFollowersValue.Location = new System.Drawing.Point(441, 69);
            this.lblFollowersValue.Name = "lblFollowersValue";
            this.lblFollowersValue.Size = new System.Drawing.Size(46, 17);
            this.lblFollowersValue.TabIndex = 4;
            this.lblFollowersValue.Text = "label4";
            // 
            // lblFollowingValue
            // 
            this.lblFollowingValue.AutoSize = true;
            this.lblFollowingValue.Location = new System.Drawing.Point(441, 106);
            this.lblFollowingValue.Name = "lblFollowingValue";
            this.lblFollowingValue.Size = new System.Drawing.Size(46, 17);
            this.lblFollowingValue.TabIndex = 5;
            this.lblFollowingValue.Text = "label5";
            // 
            // lblCreatedAtValue
            // 
            this.lblCreatedAtValue.AutoSize = true;
            this.lblCreatedAtValue.Location = new System.Drawing.Point(441, 143);
            this.lblCreatedAtValue.Name = "lblCreatedAtValue";
            this.lblCreatedAtValue.Size = new System.Drawing.Size(46, 17);
            this.lblCreatedAtValue.TabIndex = 6;
            this.lblCreatedAtValue.Text = "label6";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(96, 230);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(46, 17);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "label7";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(486, 274);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 320);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblCreatedAtValue);
            this.Controls.Add(this.lblFollowingValue);
            this.Controls.Add(this.lblFollowersValue);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.lblFollowing);
            this.Controls.Add(this.lblFollowers);
            this.Controls.Add(this.pbUserProfilePicture);
            this.Name = "frmUserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserDetails";
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
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnClose;
    }
}