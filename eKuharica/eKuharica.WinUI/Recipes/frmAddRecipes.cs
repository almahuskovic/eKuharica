using eKuharica.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKuharica.WinUI.Recipes
{
    public partial class frmAddRecipes : Form
    {
        public frmAddRecipes()
        {
            InitializeComponent();
        }

        private void frmAddRecipes_Load(object sender, EventArgs e)
        {
            cmbMealType.DataSource = Helpers.Helper.MealTypeToSelectList();
            cmbWeightOfPreparation.DataSource = Helpers.Helper.WeightOfPreparationToSelectList();

            #region Translations
            
            #endregion
        }
    }
}
