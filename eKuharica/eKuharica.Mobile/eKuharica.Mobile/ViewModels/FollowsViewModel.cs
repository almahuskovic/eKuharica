using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKuharica.Mobile.ViewModels
{
    public class FollowsViewModel : BaseViewModel
    {
        private readonly APIService _followService = new APIService("Follow");
        private readonly APIService _userService = new APIService("User");
        private bool _getFollowers;
        public FollowsViewModel(bool getFollowers = false)
        {
            InitCommand = new Command(async () => await Init());
            _getFollowers = getFollowers;
        }

        public ObservableCollection<FollowDto> FollowList { get; set; } = new ObservableCollection<FollowDto>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var loggedUser= await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);

            FollowSearchRequest searchRequest = new FollowSearchRequest();

            if (_getFollowers)//ko sve prati ovog korisnika
                searchRequest.FollowerId = loggedUser.Id;
            else//koga prati ovaj korisnik
                searchRequest.UserId = loggedUser.Id;

            var list = await _followService.Get<IEnumerable<FollowDto>>(searchRequest);

            FollowList.Clear();
            foreach (var user in list)
            {
                FollowList.Add(user);
            }

        }
    }
}
