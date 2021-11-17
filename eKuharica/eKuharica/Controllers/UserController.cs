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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eKuharica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        public UserDto Insert([FromBody] UserInsertRequest request)
        {
            return _userService.Insert(request);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public UserDto Update(int id, [FromBody] UserUpdateRequest request)
        {
            return _userService.Update(id, request);
        }

        [HttpGet]
        public List<UserDto> Get([FromQuery] UserSearchRequest request)
        {
            return _userService.Get(request);
        }
    }
}