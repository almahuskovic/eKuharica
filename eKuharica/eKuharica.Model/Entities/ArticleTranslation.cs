using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eKuharica.Model.Entities
{
    [Table("ArticleTranslations")]
    public class ArticleTranslation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string KeyWords { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(Article))]
        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
    }
}
