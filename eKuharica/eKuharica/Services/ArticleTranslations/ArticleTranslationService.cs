using AutoMapper;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.ArticleTranslations
{
    public class ArticleTranslationService : BaseCRUDService<ArticleTranslationDto, ArticleTranslation, ArticleTranslationSearchRequest, ArticleTranslationUpsertRequest, ArticleTranslationUpsertRequest>, IArticleTranslationService
    {
        public ArticleTranslationService(Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<ArticleTranslationDto> Get(ArticleTranslationSearchRequest search = null)
        {
            var entity = Context.Set<ArticleTranslation>().AsQueryable();

            if (search.ArticleId > 0)
            {
                entity = entity.Where(x => x.ArticleId == search.ArticleId);
            }
            if (search.ArticleIds != null && search.ArticleIds.Count > 0)
            {
                entity = entity.Where(x => search.ArticleIds.Contains(x.ArticleId));
            }

            var list = entity.ToList();
            return _mapper.Map<List<ArticleTranslationDto>>(list);
        }
    }
}
