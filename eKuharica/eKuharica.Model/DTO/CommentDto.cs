using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.DTO
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int UserId { get; set; }
        public string User { get; set; }
        public int RecipeId { get; set; }
    }
}
