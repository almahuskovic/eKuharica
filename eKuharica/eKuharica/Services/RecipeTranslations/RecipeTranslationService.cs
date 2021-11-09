using AutoMapper;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.RecipeTranslations
{
    public class RecipeTranslationService : BaseCRUDService<RecipeTranslationDto, RecipeTranslation, RecipeTranslationSearchRequest, RecipeTranslationUpsertRequest, RecipeTranslationUpsertRequest>, IRecipeTranslationService
    {
        public RecipeTranslationService(Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<RecipeTranslationDto> Get(RecipeTranslationSearchRequest search = null)
        {
            var entity = Context.Set<RecipeTranslation>().AsQueryable();

            if (search.RecipeId > 0)
            {
                entity = entity.Where(x => x.RecipeId == search.RecipeId);
            }

            var list = entity.ToList();
            return _mapper.Map<List<RecipeTranslationDto>>(list);
        }

    }
}
