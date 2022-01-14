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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sdgvRecipes = new eKuharica.WinUI.Helpers.SuperGrid();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prevod = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Akcije = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Prikazi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbExtraFilters = new System.Windows.Forms.GroupBox();
            this.cmbMealType = new System.Windows.Forms.ComboBox();
            this.cmbPreparationTime = new System.Windows.Forms.ComboBox();
            this.cmbWeightOfPreparation = new System.Windows.Forms.ComboBox();
            this.btnFilters = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnNewRecipe = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sdgvRecipes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbExtraFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.sdgvRecipes);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // sdgvRecipes
            // 
            resources.ApplyResources(this.sdgvRecipes, "sdgvRecipes");
            this.sdgvRecipes.AllowUserToAddRows = false;
            this.sdgvRecipes.AllowUserToDeleteRows = false;
            this.sdgvRecipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sdgvRecipes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.sdgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sdgvRecipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Prevod,
            this.Akcije,
            this.Prikazi,
            this.Uredi,
            this.Obrisi});
            this.sdgvRecipes.Name = "sdgvRecipes";
            this.sdgvRecipes.PageSize = 10;
            this.sdgvRecipes.ReadOnly = true;
            this.sdgvRecipes.RowTemplate.Height = 24;
            this.sdgvRecipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sdgvRecipes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sdgvRecipes_CellContentClick);
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Title";
            resources.ApplyResources(this.Naziv, "Naziv");
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Prevod
            // 
            this.Prevod.DataPropertyName = "IsTranslated";
            resources.ApplyResources(this.Prevod, "Prevod");
            this.Prevod.Name = "Prevod";
            this.Prevod.ReadOnly = true;
            // 
            // Akcije
            // 
            resources.ApplyResources(this.Akcije, "Akcije");
            this.Akcije.Name = "Akcije";
            this.Akcije.ReadOnly = true;
            this.Akcije.Text = "Prevod";
            this.Akcije.UseColumnTextForButtonValue = true;
            // 
            // Prikazi
            // 
            resources.ApplyResources(this.Prikazi, "Prikazi");
            this.Prikazi.Name = "Prikazi";
            this.Prikazi.ReadOnly = true;
            this.Prikazi.Text = "Prikazi";
            this.Prikazi.UseColumnTextForButtonValue = true;
            // 
            // Uredi
            // 
            resources.ApplyResources(this.Uredi, "Uredi");
            this.Uredi.Name = "Uredi";
            this.Uredi.ReadOnly = true;
            this.Uredi.Text = "Uredi";
            this.Uredi.UseColumnTextForButtonValue = true;
            // 
            // Obrisi
            // 
            resources.ApplyResources(this.Obrisi, "Obrisi");
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.ReadOnly = true;
            this.Obrisi.Text = "Obrisi";
            this.Obrisi.UseColumnTextForButtonValue = true;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.gbExtraFilters);
            this.groupBox2.Controls.Add(this.btnFilters);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnNewRecipe);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // gbExtraFilters
            // 
            resources.ApplyResources(this.gbExtraFilters, "gbExtraFilters");
            this.gbExtraFilters.Controls.Add(this.cmbMealType);
            this.gbExtraFilters.Controls.Add(this.cmbPreparationTime);
            this.gbExtraFilters.Controls.Add(this.cmbWeightOfPreparation);
            this.gbExtraFilters.Name = "gbExtraFilters";
            this.gbExtraFilters.TabStop = false;
            // 
            // cmbMealType
            // 
            resources.ApplyResources(this.cmbMealType, "cmbMealType");
            this.cmbMealType.FormattingEnabled = true;
            this.cmbMealType.Name = "cmbMealType";
            this.cmbMealType.SelectedIndexChanged += new System.EventHandler(this.cmbMealType_SelectedIndexChanged);
            // 
            // cmbPreparationTime
            // 
            resources.ApplyResources(this.cmbPreparationTime, "cmbPreparationTime");
            this.cmbPreparationTime.FormattingEnabled = true;
            this.cmbPreparationTime.Name = "cmbPreparationTime";
            this.cmbPreparationTime.SelectedIndexChanged += new System.EventHandler(this.cmbPreparationTime_SelectedIndexChanged);
            // 
            // cmbWeightOfPreparation
            // 
            resources.ApplyResources(this.cmbWeightOfPreparation, "cmbWeightOfPreparation");
            this.cmbWeightOfPreparation.FormattingEnabled = true;
            this.cmbWeightOfPreparation.Name = "cmbWeightOfPreparation";
            this.cmbWeightOfPreparation.SelectedIndexChanged += new System.EventHandler(this.cmbWeightOfPreparation_SelectedIndexChanged);
            // 
            // btnFilters
            // 
            resources.ApplyResources(this.btnFilters, "btnFilters");
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.UseVisualStyleBackColor = true;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnNewRecipe
            // 
            resources.ApplyResources(this.btnNewRecipe, "btnNewRecipe");
            this.btnNewRecipe.Name = "btnNewRecipe";
            this.btnNewRecipe.UseVisualStyleBackColor = true;
            this.btnNewRecipe.Click += new System.EventHandler(this.btnNewRecipe_Click);
            // 
            // bindingNavigator1
            // 
            resources.ApplyResources(this.bindingNavigator1, "bindingNavigator1");
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
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
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // bindingNavigatorCountItem
            // 
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            // 
            // bindingNavigatorSeparator
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            // 
            // bindingNavigatorMoveNextItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator2
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            // 
            // frmRecipes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecipes";
            this.Load += new System.EventHandler(this.frmRecipes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sdgvRecipes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbExtraFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnNewRecipe;
        private System.Windows.Forms.ComboBox cmbWeightOfPreparation;
        private System.Windows.Forms.ComboBox cmbPreparationTime;
        private System.Windows.Forms.ComboBox cmbMealType;
        private System.Windows.Forms.GroupBox gbExtraFilters;
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
        private System.Windows.Forms.BindingSource bindingSource1;
        private Helpers.SuperGrid sdgvRecipes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Prevod;
        private System.Windows.Forms.DataGridViewButtonColumn Akcije;
        private System.Windows.Forms.DataGridViewButtonColumn Prikazi;
        private System.Windows.Forms.DataGridViewButtonColumn Uredi;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
    }
}