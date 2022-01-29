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
    public partial class FeedbackPage : ContentPage
    {
        private FeedbackViewModel model = null;
        private bool isFromSendReicpe = false;
        public FeedbackPage(bool fromSendRecipe=false)
        {
            InitializeComponent();
            isFromSendReicpe = fromSendRecipe;
            BindingContext = model = new FeedbackViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            if (!isFromSendReicpe)
                BackButton.IsVisible = false;

            await model.Init();
        }
    }
}