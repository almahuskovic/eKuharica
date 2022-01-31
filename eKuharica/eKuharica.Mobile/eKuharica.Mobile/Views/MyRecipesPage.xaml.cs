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
    public partial class MyRecipesPage : ContentPage
    {
        private MyRecipesViewModel model = null;
        private bool _displayFavourite = false;
        public MyRecipesPage(bool displayFavourite = false)
        {
            InitializeComponent();
            _displayFavourite = displayFavourite;
            BindingContext = model = new MyRecipesViewModel(displayFavourite);
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as RecipeDto;

            if (_displayFavourite)
            {
                item.IsLiked = true;
                Navigation.PushAsync(new RecipesPreviewPage(item));
            }
            else
                Navigation.PushAsync(new RecipeDetailsPage(item));   
        }
    }
}