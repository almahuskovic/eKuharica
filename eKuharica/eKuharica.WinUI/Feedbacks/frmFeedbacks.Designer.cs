namespace eKuharica.WinUI.Feedbacks
{
    partial class frmFeedbacks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeedbacks));
            this.gbFeedbacks = new System.Windows.Forms.GroupBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.sdgvFeedbacks = new eKuharica.WinUI.Helpers.SuperGrid();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbFeedbacks.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sdgvFeedbacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFeedbacks
            // 
            this.gbFeedbacks.Controls.Add(this.sdgvFeedbacks);
            this.gbFeedbacks.Location = new System.Drawing.Point(23, 174);
            this.gbFeedbacks.Name = "gbFeedbacks";
            this.gbFeedbacks.Size = new System.Drawing.Size(925, 367);
            this.gbFeedbacks.TabIndex = 0;
            this.gbFeedbacks.TabStop = false;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.lblUserName);
            this.gbSearch.Controls.Add(this.txtUserName);
            this.gbSearch.Controls.Add(this.lblRating);
            this.gbSearch.Controls.Add(this.cmbRating);
            this.gbSearch.Location = new System.Drawing.Point(23, 27);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(925, 132);
            this.gbSearch.TabIndex = 1;
            this.gbSearch.TabStop = false;
            // 
            // sdgvFeedbacks
            // 
            this.sdgvFeedbacks.AllowUserToAddRows = false;
            this.sdgvFeedbacks.AllowUserToDeleteRows = false;
            this.sdgvFeedbacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sdgvFeedbacks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.UserName,
            this.Rating,
            this.Action});
            this.sdgvFeedbacks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sdgvFeedbacks.Location = new System.Drawing.Point(3, 18);
            this.sdgvFeedbacks.Name = "sdgvFeedbacks";
            this.sdgvFeedbacks.PageSize = 10;
            this.sdgvFeedbacks.ReadOnly = true;
            this.sdgvFeedbacks.RowHeadersWidth = 51;
            this.sdgvFeedbacks.RowTemplate.Height = 24;
            this.sdgvFeedbacks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sdgvFeedbacks.Size = new System.Drawing.Size(919, 346);
            this.sdgvFeedbacks.TabIndex = 0;
            this.sdgvFeedbacks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sdgvFeedbacks_CellContentClick);
            // 
            // cmbRating
            // 
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Location = new System.Drawing.Point(23, 49);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(162, 24);
            this.cmbRating.TabIndex = 0;
            this.cmbRating.SelectedIndexChanged += new System.EventHandler(this.cmbRating_SelectedIndexChanged);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(20, 29);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(46, 17);
            this.lblRating.TabIndex = 1;
            this.lblRating.Text = "label1";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 543);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(400, 0, 1, 0);
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(978, 27);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(290, 49);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(162, 22);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(287, 29);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(46, 17);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "label1";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "Username";
            this.UserName.HeaderText = "Username";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 125;
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            this.Rating.Width = 125;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "Details";
            this.Action.UseColumnTextForButtonValue = true;
            this.Action.Width = 125;
            // 
            // frmFeedbacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 570);
            this.ControlBox = false;
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbFeedbacks);
            this.Name = "frmFeedbacks";
            this.Text = "frmFeedbacks";
            this.Load += new System.EventHandler(this.frmFeedbacks_Load);
            this.gbFeedbacks.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sdgvFeedbacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFeedbacks;
        private System.Windows.Forms.GroupBox gbSearch;
        private Helpers.SuperGrid sdgvFeedbacks;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
    }
}