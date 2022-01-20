using eKuharica.Model.Entities;
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
    public class ArticlesViewModel : BaseViewModel
    {
        private readonly APIService _articleService = new APIService("Article");
        public ArticlesViewModel()
        {
            InitCommand = new Command(async () => await Init());
            TitleCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }
        public ICommand TitleCommand { get; set; }

        public ObservableCollection<Article> ArticleList { get; set; } = new ObservableCollection<Article>();

        string _title = string.Empty;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public async Task Init()
        {
           
            if (!string.IsNullOrWhiteSpace(Title))
            {
                ArticleSearchRequest searchRequest = new ArticleSearchRequest();
                searchRequest.Title = Title;

                var list = await _articleService.Get<IEnumerable<Article>>(searchRequest);
                ArticleList.Clear();
                foreach (var article in list)
                {
                    ArticleList.Add(article);
                }
            }
        }

    }
}
