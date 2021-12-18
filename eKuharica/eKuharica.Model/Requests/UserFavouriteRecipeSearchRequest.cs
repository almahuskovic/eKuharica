using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.Requests
{
    public class UserFavouriteRecipeSearchRequest
    {
        public int UserId { get; set; }
        public int RecipeId { get; set; }
    }
}
