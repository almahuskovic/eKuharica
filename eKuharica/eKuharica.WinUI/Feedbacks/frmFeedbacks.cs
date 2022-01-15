using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKuharica.WinUI.Feedbacks
{
    public partial class frmFeedbacks : Form
    {
        APIService _feedbackService = new APIService("Feedback");
        public frmFeedbacks()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Helpers.Helper.CurrentLanguage);

            InitializeComponent();
            sdgvFeedbacks.AutoGenerateColumns = false;
            cmbRating.DataSource = Helpers.Helper.RatingSelectList();
        }
        private void LoadData(List<FeedbackDto> data)
        {
            if (!data.Any())
                sdgvFeedbacks.DataSource = null;
            else
            {
                sdgvFeedbacks.DataSource = data;
                Helpers.Helper.TranslationForDgvButtons(this, sdgvFeedbacks);

                sdgvFeedbacks.PageSize = 10;
                DataTable dt = Helpers.Helper.ToDataTable(data);
                sdgvFeedbacks.SetPagedDataSource(dt, bindingNavigator1);
            }
        }

        private async void Search()
        {
            FeedbackSearchRequest request = new FeedbackSearchRequest()
            {
                Rating = cmbRating.SelectedIndex,
                Username = txtUserName.Text
            };

            sdgvFeedbacks.DataSource = await _feedbackService.Get<List<FeedbackDto>>(request);
        }

        private async void frmFeedbacks_Load(object sender, EventArgs e)
        {
            var data = await _feedbackService.Get<List<FeedbackDto>>();
            LoadData(data);
        }

        private void cmbRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void sdgvFeedbacks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 3)
            {
                var currentRow = bindingNavigator1.BindingSource.Current as DataTable;
                var elementIndex = (currentRow.Rows.Count / 10) <= 1 ? e.RowIndex : (currentRow.Rows.Count / 10) * 10 + e.RowIndex;
                var selectedRow = Helpers.Helper.CreateItemFromRow<FeedbackDto>(currentRow.Rows[elementIndex]);

                frmFeedbackDetails frmFeedbackDetails = new frmFeedbackDetails(selectedRow);
                frmFeedbackDetails.MdiParent = MdiParent;
                frmFeedbackDetails.Show();
                Hide();
            }
        }
    }
}
