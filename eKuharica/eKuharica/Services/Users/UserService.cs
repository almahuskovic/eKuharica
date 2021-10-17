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
    public class UserService : BaseReadService<UserDto, User, UserSearchRequest>, IUserService
    {
        public UserService(Context context, IMapper mapper):base(context,mapper)
        {
        }

        public override IEnumerable<UserDto> Get(UserSearchRequest request)
        {
            var query = Context.User.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.FirstName))
                query = query.Where(x => x.FirstName.Contains(request.FirstName));

            var list = query.ToList();
            return _mapper.Map<List<UserDto>>(list);
        }
        public User Insert(UserInsertRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
