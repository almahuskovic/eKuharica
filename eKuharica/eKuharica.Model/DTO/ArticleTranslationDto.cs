using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.DTO
{
    public class ArticleTranslationDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string KeyWords { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int ArticleId { get; set; }
    }
}
