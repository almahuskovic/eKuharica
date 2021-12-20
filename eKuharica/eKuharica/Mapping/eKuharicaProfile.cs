using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;

namespace eKuharica.Mapping
{
    public class eKuharicaProfile : Profile
    {
        public eKuharicaProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserInsertRequest>().ReverseMap();
            CreateMap<User, UserUpdateRequest>().ReverseMap();
            CreateMap<UserRole, UserRoleDto>().ReverseMap();
            
            CreateMap<Recipe, RecipeDto>().ReverseMap();
            CreateMap<RecipeUpsertRequest, Recipe>();

            CreateMap<Follow, FollowDto>().ReverseMap();
            CreateMap<FollowUpsertRequest, Follow>();

            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<RoleUpsertRequest, Role>();

            CreateMap<Article, ArticleDto>().ReverseMap();
            CreateMap<ArticleUpsertRequest, Article>();

            CreateMap<ArticleTranslation, ArticleTranslationDto>().ReverseMap();
            CreateMap<ArticleTranslationUpsertRequest, ArticleTranslation>();

            CreateMap<RecipeTranslationDto, RecipeTranslation>().ReverseMap();
            CreateMap<RecipeTranslationUpsertRequest, RecipeTranslation>();  
            
            CreateMap<UserFavouriteRecipeDto, UserFavouriteRecipe>().ReverseMap();
            CreateMap<UserFavouriteRecipeUpsertRequest, UserFavouriteRecipe>();

            CreateMap<UserRecipeRatingDto, UserRecipeRating>().ReverseMap();
            CreateMap<UserRecipeRatingUpsertRequest, UserRecipeRating>();

            CreateMap<Feedback, FeedbackDto>();
        }
    }
}
