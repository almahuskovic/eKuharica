using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.Requests
{
    public class ArticleSearchRequest
    {
        public string Title { get; set; }
        public int LoggedUserId { get; set; }
        public List<int> ArticleIds { get; set; }
        public bool LoggedUserHasPermissions { get; set; }
    }
}
