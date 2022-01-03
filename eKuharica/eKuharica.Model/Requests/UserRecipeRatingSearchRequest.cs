using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.Requests
{
    public class UserRecipeRatingSearchRequest
    {
        public int UserId { get; set; }
        public int RecipeId { get; set; }
        public int Rating { get; set; }
        public bool GetTop3 { get; set; }
    }
}
