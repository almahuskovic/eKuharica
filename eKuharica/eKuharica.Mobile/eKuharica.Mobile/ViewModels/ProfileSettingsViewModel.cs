using eKuharica.Mobile.Extensions;
using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKuharica.Mobile.ViewModels
{
    public class ProfileSettingsViewModel : BaseViewModel
    {
        private readonly APIService _userService = new APIService("User");
        public ProfileSettingsViewModel()
        {
            InitCommand = new Command(async () => await Init());
            SubmitCommand = new Command(async () => await Submit());
        }

        UserDto _user = null;
        public UserDto User
        {
            get { return _user; }
            set { SetProperty(ref _user, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        string _confirmPassword = string.Empty;
        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set { SetProperty(ref _confirmPassword, value); }
        }

        public ICommand InitCommand { get; set; }
        public ICommand SubmitCommand { get; set; }

        public async Task Init() 
        {
            User = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);
            
        }
        public async Task Submit()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(ConfirmPassword))
                    throw new Exception();

                var updateUser = new UserUpdateRequest()
                {
                    FirstName = User.FirstName,
                    LastName = User.LastName,
                    Password = Password,
                    PasswordConfirm = ConfirmPassword,
                    Email = User.Email,
                    PhoneNumber = User.PhoneNumber,
                    Picture = User.Picture
                };

                await _userService.Update<UserUpdateRequest>(User.Id, updateUser);
                await Application.Current.MainPage.DisplayAlert(
                    new TranslateExtension() { Text = "Uspješno" }.ProvideValue().ToString(),
                    new TranslateExtension() { Text = "PodaciProfilaUspješnoIzmjenjeni" }.ProvideValue().ToString(),
                    new TranslateExtension() { Text = "OK" }.ProvideValue().ToString());
            }
            catch (Exception)
            {
                await Application.Current.MainPage.DisplayAlert( 
                    new TranslateExtension() { Text = "Greška" }.ProvideValue().ToString(),
                    new TranslateExtension() { Text = "DogodilaSeGreškaPrilikomUređivanjaProfila" }.ProvideValue().ToString(),
                    new TranslateExtension() { Text = "OK" }.ProvideValue().ToString());
                return;
            }
        }
    }
}
