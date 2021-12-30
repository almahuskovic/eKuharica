namespace eKuharica.WinUI.Users
{
    partial class frmUserProfile
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
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.dgvRecipesSendByUser = new System.Windows.Forms.DataGridView();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblFollowing = new System.Windows.Forms.Label();
            this.lblFollowers = new System.Windows.Forms.Label();
            this.lblFollowersValue = new System.Windows.Forms.Label();
            this.lblFollowingValue = new System.Windows.Forms.Label();
            this.lblUserNameValue = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Akcija = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipesSendByUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPicture
            // 
            this.pbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicture.Location = new System.Drawing.Point(1017, 24);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(193, 186);
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            // 
            // dgvRecipesSendByUser
            // 
            this.dgvRecipesSendByUser.AllowUserToAddRows = false;
            this.dgvRecipesSendByUser.AllowUserToDeleteRows = false;
            this.dgvRecipesSendByUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecipesSendByUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipesSendByUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Akcija});
            this.dgvRecipesSendByUser.Location = new System.Drawing.Point(12, 231);
            this.dgvRecipesSendByUser.Name = "dgvRecipesSendByUser";
            this.dgvRecipesSendByUser.ReadOnly = true;
            this.dgvRecipesSendByUser.RowHeadersWidth = 51;
            this.dgvRecipesSendByUser.RowTemplate.Height = 24;
            this.dgvRecipesSendByUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipesSendByUser.Size = new System.Drawing.Size(1198, 234);
            this.dgvRecipesSendByUser.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(26, 61);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(46, 17);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "label1";
            // 
            // lblFollowing
            // 
            this.lblFollowing.AutoSize = true;
            this.lblFollowing.Location = new System.Drawing.Point(26, 97);
            this.lblFollowing.Name = "lblFollowing";
            this.lblFollowing.Size = new System.Drawing.Size(46, 17);
            this.lblFollowing.TabIndex = 3;
            this.lblFollowing.Text = "label2";
            // 
            // lblFollowers
            // 
            this.lblFollowers.AutoSize = true;
            this.lblFollowers.Location = new System.Drawing.Point(26, 133);
            this.lblFollowers.Name = "lblFollowers";
            this.lblFollowers.Size = new System.Drawing.Size(46, 17);
            this.lblFollowers.TabIndex = 4;
            this.lblFollowers.Text = "label3";
            // 
            // lblFollowersValue
            // 
            this.lblFollowersValue.AutoSize = true;
            this.lblFollowersValue.Location = new System.Drawing.Point(114, 133);
            this.lblFollowersValue.Name = "lblFollowersValue";
            this.lblFollowersValue.Size = new System.Drawing.Size(46, 17);
            this.lblFollowersValue.TabIndex = 7;
            this.lblFollowersValue.Text = "label4";
            // 
            // lblFollowingValue
            // 
            this.lblFollowingValue.AutoSize = true;
            this.lblFollowingValue.Location = new System.Drawing.Point(114, 97);
            this.lblFollowingValue.Name = "lblFollowingValue";
            this.lblFollowingValue.Size = new System.Drawing.Size(46, 17);
            this.lblFollowingValue.TabIndex = 6;
            this.lblFollowingValue.Text = "label5";
            // 
            // lblUserNameValue
            // 
            this.lblUserNameValue.AutoSize = true;
            this.lblUserNameValue.Location = new System.Drawing.Point(114, 61);
            this.lblUserNameValue.Name = "lblUserNameValue";
            this.lblUserNameValue.Size = new System.Drawing.Size(46, 17);
            this.lblUserNameValue.TabIndex = 5;
            this.lblUserNameValue.Text = "label6";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1135, 482);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "button1";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 125;
            // 
            // Akcija
            // 
            this.Akcija.HeaderText = "Prikazi";
            this.Akcija.MinimumWidth = 6;
            this.Akcija.Name = "Akcija";
            this.Akcija.ReadOnly = true;
            this.Akcija.Width = 125;
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 527);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFollowersValue);
            this.Controls.Add(this.lblFollowingValue);
            this.Controls.Add(this.lblUserNameValue);
            this.Controls.Add(this.lblFollowers);
            this.Controls.Add(this.lblFollowing);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.dgvRecipesSendByUser);
            this.Controls.Add(this.pbPicture);
            this.Name = "frmUserProfile";
            this.Text = "frmUserProfile";
            this.Load += new System.EventHandler(this.frmUserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipesSendByUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.DataGridView dgvRecipesSendByUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblFollowing;
        private System.Windows.Forms.Label lblFollowers;
        private System.Windows.Forms.Label lblFollowersValue;
        private System.Windows.Forms.Label lblFollowingValue;
        private System.Windows.Forms.Label lblUserNameValue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewButtonColumn Akcija;
    }
}