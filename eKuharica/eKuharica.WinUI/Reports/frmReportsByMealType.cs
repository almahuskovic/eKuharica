using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKuharica.WinUI.Reports
{
    public partial class frmReportsByMealType : Form
    {
        APIService _recipeService = new APIService("Recipe");
        private bool _byLikes;
        public frmReportsByMealType(bool byLikes = false)
        {
            InitializeComponent();
            _byLikes = byLikes;
        }

        private void frmReportsByMealType_Load(object sender, EventArgs e)
        {
            cmbChooseMealType.DataSource = Helpers.Helper.MealTypeToSelectList();
        }

        private void cmbChooseMealType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
