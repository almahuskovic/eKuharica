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
    public partial class RecommendPage : ContentPage
    {
        private RecommendViewModel model = null;
        public RecommendPage()
        {
            InitializeComponent();
            BindingContext = model = new RecommendViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as RecipeDto;

            await Navigation.PushAsync(new RecipesPreviewPage(item));
        }
    }
}