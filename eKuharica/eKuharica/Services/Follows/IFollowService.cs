using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.Follows
{
    public interface IFollowService : IBaseCRUDService<FollowDto, FollowSearchRequest, FollowUpsertRequest, FollowUpsertRequest>
    {
        public IEnumerable<FollowDto> GetUserFollowers(int userId);
        public IEnumerable<FollowDto> GetWhoUserFollows(int userId);
    }
}
