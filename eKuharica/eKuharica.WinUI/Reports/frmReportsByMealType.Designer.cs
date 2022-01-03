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
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbChooseMealType
            // 
            this.cmbChooseMealType.FormattingEnabled = true;
            this.cmbChooseMealType.Location = new System.Drawing.Point(34, 49);
            this.cmbChooseMealType.Name = "cmbChooseMealType";
            this.cmbChooseMealType.Size = new System.Drawing.Size(143, 24);
            this.cmbChooseMealType.TabIndex = 0;
            this.cmbChooseMealType.SelectedIndexChanged += new System.EventHandler(this.cmbChooseMealType_SelectedIndexChanged);
            // 
            // lblChooseMealType
            // 
            this.lblChooseMealType.AutoSize = true;
            this.lblChooseMealType.Location = new System.Drawing.Point(31, 29);
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
            // 
            // dgvReportData
            // 
            this.dgvReportData.AllowUserToAddRows = false;
            this.dgvReportData.AllowUserToDeleteRows = false;
            this.dgvReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportData.Location = new System.Drawing.Point(34, 98);
            this.dgvReportData.Name = "dgvReportData";
            this.dgvReportData.ReadOnly = true;
            this.dgvReportData.RowHeadersWidth = 51;
            this.dgvReportData.RowTemplate.Height = 24;
            this.dgvReportData.Size = new System.Drawing.Size(726, 260);
            this.dgvReportData.TabIndex = 3;
            // 
            // frmReportsByMealType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvReportData);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblChooseMealType);
            this.Controls.Add(this.cmbChooseMealType);
            this.Name = "frmReportsByMealType";
            this.Text = "frmReportsByMealType";
            this.Load += new System.EventHandler(this.frmReportsByMealType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChooseMealType;
        private System.Windows.Forms.Label lblChooseMealType;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvReportData;
    }
}