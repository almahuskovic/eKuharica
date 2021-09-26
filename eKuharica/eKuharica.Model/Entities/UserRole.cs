using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eKuharica.Model.Entities
{
    [Table("UserRoles")]
    public class UserRole
    {
        public int Id { get; set; }

        [Required, ForeignKey(nameof(User)), Range(1, int.MaxValue)]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Required, ForeignKey(nameof(Role)), Range(1, int.MaxValue)]
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

        public DateTime ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
