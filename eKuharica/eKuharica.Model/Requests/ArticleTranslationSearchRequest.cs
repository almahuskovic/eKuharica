using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.Requests
{
    public class ArticleTranslationSearchRequest
    {
        public string Title { get; set; }
        public int ArticleId { get; set; }
        public List<int> ArticleIds { get; set; }
    }
}
