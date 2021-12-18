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
    }
}
