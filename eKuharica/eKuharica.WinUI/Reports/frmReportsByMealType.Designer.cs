namespace eKuharica.WinUI.Reports
{
    partial class frmReportsByMealType
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
            this.cmbChooseMealType = new System.Windows.Forms.ComboBox();
            this.lblChooseMealType = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvReportData = new System.Windows.Forms.DataGridView();
            this.lblNote = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Recipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfLikes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbChooseMealType
            // 
            this.cmbChooseMealType.FormattingEnabled = true;
            this.cmbChooseMealType.Location = new System.Drawing.Point(18, 33);
            this.cmbChooseMealType.Name = "cmbChooseMealType";
            this.cmbChooseMealType.Size = new System.Drawing.Size(143, 24);
            this.cmbChooseMealType.TabIndex = 0;
            this.cmbChooseMealType.SelectedIndexChanged += new System.EventHandler(this.cmbChooseMealType_SelectedIndexChanged);
            // 
            // lblChooseMealType
            // 
            this.lblChooseMealType.AutoSize = true;
            this.lblChooseMealType.Location = new System.Drawing.Point(15, 13);
            this.lblChooseMealType.Name = "lblChooseMealType";
            this.lblChooseMealType.Size = new System.Drawing.Size(46, 17);
            this.lblChooseMealType.TabIndex = 1;
            this.lblChooseMealType.Text = "label1";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(685, 392);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "button1";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvReportData
            // 
            this.dgvReportData.AllowUserToAddRows = false;
            this.dgvReportData.AllowUserToDeleteRows = false;
            this.dgvReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Recipe,
            this.NumberOfLikes});
            this.dgvReportData.Location = new System.Drawing.Point(34, 107);
            this.dgvReportData.Name = "dgvReportData";
            this.dgvReportData.ReadOnly = true;
            this.dgvReportData.RowHeadersWidth = 51;
            this.dgvReportData.RowTemplate.Height = 24;
            this.dgvReportData.Size = new System.Drawing.Size(726, 260);
            this.dgvReportData.TabIndex = 3;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(15, 62);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(46, 17);
            this.lblNote.TabIndex = 4;
            this.lblNote.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbChooseMealType);
            this.groupBox1.Controls.Add(this.lblNote);
            this.groupBox1.Controls.Add(this.lblChooseMealType);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 89);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Recipe
            // 
            this.Recipe.DataPropertyName = "Recipe";
            this.Recipe.HeaderText = "Recipe";
            this.Recipe.MinimumWidth = 6;
            this.Recipe.Name = "Recipe";
            this.Recipe.ReadOnly = true;
            this.Recipe.Width = 125;
            // 
            // NumberOfLikes
            // 
            this.NumberOfLikes.DataPropertyName = "NumberOfLikes";
            this.NumberOfLikes.HeaderText = "NumberOfLikes";
            this.NumberOfLikes.MinimumWidth = 6;
            this.NumberOfLikes.Name = "NumberOfLikes";
            this.NumberOfLikes.ReadOnly = true;
            this.NumberOfLikes.Width = 125;
            // 
            // frmReportsByMealType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvReportData);
            this.Controls.Add(this.btnPrint);
            this.Name = "frmReportsByMealType";
            this.Text = "frmReportsByMealType";
            this.Load += new System.EventHandler(this.frmReportsByMealType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChooseMealType;
        private System.Windows.Forms.Label lblChooseMealType;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvReportData;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfLikes;
    }
}