using eKuharica.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.DTO
{
    public class FeedbackDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
