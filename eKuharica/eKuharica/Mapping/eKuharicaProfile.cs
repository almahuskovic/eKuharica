﻿using System;
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
            CreateMap<User, UserDto>();
            CreateMap<Recipe, RecipeDto>();
            CreateMap<Feedback, FeedbackDto>();
            CreateMap<RecipeInsertRequest, Recipe>();
            CreateMap<RecipeUpdateRequest, Recipe>();
        }
    }
}