using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.Requests
{
    public class UserRecipeRatingUpsertRequest
    {
        public int UserId { get; set; }
        public int RecipeId { get; set; }
        public int Rating { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
