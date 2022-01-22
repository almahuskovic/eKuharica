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
    public partial class RecipeDetailsPage : ContentPage
    {
        private RecipeDetailsViewModel model = null;
        public RecipeDetailsPage(RecipeDto recipe)
        {
            InitializeComponent();
            BindingContext = model = new RecipeDetailsViewModel() { Recipe = recipe };
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}