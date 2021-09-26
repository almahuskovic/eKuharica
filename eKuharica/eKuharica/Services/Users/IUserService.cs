using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKuharica.Model.Entities;

namespace eKuharica.Services.Users
{
    public interface IUserService
    {
        List<User> Get();
    }
}
