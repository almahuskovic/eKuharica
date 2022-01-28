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
    public partial class IndexPage : ContentPage
    {
        private IndexViewModel model = null;
        public IndexPage()
        {
            InitializeComponent();
            BindingContext = model = new IndexViewModel() ;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.ChangeLanguageBs();
        }
    }
}