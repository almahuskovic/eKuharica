namespace eKuharica.WinUI.Users
{
    partial class frmAddUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUsers));
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblRoles = new System.Windows.Forms.Label();
            this.clbRoles = new System.Windows.Forms.CheckedListBox();
            this.ofdPicture = new System.Windows.Forms.OpenFileDialog();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbRoles = new System.Windows.Forms.GroupBox();
            this.gbPassword = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.gbRoles.SuspendLayout();
            this.gbPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.errorProvider1.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error"));
            this.errorProvider1.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding"))));
            this.txtFirstName.Name = "txtFirstName";
            // 
            // lblFirstName
            // 
            resources.ApplyResources(this.lblFirstName, "lblFirstName");
            this.errorProvider1.SetError(this.lblFirstName, resources.GetString("lblFirstName.Error"));
            this.errorProvider1.SetIconAlignment(this.lblFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblFirstName.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblFirstName, ((int)(resources.GetObject("lblFirstName.IconPadding"))));
            this.lblFirstName.Name = "lblFirstName";
            // 
            // lblLastName
            // 
            resources.ApplyResources(this.lblLastName, "lblLastName");
            this.errorProvider1.SetError(this.lblLastName, resources.GetString("lblLastName.Error"));
            this.errorProvider1.SetIconAlignment(this.lblLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblLastName.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblLastName, ((int)(resources.GetObject("lblLastName.IconPadding"))));
            this.lblLastName.Name = "lblLastName";
            // 
            // txtLastName
            // 
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.errorProvider1.SetError(this.txtLastName, resources.GetString("txtLastName.Error"));
            this.errorProvider1.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding"))));
            this.txtLastName.Name = "txtLastName";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.errorProvider1.SetError(this.lblEmail, resources.GetString("lblEmail.Error"));
            this.errorProvider1.SetIconAlignment(this.lblEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblEmail.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblEmail, ((int)(resources.GetObject("lblEmail.IconPadding"))));
            this.lblEmail.Name = "lblEmail";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.errorProvider1.SetError(this.txtEmail, resources.GetString("txtEmail.Error"));
            this.errorProvider1.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding"))));
            this.txtEmail.Name = "txtEmail";
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.errorProvider1.SetError(this.lblUsername, resources.GetString("lblUsername.Error"));
            this.errorProvider1.SetIconAlignment(this.lblUsername, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblUsername.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblUsername, ((int)(resources.GetObject("lblUsername.IconPadding"))));
            this.lblUsername.Name = "lblUsername";
            // 
            // txtUserName
            // 
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.errorProvider1.SetError(this.txtUserName, resources.GetString("txtUserName.Error"));
            this.errorProvider1.SetIconAlignment(this.txtUserName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtUserName.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtUserName, ((int)(resources.GetObject("txtUserName.IconPadding"))));
            this.txtUserName.Name = "txtUserName";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.errorProvider1.SetError(this.lblPassword, resources.GetString("lblPassword.Error"));
            this.errorProvider1.SetIconAlignment(this.lblPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPassword.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblPassword, ((int)(resources.GetObject("lblPassword.IconPadding"))));
            this.lblPassword.Name = "lblPassword";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.errorProvider1.SetError(this.txtPassword, resources.GetString("txtPassword.Error"));
            this.errorProvider1.SetIconAlignment(this.txtPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPassword.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtPassword, ((int)(resources.GetObject("txtPassword.IconPadding"))));
            this.txtPassword.Name = "txtPassword";
            // 
            // lblConfirmPassword
            // 
            resources.ApplyResources(this.lblConfirmPassword, "lblConfirmPassword");
            this.errorProvider1.SetError(this.lblConfirmPassword, resources.GetString("lblConfirmPassword.Error"));
            this.errorProvider1.SetIconAlignment(this.lblConfirmPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblConfirmPassword.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblConfirmPassword, ((int)(resources.GetObject("lblConfirmPassword.IconPadding"))));
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            // 
            // txtConfirmPassword
            // 
            resources.ApplyResources(this.txtConfirmPassword, "txtConfirmPassword");
            this.errorProvider1.SetError(this.txtConfirmPassword, resources.GetString("txtConfirmPassword.Error"));
            this.errorProvider1.SetIconAlignment(this.txtConfirmPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtConfirmPassword.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtConfirmPassword, ((int)(resources.GetObject("txtConfirmPassword.IconPadding"))));
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            // 
            // lblRoles
            // 
            resources.ApplyResources(this.lblRoles, "lblRoles");
            this.errorProvider1.SetError(this.lblRoles, resources.GetString("lblRoles.Error"));
            this.errorProvider1.SetIconAlignment(this.lblRoles, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblRoles.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblRoles, ((int)(resources.GetObject("lblRoles.IconPadding"))));
            this.lblRoles.Name = "lblRoles";
            // 
            // clbRoles
            // 
            resources.ApplyResources(this.clbRoles, "clbRoles");
            this.errorProvider1.SetError(this.clbRoles, resources.GetString("clbRoles.Error"));
            this.clbRoles.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.clbRoles, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("clbRoles.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.clbRoles, ((int)(resources.GetObject("clbRoles.IconPadding"))));
            this.clbRoles.Name = "clbRoles";
            // 
            // ofdPicture
            // 
            this.ofdPicture.FileName = "openFileDialog1";
            resources.ApplyResources(this.ofdPicture, "ofdPicture");
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
            // lblPhoneNumber
            // 
            resources.ApplyResources(this.lblPhoneNumber, "lblPhoneNumber");
            this.errorProvider1.SetError(this.lblPhoneNumber, resources.GetString("lblPhoneNumber.Error"));
            this.errorProvider1.SetIconAlignment(this.lblPhoneNumber, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPhoneNumber.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblPhoneNumber, ((int)(resources.GetObject("lblPhoneNumber.IconPadding"))));
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            // 
            // txtPhoneNumber
            // 
            resources.ApplyResources(this.txtPhoneNumber, "txtPhoneNumber");
            this.errorProvider1.SetError(this.txtPhoneNumber, resources.GetString("txtPhoneNumber.Error"));
            this.errorProvider1.SetIconAlignment(this.txtPhoneNumber, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPhoneNumber.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtPhoneNumber, ((int)(resources.GetObject("txtPhoneNumber.IconPadding"))));
            this.txtPhoneNumber.Name = "txtPhoneNumber";
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
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.errorProvider1.SetError(this.btnClose, resources.GetString("btnClose.Error"));
            this.errorProvider1.SetIconAlignment(this.btnClose, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnClose.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnClose, ((int)(resources.GetObject("btnClose.IconPadding"))));
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbRoles
            // 
            resources.ApplyResources(this.gbRoles, "gbRoles");
            this.gbRoles.Controls.Add(this.lblRoles);
            this.gbRoles.Controls.Add(this.clbRoles);
            this.errorProvider1.SetError(this.gbRoles, resources.GetString("gbRoles.Error"));
            this.errorProvider1.SetIconAlignment(this.gbRoles, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("gbRoles.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.gbRoles, ((int)(resources.GetObject("gbRoles.IconPadding"))));
            this.gbRoles.Name = "gbRoles";
            this.gbRoles.TabStop = false;
            // 
            // gbPassword
            // 
            resources.ApplyResources(this.gbPassword, "gbPassword");
            this.gbPassword.Controls.Add(this.lblPassword);
            this.gbPassword.Controls.Add(this.txtPassword);
            this.gbPassword.Controls.Add(this.txtConfirmPassword);
            this.gbPassword.Controls.Add(this.lblConfirmPassword);
            this.errorProvider1.SetError(this.gbPassword, resources.GetString("gbPassword.Error"));
            this.errorProvider1.SetIconAlignment(this.gbPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("gbPassword.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.gbPassword, ((int)(resources.GetObject("gbPassword.IconPadding"))));
            this.gbPassword.Name = "gbPassword";
            this.gbPassword.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // frmAddUsers
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.gbPassword);
            this.Controls.Add(this.gbRoles);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "frmAddUsers";
            this.Load += new System.EventHandler(this.frmAddUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.gbRoles.ResumeLayout(false);
            this.gbRoles.PerformLayout();
            this.gbPassword.ResumeLayout(false);
            this.gbPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.CheckedListBox clbRoles;
        private System.Windows.Forms.OpenFileDialog ofdPicture;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbRoles;
        private System.Windows.Forms.GroupBox gbPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}