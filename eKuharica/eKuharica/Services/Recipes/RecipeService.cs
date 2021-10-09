using AutoMapper;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Models;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseCRUD;
using eKuharica.Services.BaseRead;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.Recipes
{
    public class RecipeService : BaseCRUDService<RecipeDto,Recipe,RecipeSearchObject,RecipeInsertRequest,RecipeUpdateRequest>, IRecipeService
    {
        public RecipeService(Context context, IMapper mapper):base(context,mapper)
        {
        }
        public override IEnumerable<RecipeDto> Get(RecipeSearchObject search = null)
        {
            var entity = Context.Set<Recipe>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Title))
            {
                entity = entity.Where(x => x.Title.Contains(search.Title));
            }
            if (search.PreparationTimeCategory.HasValue)
            {
                entity = entity.Where(x => x.PreparationTimeCategory == search.PreparationTimeCategory);
            }
            if (search.WeightOfPreparation.HasValue)
            {
                entity = entity.Where(x => x.WeightOfPreparation == search.WeightOfPreparation);
            }

            var list = entity.ToList();
            return _mapper.Map<List<RecipeDto>>(list);

        }
    }
}
