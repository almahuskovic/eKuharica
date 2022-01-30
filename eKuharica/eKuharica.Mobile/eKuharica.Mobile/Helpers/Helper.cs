using eKuharica.Mobile.Extensions;
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
            var mealTypes = Enum.GetValues(typeof(VrsteJela)).Cast<VrsteJela>().ToList();
            var mealTypesMappedList = mealTypes.Select(x => new EnumItem
            {
                Index = (int)x,
                Value = new TranslateExtension() { Text = Enum.GetName(typeof(VrsteJela), (int)x) }.ProvideValue().ToString()
            }).ToList();

            return mealTypesMappedList;
        }

        public static List<EnumItem> WeightOfPreparationToList()
        {
            var weightOfPreparation = Enum.GetValues(typeof(TezinaPripreme)).Cast<TezinaPripreme>().ToList();
           
            var weightOfPreparationMappedList= weightOfPreparation.Select(x => new EnumItem
            {
                Index = (int)x,
                Value = new TranslateExtension() { Text = Enum.GetName(typeof(TezinaPripreme), (int)x) }.ProvideValue().ToString()
            }).ToList();

            return weightOfPreparationMappedList;
        }

        public static List<EnumItem> PreparationTimeCategoryToList()
        {
            var preparationTimeCategory = Enum.GetValues(typeof(VrijemePripremeKategorije)).Cast<VrijemePripremeKategorije>().ToList();
            var preparationTimeCategoryMappedList= preparationTimeCategory.Select(x => new EnumItem
            {
                Index = (int)x,
                Value = new TranslateExtension() { Text = Enum.GetName(typeof(VrijemePripremeKategorije), (int)x) }.ProvideValue().ToString()
            }).ToList();

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
