using System;
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
    }
}
