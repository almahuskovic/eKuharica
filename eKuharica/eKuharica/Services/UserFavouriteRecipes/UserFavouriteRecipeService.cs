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
    public class UserFavouriteRecipeService : BaseCRUDService<UserFavouriteRecipeDto, UserFavouriteRecipeService,  UserFavouriteRecipeSearchRequest, UserFavouriteRecipeUpsertRequest, UserFavouriteRecipeUpsertRequest>, IUserFavouriteRecipeService
    {
        public UserFavouriteRecipeService(Context context, IMapper mapper) : base(context, mapper)
        {
        }
        public override IEnumerable<UserFavouriteRecipeDto> Get(UserFavouriteRecipeSearchRequest search = null)
        {
            var entity = Context.Set<UserFavouriteRecipe>().AsQueryable();

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
