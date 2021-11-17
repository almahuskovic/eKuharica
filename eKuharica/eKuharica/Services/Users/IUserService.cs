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
    public interface IUserService
    {
        List<UserDto> Get(UserSearchRequest search);
        UserDto GetById(int id);
        UserDto Insert(UserInsertRequest request);
        UserDto Update(int id, UserUpdateRequest user);
        Task<UserDto> Login(string username, string password);
    }
}
