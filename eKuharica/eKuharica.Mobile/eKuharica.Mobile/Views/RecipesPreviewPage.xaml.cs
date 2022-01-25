using eKuharica.Mobile.Converters;
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
    public partial class RecipesPreviewPage : ContentPage
    {
        private RecipesPreviewViewModel model = null;
        public RecipesPreviewPage(RecipeDto recipe)
        {
            InitializeComponent();
            BindingContext = model = new RecipesPreviewViewModel() { Recipe=recipe};
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.Gray))
                btn.BackgroundColor = Color.Red;
            else
                btn.BackgroundColor = Color.Gray;

            await model.Like();
        }

        private async void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            await model.Rating();
        }
    }
}