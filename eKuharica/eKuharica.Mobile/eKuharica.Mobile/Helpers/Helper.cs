using eKuharica.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using static eKuharica.Model.Enumerations.Enumerations;

namespace eKuharica.Mobile.Helpers
{
    public static class Helper
    {
        public static List<EnumItem> MealTypeToList()
        {
            var mealTypes = Enum.GetValues(typeof(MealType)).Cast<MealType>().ToList();
            var mealTypesMappedList = mealTypes.Select(x => new EnumItem
            {
                Index = (int)x,
                Value = Enum.GetName(typeof(MealType), (int)x)
            }).ToList();

            //mealTypesMappedList.Insert(0, new EnumItem() { Index = 0, Value = "Vrsta jela" });
            return mealTypesMappedList;
        }

        public static List<EnumItem> WeightOfPreparationToList()
        {
            var weightOfPreparation = Enum.GetValues(typeof(WeightOfPreparation)).Cast<WeightOfPreparation>().ToList();
           
            var weightOfPreparationMappedList= weightOfPreparation.Select(x => new EnumItem
            {
                Index = (int)x,
                Value = Enum.GetName(typeof(WeightOfPreparation), (int)x)
            }).ToList();

            //weightOfPreparationMappedList.Insert(0, new EnumItem() { Index = 0, Value = "Tezina pripreme" });
            return weightOfPreparationMappedList;
        }

        public static List<EnumItem> PreparationTimeCategoryToList()
        {
            var preparationTimeCategory = Enum.GetValues(typeof(PreparationTimeCategory)).Cast<PreparationTimeCategory>().ToList();
            var preparationTimeCategoryMappedList= preparationTimeCategory.Select(x => new EnumItem
            {
                Index = (int)x,
                Value = Enum.GetName(typeof(PreparationTimeCategory), (int)x)
            }).ToList();

            //preparationTimeCategoryMappedList.Insert(0, new EnumItem() { Index = 0, Value = "Vrijeme pripreme" });
            return preparationTimeCategoryMappedList;
        }
    }
}
