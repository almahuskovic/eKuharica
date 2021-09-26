using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eKuharica.Model.Entities
{
    [Table("Articles")]
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string KeyWords { get; set; }
        public byte[] Picture { get; set; }
        public byte[] PictureThumb { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(User))]
        public int CreateUserId { get; set; }
        public virtual User User { get; set; }
    }
}
