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

namespace eKuharica.WinUI.Feedbacks
{
    public partial class frmFeedbackDetails : Form
    {
        private FeedbackDto _feedback;
        public frmFeedbackDetails(FeedbackDto feedback)
        {
            InitializeComponent();
            _feedback = feedback;
            btnClose.Text = Helpers.Helper.TranslationForBtnBack();
        }

        private void frmFeedbackDetails_Load(object sender, EventArgs e)
        {
            if (_feedback != null)
            {
                txtDescription.Text = _feedback.Description;
                lblCreatedTime.Text = _feedback.CreatedAt.ToShortDateString();
                lblUsername.Text = _feedback.Username;
                ratingControl1.Value = _feedback.Rating;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
