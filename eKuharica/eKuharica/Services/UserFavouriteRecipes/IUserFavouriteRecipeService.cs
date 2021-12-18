using eKuharica.Model.DTO;
using eKuharica.Model.Models;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.UserFavouriteRecipes
{
    public interface IUserFavouriteRecipeService :IBaseCRUDService<UserFavouriteRecipeDto, UserFavouriteRecipeSearchRequest, UserFavouriteRecipeUpsertRequest, UserFavouriteRecipeUpsertRequest>
    {
    }
}
