using eKuharica.Mobile.Models;
using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static eKuharica.Model.Enumerations.Enumerations;

namespace eKuharica.Mobile.Helpers
{
    public static class Helper
    {
        #region GetFilterLists
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
        #endregion

        public async static Task<UserDto> GetLoggedUser(APIService userService, string username)
        {
            return (await userService.Get<List<UserDto>>(new UserSearchRequest() { UserName = username })).FirstOrDefault();
        }
        public static string GenerateCommentsDisplayList(List<CommentDto> comments)
        {
            var commentsList = "";
            foreach (var comment in comments)
            {
                commentsList += comment.User + ":" + Environment.NewLine + comment.Description + Environment.NewLine;
            }
            return commentsList;
        }
    }
}
