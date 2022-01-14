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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportsByMealType));
            this.cmbChooseMealType = new System.Windows.Forms.ComboBox();
            this.lblChooseMealType = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvReportData = new System.Windows.Forms.DataGridView();
            this.Recipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfLikes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNote = new System.Windows.Forms.Label();
            this.gbMealTypes = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).BeginInit();
            this.gbMealTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbChooseMealType
            // 
            resources.ApplyResources(this.cmbChooseMealType, "cmbChooseMealType");
            this.cmbChooseMealType.FormattingEnabled = true;
            this.cmbChooseMealType.Name = "cmbChooseMealType";
            this.cmbChooseMealType.SelectedIndexChanged += new System.EventHandler(this.cmbChooseMealType_SelectedIndexChanged);
            // 
            // lblChooseMealType
            // 
            resources.ApplyResources(this.lblChooseMealType, "lblChooseMealType");
            this.lblChooseMealType.Name = "lblChooseMealType";
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvReportData
            // 
            resources.ApplyResources(this.dgvReportData, "dgvReportData");
            this.dgvReportData.AllowUserToAddRows = false;
            this.dgvReportData.AllowUserToDeleteRows = false;
            this.dgvReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Recipe,
            this.NumberOfLikes});
            this.dgvReportData.Name = "dgvReportData";
            this.dgvReportData.ReadOnly = true;
            this.dgvReportData.RowTemplate.Height = 24;
            // 
            // Recipe
            // 
            this.Recipe.DataPropertyName = "Recipe";
            resources.ApplyResources(this.Recipe, "Recipe");
            this.Recipe.Name = "Recipe";
            this.Recipe.ReadOnly = true;
            // 
            // NumberOfLikes
            // 
            this.NumberOfLikes.DataPropertyName = "NumberOfLikes";
            resources.ApplyResources(this.NumberOfLikes, "NumberOfLikes");
            this.NumberOfLikes.Name = "NumberOfLikes";
            this.NumberOfLikes.ReadOnly = true;
            // 
            // lblNote
            // 
            resources.ApplyResources(this.lblNote, "lblNote");
            this.lblNote.Name = "lblNote";
            // 
            // gbMealTypes
            // 
            resources.ApplyResources(this.gbMealTypes, "gbMealTypes");
            this.gbMealTypes.Controls.Add(this.cmbChooseMealType);
            this.gbMealTypes.Controls.Add(this.lblNote);
            this.gbMealTypes.Controls.Add(this.lblChooseMealType);
            this.gbMealTypes.Name = "gbMealTypes";
            this.gbMealTypes.TabStop = false;
            // 
            // frmReportsByMealType
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.gbMealTypes);
            this.Controls.Add(this.dgvReportData);
            this.Controls.Add(this.btnPrint);
            this.Name = "frmReportsByMealType";
            this.Load += new System.EventHandler(this.frmReportsByMealType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).EndInit();
            this.gbMealTypes.ResumeLayout(false);
            this.gbMealTypes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChooseMealType;
        private System.Windows.Forms.Label lblChooseMealType;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvReportData;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.GroupBox gbMealTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfLikes;
    }
}