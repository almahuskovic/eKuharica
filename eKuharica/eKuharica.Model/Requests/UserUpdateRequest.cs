using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.Requests
{
    public class UserUpdateRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool? Status { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PasswordConfirm { get; set; }
        public byte[] Picture { get; set; }
    }
}
