using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKuharica.Mobile.ViewModels
{
    public class UserDetailsViewModel : BaseViewModel
    {
        private readonly APIService _userService = new APIService("User");
        private readonly APIService _followService = new APIService("Follow");
        private string _username { get; set; }
        public UserDetailsViewModel(string username)
        {
            InitCommand = new Command(async () => await Init());
            _username = username;
        }

        public UserDto user = null;
        public UserDto User
        {
            get { return user; }
            set { SetProperty(ref user, value); }
        }

        string _followers = string.Empty;
        public string Followers
        {
            get { return _followers; }
            set { SetProperty(ref _followers, value); }
        }

        string _following = string.Empty;
        public string Following
        {
            get { return _following; }
            set { SetProperty(ref _following, value); }
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            User = (await _userService.Get<List<UserDto>>(new UserSearchRequest() {UserName = _username })).First();
            Following = (await _followService.Get<List<FollowDto>>(new FollowSearchRequest() { UserId = User.Id })).Count().ToString();
            Followers = (await _followService.Get<List<FollowDto>>(new FollowSearchRequest() { FollowerId = User.Id })).Count().ToString();
        }
    }
}
