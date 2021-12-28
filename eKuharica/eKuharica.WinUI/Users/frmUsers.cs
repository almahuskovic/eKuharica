using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKuharica.WinUI.Users
{
    public partial class frmUsers : Form
    {
        APIService _serviceUsers = new APIService("User");
        APIService _followService = new APIService("Follow");
        bool _followers = false;
        bool _following = false;
        public frmUsers(bool followers = false, bool following = false)
        {
            InitializeComponent();
            sdgvUsers.AutoGenerateColumns = false;
            _followers = followers;
            _following = following;
        }

        private async void frmUsers_Load(object sender, EventArgs e)
        {
            var loggedUserId = (await Helpers.Helper.GetLoggedUser(_serviceUsers, APIService.Username)).Id;
            var data = new List<UserDto>();
          
            if (_following)//koga prati ovaj korisnik
            {
                data = (await _followService.Get<List<FollowDto>>(new FollowSearchRequest() { UserId = loggedUserId })).Select(x => new UserDto
                {
                    FullName = x.FollowerName,
                    Id = x.UserId
                }).ToList();

            }
            else if (_followers)//ko sve prati ovog korisnika
            {
                data = (await _followService.Get<List<FollowDto>>(new FollowSearchRequest() { FollowerId = loggedUserId })).Select(x => new UserDto
                {
                    FullName = x.UserName,
                    Id = x.UserId
                }).ToList();
            }
            else
            {
                data = await _serviceUsers.Get<List<UserDto>>();
                data.ForEach(x => x.FullName = x.FirstName + " " + x.LastName);
            }
         
            sdgvUsers.DataSource = data;//data.Where(x=>x.UserRoles.Contains())- hocu da displaya sve osim admina

            sdgvUsers.PageSize = 10;
            DataTable dt = Helpers.Helper.ToDataTable(data);
            sdgvUsers.SetPagedDataSource(dt, bindingNavigator1);
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            UserSearchRequest request = new UserSearchRequest()
            {
                FirstName = txtSearch.Text,
                LastName = txtSearch.Text,
            };

            sdgvUsers.DataSource = await _serviceUsers.Get<List<UserDto>>(request);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUsers frmAddUsers = new frmAddUsers();
            frmAddUsers.MdiParent = MdiParent;
            frmAddUsers.WindowState = FormWindowState.Maximized;
            frmAddUsers.Show();
            Hide();
        }

        private void sdgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //TODO:mozda ce trebati dodati 1 na index
                var currentRow = bindingNavigator1.BindingSource.Current as DataTable;
                var elementIndex = (currentRow.Rows.Count / 10) < 0 ? e.RowIndex : (currentRow.Rows.Count / 10) * 10 + e.RowIndex;
                //ne moze pretvoriti fullname u properti jer nije properti nego konkretno polje 
                var selectedRow = Helpers.Helper.CreateItemFromRow<UserDto>(currentRow.Rows[elementIndex]);

                if (e.ColumnIndex == 1)
                {
                    frmUserDetails frmUserDetails = new frmUserDetails(selectedRow);
                    frmUserDetails.Show();
                }
            }
        }
    }
}
