using eKuharica.Mobile.Extensions;
using eKuharica.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKuharica.Mobile.ViewModels
{
    public class LoginViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("User");
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }

        string _username = string.Empty;
        public string Username 
        {
            get { return _username; }
            set { SetProperty(ref _username, value); } 
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password))
                {
                    IsBusy = true;
                    APIService.Username = Username;
                    APIService.Password = Password;
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert(
                        new TranslateExtension() { Text = "Greška" }.ProvideValue().ToString(),
                        new TranslateExtension() { Text = "NisteUnijeliKorisničkoImeIliLozinku" }.ProvideValue().ToString(),
                        new TranslateExtension() { Text = "OK" }.ProvideValue().ToString());
                    return;
                }

                await _service.Get<dynamic>(null);
                Application.Current.MainPage = new MainPage();
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert(
                        new TranslateExtension() { Text = "Greška" }.ProvideValue().ToString(),
                        new TranslateExtension() { Text = "PogrešnoKorisničkoImeIliLozinka" }.ProvideValue().ToString(),
                        new TranslateExtension() { Text = "OK" }.ProvideValue().ToString());
                return;
            }
        }
    }
}
