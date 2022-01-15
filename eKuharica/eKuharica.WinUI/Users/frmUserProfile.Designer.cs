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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserProfile));
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
            resources.ApplyResources(this.pbPicture, "pbPicture");
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.TabStop = false;
            // 
            // dgvRecipesSendByUser
            // 
            this.dgvRecipesSendByUser.AllowUserToAddRows = false;
            this.dgvRecipesSendByUser.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dgvRecipesSendByUser, "dgvRecipesSendByUser");
            this.dgvRecipesSendByUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecipesSendByUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRecipesSendByUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipesSendByUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Akcija});
            this.dgvRecipesSendByUser.Name = "dgvRecipesSendByUser";
            this.dgvRecipesSendByUser.ReadOnly = true;
            this.dgvRecipesSendByUser.RowTemplate.Height = 24;
            this.dgvRecipesSendByUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipesSendByUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecipesSendByUser_CellContentClick);
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.Name = "lblUserName";
            // 
            // lblFollowing
            // 
            resources.ApplyResources(this.lblFollowing, "lblFollowing");
            this.lblFollowing.Name = "lblFollowing";
            // 
            // lblFollowers
            // 
            resources.ApplyResources(this.lblFollowers, "lblFollowers");
            this.lblFollowers.Name = "lblFollowers";
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
            // lblUserNameValue
            // 
            resources.ApplyResources(this.lblUserNameValue, "lblUserNameValue");
            this.lblUserNameValue.Name = "lblUserNameValue";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            resources.ApplyResources(this.Title, "Title");
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Akcija
            // 
            resources.ApplyResources(this.Akcija, "Akcija");
            this.Akcija.Name = "Akcija";
            this.Akcija.ReadOnly = true;
            this.Akcija.Text = "Prikazi";
            this.Akcija.UseColumnTextForButtonValue = true;
            // 
            // frmUserProfile
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.TopMost = true;
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