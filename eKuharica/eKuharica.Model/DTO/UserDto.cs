using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.DTO
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public byte[] Picture{ get; set; }
        public string FullName { get; set; }
        public DateTime CreatedAt { get; set; } 

        public ICollection<UserRoleDto> UserRoles { get; set; }


        //public string FullName => FirstName + " " + LastName;
    }
}
