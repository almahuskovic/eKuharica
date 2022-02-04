using AutoMapper;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseCRUD;
using Microsoft.EntityFrameworkCore;
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
            var entity = Context.Set<RecipeTranslation>().Include("Recipe").AsQueryable();

            if (search.RecipeId > 0)
            {
                entity = entity.Where(x => x.RecipeId == search.RecipeId);
            }
            if (search.RecipeIds != null && search.RecipeIds.Count > 0)
            {
                entity = entity.Where(x => search.RecipeIds.Contains(x.RecipeId));
            }
            if (!string.IsNullOrWhiteSpace(search.Title))
            {
                entity = entity.Where(x => x.Title.ToLower().Contains(search.Title.ToLower()));
            }

            var list = entity.ToList();
            return _mapper.Map<List<RecipeTranslationDto>>(list);
        }

    }
}
