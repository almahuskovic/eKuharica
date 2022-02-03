using AutoMapper;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.UserRecipeRatings
{
    public class UserRecipeRatingService : BaseCRUDService<UserRecipeRatingDto, UserRecipeRating, UserRecipeRatingSearchRequest, UserRecipeRatingUpsertRequest, UserRecipeRatingUpsertRequest>, IUserRecipeRatingService
    {
        public UserRecipeRatingService(Context context, IMapper mapper) : base(context, mapper)
        {
        }
        public override IEnumerable<UserRecipeRatingDto> Get(UserRecipeRatingSearchRequest search = null)
        {
            var entityRecipes = Context.Set<Recipe>().AsQueryable();
            var entity = Context.Set<UserRecipeRating>().AsQueryable();

            if (search != null)
            {
                if (search.GetTop3)
                {
                    return entity.GroupBy(x => x.RecipeId).Select(
                        g => new UserRecipeRatingDto()
                        {
                            RecipeId = g.Key,
                            AvgRating = (decimal)g.Sum(s => s.Rating) / g.Count(),
                            Recipe = entityRecipes.Where(r => r.Id == g.Key).FirstOrDefault().Title
                        }
                        ).OrderByDescending(x => x.AvgRating).Take(3).AsEnumerable();
                }
                if(search.UserId > 0)
                {
                    entity = entity.Where(x => x.UserId == search.UserId);
                }
                if (search.RecipeId > 0)
                {
                    entity = entity.Where(x => x.RecipeId == search.RecipeId);
                }
            }

            var list = entity.ToList();

            return _mapper.Map<List<UserRecipeRatingDto>>(list);
        }
    }
}
