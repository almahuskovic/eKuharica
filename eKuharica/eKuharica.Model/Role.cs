using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eKuharica.Model
{
    [Table("Roles")]
    public class Role
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
