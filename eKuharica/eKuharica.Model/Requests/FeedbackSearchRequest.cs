using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.Requests
{
    public class FeedbackSearchRequest
    {
        public int Rating { get; set; }
        public string Username { get; set; }    
    }
}
