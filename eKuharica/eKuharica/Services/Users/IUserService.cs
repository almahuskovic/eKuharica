using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseRead;

namespace eKuharica.Services.Users
{
    public interface IUserService:IBaseReadService<UserDto, UserSearchRequest>
    {
        User Insert(UserInsertRequest request);
    }
}
