using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKuharica.Mobile.ViewModels
{
    public class SendRecipeViewModel : BaseViewModel
    {
        private readonly APIService _recipeService = new APIService("Recipe");
        public SendRecipeViewModel()
        {
            Send = new Command(async () => await SendRecipe());
        }


        string _title = string.Empty;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        string _introduction = string.Empty;
        public string Introduction
        {
            get { return _introduction; }
            set { SetProperty(ref _introduction, value); }
        }

        string _ingredients = string.Empty;
        public string Ingredients
        {
            get { return _ingredients; }
            set { SetProperty(ref _ingredients, value); }
        }

        string _method = string.Empty;
        public string Method
        {
            get { return _method; }
            set { SetProperty(ref _method, value); }
        }

        string _serving = string.Empty;
        public string Serving
        {
            get { return _serving; }
            set { SetProperty(ref _serving, value); }
        }

        string _advice = string.Empty;
        public string Advice
        {
            get { return _advice; }
            set { SetProperty(ref _advice, value); }
        }

        string _preparationTime = string.Empty;
        public string PreparationTime
        {
            get { return _preparationTime; }
            set { SetProperty(ref _preparationTime, value); }
        }

        public ICommand Send { get; set; }

        public async Task SendRecipe()
        {
            
        }
    }
}
