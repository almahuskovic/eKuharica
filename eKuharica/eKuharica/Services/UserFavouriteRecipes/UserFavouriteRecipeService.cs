using AutoMapper;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.UserFavouriteRecipes
{
    public class UserFavouriteRecipeService : BaseCRUDService<UserFavouriteRecipeDto, UserFavouriteRecipe,  UserFavouriteRecipeSearchRequest, UserFavouriteRecipeUpsertRequest, UserFavouriteRecipeUpsertRequest>, IUserFavouriteRecipeService
    {
        public UserFavouriteRecipeService(Context context, IMapper mapper) : base(context, mapper)
        {
        }
        public override IEnumerable<UserFavouriteRecipeDto> Get(UserFavouriteRecipeSearchRequest search = null)
        {
            var entity = Context.Set<UserFavouriteRecipe>().AsQueryable();
            var entityRecipe = Context.Set<Recipe>().AsQueryable();

            if (search.DataForReport)
            {
                if (search.MealTypeId != null && search.MealTypeId > 0)
                    return entityRecipe.Where(x => x.MealType == (int)search.MealTypeId).Select(x => new UserFavouriteRecipeDto()
                    {
                        Recipe = x.Title,
                        RecipeId = x.Id,
                        NumberOfLikes = entity.Where(t => t.RecipeId == x.Id).Count()
                    }).OrderByDescending(x => x.NumberOfLikes).ToList();
                else
                    return null;
            }

            if (search?.RecipeId > 0)
            {
                entity = entity.Where(x => x.RecipeId == search.RecipeId);
            }
            if (search?.UserId > 0)
            {
                entity = entity.Where(x => x.UserId == search.UserId);
            }

            var list = entity.ToList();
            return _mapper.Map<List<UserFavouriteRecipeDto>>(list);
        }
    }
}
