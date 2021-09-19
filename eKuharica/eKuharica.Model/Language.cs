using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eKuharica.Model
{
    [Table("Languages")]
    public class Language
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string CultureName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
