using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eKuharica.Model.Entities
{
    [Table("UserRecipeRatings")]
    public class UserRecipeRating
    {
        public int Id { get; set; }
        public int Rating { get; set; }

        [Required, ForeignKey(nameof(Recipe)), Range(1, int.MaxValue)]
        public int RecipeId { get; set; }
        public virtual Recipe Recipe { get; set; }

        [Required, ForeignKey(nameof(User)), Range(1, int.MaxValue)]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
