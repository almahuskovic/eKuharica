using eKuharica.Mobile.Resources;
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
            ChangeLanguageToBsCommand = new Command(async () => await ChangeLanguageBs());
            ChangeLanguageToEnCommand = new Command(async () => await ChangeLanguageToEn());
        }
        public ICommand ChangeLanguageToBsCommand { get; set; }
        public ICommand ChangeLanguageToEnCommand { get; set; }

        StringResource stringResource = new StringResource("", "");
        public async Task ChangeLanguageBs()
        {
            var info = new CultureInfo("bs",false);
            Thread.CurrentThread.CurrentCulture = info;
        }
        public async Task ChangeLanguageToEn()
        {
            var info = new CultureInfo("en", false);
            Thread.CurrentThread.CurrentCulture = info;
        }
    }
}
