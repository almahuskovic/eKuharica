using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.UserRecipeRatings
{
    public interface IUserRecipeRatingService : IBaseCRUDService<UserRecipeRatingDto, UserRecipeRatingSearchRequest, UserRecipeRatingUpsertRequest, UserRecipeRatingUpsertRequest>
    {
    }
}
