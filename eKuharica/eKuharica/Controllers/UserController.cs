using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKuharica.Model;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;
using eKuharica.Services;
using eKuharica.Services.Users;
using Microsoft.AspNetCore.Mvc;

namespace eKuharica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : BaseReadController<UserDto, object>
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService):base(userService)
        {
            _userService = userService;
        }
       
        [HttpPost]
        public User Insert([FromBody] UserInsertRequest request)
        {
            return _userService.Insert(request);
        }
    }
}