using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.Requests
{
    public class CommentUpsertRequest
    {
        public string Description { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int UserId { get; set; }
        public int RecipeId { get; set; }
    }
}
