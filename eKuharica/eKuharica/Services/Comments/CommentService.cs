using AutoMapper;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.Comments
{
    public class CommentService : BaseCRUDService<CommentDto, Comment, CommentSearchRequest, CommentUpsertRequest, CommentUpsertRequest>, ICommentService
    {
        public CommentService(Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<CommentDto> Get(CommentSearchRequest search = null)
        {
            var entity = Context.Set<Comment>().AsQueryable();
            var entityUsers = Context.Set<User>().AsQueryable();

            if (search != null && search.RecipeId > 0)
            {
                entity = entity.Where(x => x.RecipeId == search.RecipeId);
            }

            var list = entity.ToList();
            var mappedList = _mapper.Map<List<CommentDto>>(list);

            mappedList.ForEach(x=> x.User = entityUsers.Where(s => s.Id == x.UserId).FirstOrDefault().Username);

            return mappedList;
        }
    }
}
