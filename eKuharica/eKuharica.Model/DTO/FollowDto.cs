using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.DTO
{
    public class FollowDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FollowerId { get; set; }
        public string UserName { get; set; }
        public string FollowerName { get; set; }
    }
}
