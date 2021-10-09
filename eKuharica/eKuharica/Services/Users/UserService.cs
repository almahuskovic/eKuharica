using AutoMapper;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseRead;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.Users
{
    public class UserService : BaseReadService<UserDto, User, object>, IUserService
    {
        public UserService(Context context, IMapper mapper):base(context,mapper)
        {
        }

        public User Insert(UserInsertRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
