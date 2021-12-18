using AutoMapper;
using eKuharica.Model.DTO;
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
    }
}
