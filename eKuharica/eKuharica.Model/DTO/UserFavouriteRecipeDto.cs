﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.DTO
{
    public class UserFavouriteRecipeDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RecipeId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
