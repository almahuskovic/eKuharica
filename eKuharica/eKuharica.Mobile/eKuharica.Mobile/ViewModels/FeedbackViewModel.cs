using eKuharica.Mobile.Extensions;
using eKuharica.Mobile.Models;
using eKuharica.Mobile.Views;
using eKuharica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKuharica.Mobile.ViewModels
{
    public class FeedbackViewModel : BaseViewModel
    {
        private readonly APIService _feedbackService = new APIService("Feedback");
        private readonly APIService _userService = new APIService("User");
        public FeedbackViewModel()
        {
            InitCommand = new Command(async () => await Init());
            SubmitCommand = new Command(async () => await Submit());
            BackCommand = new Command(async () => await Back());
        }
        public ObservableCollection<EnumItem> GradesList { get; set; } = new ObservableCollection<EnumItem>();
        EnumItem _selectedGrade = null;

        public EnumItem SelectedGrade
        {
            get { return _selectedGrade; }
            set
            {
                SetProperty(ref _selectedGrade, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        string _description = string.Empty;
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        public ICommand InitCommand { get; set; }
        public ICommand SubmitCommand { get; set; }
        public ICommand BackCommand { get; set; }
        public async Task Init()
        {
            if (GradesList.Count == 0)
            {
                for (int i = 1; i < 6; i++)
                {
                    GradesList.Add(new EnumItem() { Index = i, Value = i.ToString() });
                }
            }
        }
        public async Task Submit()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Description) && (SelectedGrade?.Index == null ||
                   SelectedGrade.Index == 0))
                {
                    throw new Exception();
                }

                var loggedUser = await Helpers.Helper.GetLoggedUser(_userService, APIService.Username);

                var feedback = new FeedbackUpsertRequest()
                {
                    Description = Description,
                    CreatedAt = DateTime.Now,
                    Rating = SelectedGrade != null ? SelectedGrade.Index : 0,
                    UserId = loggedUser.Id
                };

                await _feedbackService.Insert<FeedbackUpsertRequest>(feedback);
                await Application.Current.MainPage.DisplayAlert(
                    new TranslateExtension() { Text = "DojamUspješnospremljen" }.ProvideValue().ToString(),
                    new TranslateExtension() { Text = "Hvala" }.ProvideValue().ToString(),
                    new TranslateExtension() { Text = "OK" }.ProvideValue().ToString());
            }
            catch (Exception)
            {
                await Application.Current.MainPage.DisplayAlert(
                    new TranslateExtension() { Text = "Greška" }.ProvideValue().ToString(),
                    new TranslateExtension() { Text = "DogodilaSeGreška" }.ProvideValue().ToString(),
                    new TranslateExtension() { Text = "OK" }.ProvideValue().ToString());
                return;
            }
        }
        public async Task Back()
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}
