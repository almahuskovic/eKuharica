using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using eKuharica.Services.UserFavouriteRecipes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKuharica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserFavouriteRecipeController : BaseCRUDController<UserFavouriteRecipeDto, UserFavouriteRecipeSearchRequest, UserFavouriteRecipeUpsertRequest, UserFavouriteRecipeUpsertRequest>
    {
        public UserFavouriteRecipeController(IUserFavouriteRecipeService userFavouriteRecipeService)
           : base(userFavouriteRecipeService)
        {
        }
    }
}