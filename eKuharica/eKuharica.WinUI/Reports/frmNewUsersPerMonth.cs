﻿using eKuharica.Model.DTO;
using Microsoft.Reporting.WinForms;
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
    public partial class frmNewUsersPerMonth : Form
    {
        APIService _userService = new APIService("User");
        public frmNewUsersPerMonth()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private async void frmNewUsersPerMonth_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource();
            rds.Name = "dsUsers";

            var users = await _userService.Get<List<UserDto>>();
            var data = users.GroupBy(x => x.CreatedAt.Date.Month).ToList();
            rds.Value = data;
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
