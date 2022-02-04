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
using static eKuharica.Model.Enumerations.Enumerations;

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
            var loggedUser = (await Helpers.Helper.GetLoggedUser(_serviceUsers, APIService.Username));
            var data = new List<UserDto>();

            if (!Helpers.Helper.IsAdministrator(loggedUser) || _following || _followers)
               btnAddUser.Visible = false;

            if (_following)//koga prati ovaj korisnik
            {
                data = (await _followService.Get<List<FollowDto>>(new FollowSearchRequest() { UserId = loggedUser.Id })).Select(x => new UserDto
                {
                    Username = x.FollowerName,
                    Id = x.UserId
                }).ToList();

            }
            else if (_followers)//ko sve prati ovog korisnika
            {
                data = (await _followService.Get<List<FollowDto>>(new FollowSearchRequest() { FollowerId = loggedUser.Id })).Select(x => new UserDto
                {
                    Username = x.UserName,
                    Id = x.UserId
                }).ToList();
            }
            else
            {
                data = await _serviceUsers.Get<List<UserDto>>();
                data.ForEach(x => x.FullName = x.FirstName + " " + x.LastName);
            }

            if (!Helpers.Helper.IsAdministrator(loggedUser))//hocu da displaya samo usere
            {
                data = data.Where(x => !x.UserRoles.Any(s => s.Role.Name == Enum.GetName(typeof(Roles), Roles.Administrator) 
                || s.Role.Name == Enum.GetName(typeof(Roles), Roles.Employee))).ToList();
            }

            sdgvUsers.DataSource = data;
            Helpers.Helper.TranslationForDgvButtons(this, sdgvUsers);

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
                var elementIndex = (currentRow.Rows.Count / 10) <= 1 ? e.RowIndex : (currentRow.Rows.Count / 10) * 10 + e.RowIndex;
                //ne moze pretvoriti fullname u properti jer nije properti nego konkretno polje 
                var selectedRow = Helpers.Helper.CreateItemFromRow<UserDto>(currentRow.Rows[elementIndex]);

                if (e.ColumnIndex == 1)
                {
                    frmUserDetails frmUserDetails = new frmUserDetails(selectedRow);
                    frmUserDetails.Owner = this;
                    Enabled = false;
                    frmUserDetails.Show();
                }
            }
        }
    }
}
