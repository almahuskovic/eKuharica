using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;
using Plugin.Multilingual;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKuharica.Mobile.ViewModels
{
    public class ArticlesViewModel : BaseViewModel
    {
        private readonly APIService _articleService = new APIService("Article");
        APIService _articleTranslationService = new APIService("ArticleTranslation");

        public ArticlesViewModel()
        {
            InitCommand = new Command(async () => await Init());
            TitleCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }
        public ICommand TitleCommand { get; set; }

        public ObservableCollection<ArticleDto> ArticleList { get; set; } = new ObservableCollection<ArticleDto>();

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

                var list = await _articleService.Get<IEnumerable<ArticleDto>>(searchRequest);

                if (CrossMultilingual.Current.CurrentCultureInfo.Name == "en")
                {
                    var translatedArticles = await _articleTranslationService.Get<List<ArticleTranslationDto>>(new RecipeTranslationSearchRequest() { Title = Title });
                    searchRequest.Title = "";
                    searchRequest.ArticleIds = translatedArticles.Select(x => x.Id).ToList();

                    list = await _articleService.Get<IEnumerable<ArticleDto>>(searchRequest);

                    list.ToList().ForEach(x =>
                    {
                        var temp = translatedArticles.Where(t => t.ArticleId == x.Id).First();
                        x.Title = temp.Title;
                        x.Content = temp.Content;
                        x.KeyWords = temp.KeyWords;
                    });
                }
                ArticleList.Clear();
                foreach (var article in list)
                {
                    ArticleList.Add(article);
                }
            }
        }

    }
}
