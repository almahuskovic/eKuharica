﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eKuharica.Model.Enumerations
{
    public class Enumerations
    {
        public enum MealType
        {
            Dessert=1,
            WarmAppetizer,
            ColdAppetizer,
            Salad,
            Soup,
            Drink,
            BreadAndRolls,
            SideDish,
            Sauce
        }
        public enum WeightOfPreparation
        {
            Easy = 1,
            Medium,
            Hard
        }
        public enum PreparationTimeCategory
        {
            LessThan30min=1,
            Btw30minAnd1h,
            Btw1hAnd2h,
            MoreThan2h
        }

        public enum Source
        {
            Index,
            Add,
            Edit,
            Other
        }
        public enum RecipeAddSource
        {
           frmRecipe,
           frmUserRecipe,
           frmMyRecipes,
           frmFavRecipes
        }

        public enum Roles
        {
            Administrator,
            Employee,
            User
        }

        public enum Languages
        {
            BA,
            ENG
        }

        public enum Months
        {
            Januar,
            Februar,
            Mart,
            April,
            Maj,
            Juni,
            Juli,
            August,
            Septembar,
            Oktobar,
            Novembar,
            Decembar
        }
    }
}
