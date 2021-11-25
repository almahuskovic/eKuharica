using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using eKuharica.Services.Follows;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKuharica.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class FollowController : BaseCRUDController<FollowDto, FollowSearchRequest, FollowUpsertRequest, FollowUpsertRequest>
    {
        private readonly IFollowService _followService;
        public FollowController(IFollowService followService)
           : base(followService)
        {
            _followService = followService;
        }

        [HttpGet]
        [Route("[controller]/[action]/{id}")]
        public IEnumerable<FollowDto> GetUserFollowers(int id)
        {
            return _followService.GetUserFollowers(id);
        }

        [HttpGet]
        [Route("[controller]/[action]/{id}")]
        public IEnumerable<FollowDto> GetWhoUserFollows(int id)
        {
            return _followService.GetWhoUserFollows(id);
        }
    }
}