using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using eKuharica.Services.UserRecipeRatings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKuharica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRecipeRatingController : BaseCRUDController<UserRecipeRatingDto, UserRecipeRatingSearchRequest, UserRecipeRatingUpsertRequest, UserRecipeRatingUpsertRequest>
    {
        public UserRecipeRatingController(IUserRecipeRatingService userRecipeRatingService)
          : base(userRecipeRatingService)
        {
        }
    }
}