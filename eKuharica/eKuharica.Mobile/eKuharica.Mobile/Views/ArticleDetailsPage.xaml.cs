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
    public partial class ArticleDetailsPage : ContentPage
    {
        ArticleDetailsPageViewModel model = null;
        public ArticleDetailsPage(ArticleDto article)
        {
            InitializeComponent();
            BindingContext = model = new ArticleDetailsPageViewModel() { Article = article };
        }
    }
}