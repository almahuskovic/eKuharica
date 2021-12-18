using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.Requests
{
    public class UserFavouriteRecipeUpsertRequest
    {
        public int UserId { get; set; }
        public int RecipeId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
