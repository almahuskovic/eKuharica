using eKuharica.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKuharica.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserDetailsPage : ContentPage
    {
        UserDetailsViewModel model = null;
        public UserDetailsPage(string username)
        {
            InitializeComponent();
            BindingContext = model = new UserDetailsViewModel(username);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}