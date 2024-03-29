﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.Models
{
    public class RecipeSearchObject
    {
        public string Title { get; set; }
        public int? PreparationTimeCategory { get; set; }
        public int? MealType { get; set; }
        public int? WeightOfPreparation { get; set; }

        public List<int> RecipeIds { get; set; }
        public bool IsFavouriteRecipeSearch { get; set; }
        public bool ByUsers { get; set; }
        public bool MyRecipes { get; set; }
        public int LoggedUserId { get; set; }

        public bool LoggedUserHasPermissions { get; set; }
    }
}
