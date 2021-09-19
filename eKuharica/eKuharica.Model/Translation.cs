using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eKuharica.Model
{
    [Table("Translations")]
    public class Translation
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string TableName { get; set; }

        [StringLength(50)]
        public string ColumnName { get; set; }

        public string Value { get; set; }

        public int RowId { get; set; }

        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(Language))]
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
    }
}
