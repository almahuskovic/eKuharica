using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eKuharica.Model
{
    [Table("Feedbacks")]
    public class Feedback
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

        [Required, ForeignKey(nameof(User)), Range(1, int.MaxValue)]
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }

    public enum Rating
    {

    }
}
