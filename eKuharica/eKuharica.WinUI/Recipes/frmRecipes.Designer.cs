namespace eKuharica.WinUI.Recipes
{
    partial class frmRecipes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFilters = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnNewRecipe = new System.Windows.Forms.Button();
            this.cmbMealType = new System.Windows.Forms.ComboBox();
            this.cmbPreparationTime = new System.Windows.Forms.ComboBox();
            this.cmbWeightOfPreparation = new System.Windows.Forms.ComboBox();
            this.gbExtraFilters = new System.Windows.Forms.GroupBox();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preveden = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Prevod = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Prikazi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbExtraFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRecipes);
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Preveden,
            this.Prevod,
            this.Prikazi,
            this.Uredi,
            this.Obrisi});
            this.dgvRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecipes.Location = new System.Drawing.Point(3, 18);
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.RowHeadersWidth = 51;
            this.dgvRecipes.RowTemplate.Height = 24;
            this.dgvRecipes.Size = new System.Drawing.Size(770, 260);
            this.dgvRecipes.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbExtraFilters);
            this.groupBox2.Controls.Add(this.btnFilters);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnNewRecipe);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 139);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnFilters
            // 
            this.btnFilters.Location = new System.Drawing.Point(24, 37);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(53, 34);
            this.btnFilters.TabIndex = 2;
            this.btnFilters.Text = "-";
            this.btnFilters.UseVisualStyleBackColor = true;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(95, 43);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(327, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnNewRecipe
            // 
            this.btnNewRecipe.Location = new System.Drawing.Point(616, 42);
            this.btnNewRecipe.Name = "btnNewRecipe";
            this.btnNewRecipe.Size = new System.Drawing.Size(134, 29);
            this.btnNewRecipe.TabIndex = 0;
            this.btnNewRecipe.Text = "+Dodaj novi";
            this.btnNewRecipe.UseVisualStyleBackColor = true;
            this.btnNewRecipe.Click += new System.EventHandler(this.btnNewRecipe_Click);
            // 
            // cmbMealType
            // 
            this.cmbMealType.FormattingEnabled = true;
            this.cmbMealType.Location = new System.Drawing.Point(6, 21);
            this.cmbMealType.Name = "cmbMealType";
            this.cmbMealType.Size = new System.Drawing.Size(121, 24);
            this.cmbMealType.TabIndex = 3;
            // 
            // cmbPreparationTime
            // 
            this.cmbPreparationTime.FormattingEnabled = true;
            this.cmbPreparationTime.Location = new System.Drawing.Point(260, 21);
            this.cmbPreparationTime.Name = "cmbPreparationTime";
            this.cmbPreparationTime.Size = new System.Drawing.Size(121, 24);
            this.cmbPreparationTime.TabIndex = 4;
            // 
            // cmbWeightOfPreparation
            // 
            this.cmbWeightOfPreparation.FormattingEnabled = true;
            this.cmbWeightOfPreparation.Location = new System.Drawing.Point(133, 21);
            this.cmbWeightOfPreparation.Name = "cmbWeightOfPreparation";
            this.cmbWeightOfPreparation.Size = new System.Drawing.Size(121, 24);
            this.cmbWeightOfPreparation.TabIndex = 5;
            // 
            // gbExtraFilters
            // 
            this.gbExtraFilters.Controls.Add(this.cmbMealType);
            this.gbExtraFilters.Controls.Add(this.cmbPreparationTime);
            this.gbExtraFilters.Controls.Add(this.cmbWeightOfPreparation);
            this.gbExtraFilters.Location = new System.Drawing.Point(24, 77);
            this.gbExtraFilters.Name = "gbExtraFilters";
            this.gbExtraFilters.Size = new System.Drawing.Size(398, 56);
            this.gbExtraFilters.TabIndex = 6;
            this.gbExtraFilters.TabStop = false;
            this.gbExtraFilters.Text = "Filters";
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Title";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.Width = 125;
            // 
            // Preveden
            // 
            this.Preveden.DataPropertyName = "IsTranslated";
            this.Preveden.HeaderText = "Prevod";
            this.Preveden.MinimumWidth = 6;
            this.Preveden.Name = "Preveden";
            this.Preveden.Width = 125;
            // 
            // Prevod
            // 
            this.Prevod.HeaderText = "Akcije";
            this.Prevod.MinimumWidth = 6;
            this.Prevod.Name = "Prevod";
            this.Prevod.Text = "Prevod";
            this.Prevod.UseColumnTextForButtonValue = true;
            this.Prevod.Width = 125;
            // 
            // Prikazi
            // 
            this.Prikazi.HeaderText = "";
            this.Prikazi.MinimumWidth = 6;
            this.Prikazi.Name = "Prikazi";
            this.Prikazi.Text = "Prikaži";
            this.Prikazi.UseColumnTextForButtonValue = true;
            this.Prikazi.Width = 125;
            // 
            // Uredi
            // 
            this.Uredi.HeaderText = "";
            this.Uredi.MinimumWidth = 6;
            this.Uredi.Name = "Uredi";
            this.Uredi.Text = "Uredi";
            this.Uredi.UseColumnTextForButtonValue = true;
            this.Uredi.Width = 125;
            // 
            // Obrisi
            // 
            this.Obrisi.HeaderText = "";
            this.Obrisi.MinimumWidth = 6;
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.UseColumnTextForButtonValue = true;
            this.Obrisi.Width = 125;
            // 
            // frmRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRecipes";
            this.Text = "frmRecipes";
            this.Load += new System.EventHandler(this.frmRecipes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbExtraFilters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnNewRecipe;
        private System.Windows.Forms.ComboBox cmbWeightOfPreparation;
        private System.Windows.Forms.ComboBox cmbPreparationTime;
        private System.Windows.Forms.ComboBox cmbMealType;
        private System.Windows.Forms.GroupBox gbExtraFilters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Preveden;
        private System.Windows.Forms.DataGridViewButtonColumn Prevod;
        private System.Windows.Forms.DataGridViewButtonColumn Prikazi;
        private System.Windows.Forms.DataGridViewButtonColumn Uredi;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
    }
}