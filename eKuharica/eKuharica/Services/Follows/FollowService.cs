using AutoMapper;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.Follows
{
    public class FollowService : BaseCRUDService<FollowDto, Follow, FollowSearchRequest, FollowUpsertRequest, FollowUpsertRequest>, IFollowService
    {
        public FollowService(Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<FollowDto> Get(FollowSearchRequest request = null)
        {
            var query = Context.Follow.AsQueryable();

            if (request.UserId > 0)
                query = query.Where(x => x.UserId == request.UserId);

            if (request.FollowerId > 0)
                query = query.Where(x => x.FollowerId == request.FollowerId);

            var list = query.ToList();

            return _mapper.Map<List<FollowDto>>(list);
        }

        public IEnumerable<FollowDto> GetUserFollowers(int userId)
        {
            var query = Context.Follow.AsQueryable();

            if (userId > 0)
                query = query.Where(x => x.FollowerId == userId);

            var list = query.ToList();

            return _mapper.Map<List<FollowDto>>(list);
        }

        public IEnumerable<FollowDto> GetWhoUserFollows(int userId)
        {
            var query = Context.Follow.AsQueryable();

            if (userId > 0)
                query = query.Where(x => x.UserId == userId);

            var list = query.ToList();

            return _mapper.Map<List<FollowDto>>(list);
        }
    }
}
