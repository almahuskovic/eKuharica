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
    public class RecipeService : BaseCRUDService<RecipeDto,Recipe,RecipeSearchObject, RecipeUpsertRequest, RecipeUpsertRequest>, IRecipeService
    {
        public RecipeService(Context context, IMapper mapper):base(context,mapper)
        {
        }
        public override IEnumerable<RecipeDto> Get(RecipeSearchObject search = null)
        {
            var entity = Context.Set<Recipe>().AsQueryable();

            if (!search.ByUsers)
            {
                if (search.IsFavouriteRecipeSearch && search.RecipeIds == null)
                {
                    return new List<RecipeDto>();
                }
                if(search.MyRecipes)//prikazi sve recepte od korisnika
                {
                    entity = entity.Where(x => x.UserId == search.LoggedUserId);
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(search?.Title))
                    {
                        entity = entity.Where(x => x.Title.ToLower().Contains(search.Title.ToLower()));
                    }
                    if (search.PreparationTimeCategory.HasValue)
                    {
                        entity = entity.Where(x => x.PreparationTimeCategory == search.PreparationTimeCategory);
                    }
                    if (search.WeightOfPreparation.HasValue)
                    {
                        entity = entity.Where(x => x.WeightOfPreparation == search.WeightOfPreparation);
                    }
                    if (search.MealType.HasValue)
                    {
                        entity = entity.Where(x => x.MealType == search.MealType);
                    }
                    if (search.RecipeIds != null && search.RecipeIds.Any())
                    {
                        entity = entity.Where(x => search.RecipeIds.Contains(x.Id));
                    }
                }

                entity = entity.Where(x => x.IsApproved);
            }
            else
            {
                entity = entity.Where(x => !x.IsApproved && x.IsSent);
            }

            var list = entity.ToList();
            return _mapper.Map<List<RecipeDto>>(list);
        }
    }
}
