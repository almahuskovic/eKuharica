using eKuharica.Mobile.Resources;
using eKuharica.Mobile.Views;
using Plugin.Multilingual;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKuharica.Mobile.ViewModels
{
    public class IndexViewModel : BaseViewModel
    {
        public IndexViewModel()
        {
            ChangeLanguageToBsCommand = new Command(async () => await ChangeLanguageToBs());
            ChangeLanguageToEnCommand = new Command(async () => await ChangeLanguageToEn());
        }
        public ICommand ChangeLanguageToBsCommand { get; set; }
        public ICommand ChangeLanguageToEnCommand { get; set; }

        public async Task ChangeLanguageToBs()
        {
            var info = new CultureInfo("bs",false);
            CrossMultilingual.Current.CurrentCultureInfo = Thread.CurrentThread.CurrentCulture = info;
            (Application.Current).MainPage = new MainPage();
        }
        public async Task ChangeLanguageToEn()
        {
            var info = new CultureInfo("en", false);
            CrossMultilingual.Current.CurrentCultureInfo = Thread.CurrentThread.CurrentCulture = info;
            (Application.Current).MainPage = new MainPage();
        }
    }
}
