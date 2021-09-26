using eKuharica.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.Users
{
    public class UserService : IUserService
    {
        public Context Context { get; set; }
        public UserService(Context context)
        {
            Context = context;
        }
        public List<User> Get()
        {
            return Context.User.ToList();
        }
    }
}
