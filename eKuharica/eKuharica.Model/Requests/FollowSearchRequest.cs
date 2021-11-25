using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.Requests
{
    public class FollowSearchRequest
    {
        public int UserId { get; set; }
        public int FollowerId { get; set; }
    }
}
