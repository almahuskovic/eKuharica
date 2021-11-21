using eKuharica.Model.DTO;
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
    public partial class frmShowRecipes : Form
    {
        private RecipeDto _recipe;
        public frmShowRecipes(RecipeDto recipe = null)
        {
            InitializeComponent();
            _recipe = recipe;

            LoadData();
        }

        private void LoadData()
        {
            if (_recipe != null)
            {

            }
        }
    }
}
