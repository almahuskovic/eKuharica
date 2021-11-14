using eKuharica.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.DTO
{
    public class UserRoleDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

        public DateTime ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
