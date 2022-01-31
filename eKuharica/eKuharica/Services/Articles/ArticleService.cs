using AutoMapper;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.Articles
{
    public class ArticleService : BaseCRUDService<ArticleDto, Article, ArticleSearchRequest, ArticleUpsertRequest, ArticleUpsertRequest>, IArticleService
    {
        public ArticleService(Context context, IMapper mapper) : base(context, mapper)
        {
        }
        public override IEnumerable<ArticleDto> Get(ArticleSearchRequest search = null)
        {
            var entity = Context.Set<Article>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Title))
            {
                entity = entity.Where(x => x.Title.ToLower().Contains(search.Title.ToLower()));
            }

            if (!search.LoggedUserHasPermissions)
                entity = entity.Where(x => x.IsTranslated);

            var list = entity.ToList();
            var mappedList = _mapper.Map<List<ArticleDto>>(list);
            mappedList.ForEach(x => x.IsCreatedByLoggedUser = (x.CreateUserId == search.LoggedUserId));

            return mappedList;
        }
    }
}
