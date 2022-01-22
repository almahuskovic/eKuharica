using eKuharica.Mobile.ViewModels;
using eKuharica.Model.DTO;
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
    public partial class FollowsPage : ContentPage
    {
        private FollowsViewModel model = null;
        public FollowsPage(bool getFollowers=false)
        {
            InitializeComponent();
            BindingContext = model = new FollowsViewModel(getFollowers);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as FollowDto;

            Navigation.PushAsync(new UserDetailsPage(item.UserName));
        }
    }
}