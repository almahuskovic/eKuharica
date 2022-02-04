using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.Requests
{
    public class RecipeTranslationSearchRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int RecipeId { get; set; }
        public List<int> RecipeIds { get; set; }
    }
}
