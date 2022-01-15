using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eKuharica.Model.Enumerations
{
    public class Enumerations
    {
        public enum MealType
        {
            Dessert = 1,
            [Display(Name = "Warm Appetizer")]
            WarmAppetizer,
            [Display(Name = "Cold Appetizer")]
            ColdAppetizer,
            Salad,
            Soup,
            Drink,
            [Display(Name = "Bread And Rolls")]
            BreadAndRolls,
            [Display(Name = "Side Dish")]
            SideDish,
            Sauce
        }
        public enum VrsteJela
        {
            Desert = 1,
            [Display(Name = "Toplo predjelo")]
            ToploPredjelo,
            [Display(Name = "Hladno predjelo")]
            HladnoPredjelo,
            Salata,
            Juha,
            Piće,
            [Display(Name = "Kruh i peciva")]
            KruhIPeciva,
            Prilozi,
            Sos
        }
        public enum WeightOfPreparation
        {
            Easy = 1,
            Medium,
            Hard
        }

        public enum TezinaPripreme
        {
            Jednostavno = 1,
            Srednje,
            Složeno
        }
        public enum PreparationTimeCategory
        {
            [Display(Name = "Less than 30min")]
            LessThan30min = 1,
            [Display(Name = "Between 30min and 1h")]
            Btw30minAnd1h,
            [Display(Name = "Between 1h and 2h")]
            Btw1hAnd2h,
            [Display(Name = "More than 2h")]
            MoreThan2h
        }

        public enum VrijemePripremeKategorije
        {
            [Display(Name = "Manje od 30min")]
            ManjeOd30min = 1,
            [Display(Name = "Između 30min i 1h")]
            Izmedju30minI1h,
            [Display(Name = "Između 1h i 2h")]
            Izmedju1hI2h,
            [Display(Name = "Više od 2h")]
            ViseOd2h
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
