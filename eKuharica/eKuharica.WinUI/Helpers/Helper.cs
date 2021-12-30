using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eKuharica.Model.Enumerations.Enumerations;

namespace eKuharica.WinUI.Helpers
{
    public static class Helper
    {
        public async static Task<UserDto> GetLoggedUser(APIService userService, string username)
        {
            return (await userService.Get<List<UserDto>>(new UserSearchRequest() { UserName = username })).FirstOrDefault();
        }

        #region BindingDataToDgvAndReverse
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
        public static List<RecipeDto> ToRecipeDto(DataTable dt)
        {
            var convertedList = (from rw in dt.AsEnumerable()
                                    select new RecipeDto()
                                    {
                                        Title = Convert.ToString(rw["Title"]),
                                        Advice = Convert.ToString(rw["Advice"]),
                                        Content = Convert.ToString(rw["Content"]),
                                        UserId = Convert.ToInt32(rw["UserId"])
                                    }).ToList();

            return convertedList;
        }

        public static void SetItemFromRow<T>(T item, DataRow row) where T : new()
        {
            // go through each column
            foreach (DataColumn c in row.Table.Columns)
            {
                // find the property for the column
                PropertyInfo p = item.GetType().GetProperty(c.ColumnName);

                // if exists, set the value
                if (p != null && row[c] != DBNull.Value)
                {
                    p.SetValue(item, row[c], null);
                }
            }
        }
        //map to certain object
        public static T CreateItemFromRow<T>(DataRow row) where T : new()
        {
            // create a new object
            T item = new T();

            // set the item
            SetItemFromRow(item, row);

            // return 
            return item;
        }

        public static DataTable BindingListToDataTable(this BindingList<DataTable> bs)
        {
            DataTable dt = null;
            int counter = 1;
            foreach (var dtItem in bs)
            {
                foreach (DataRow dr in dtItem.Rows)
                {
                    if (counter == 1)
                    {
                        dt = dtItem.Clone();
                        counter++;
                    }
                    dt.Rows.Add(dr.ItemArray);
                }
            }
            return dt;
        }
        #endregion

        #region PictureConvertor

        public static byte[] ImageToByteArray(Image imageIn)
        {
            if(imageIn != null)
            {
                using (var ms = new MemoryStream())
                {
                    imageIn.Save(ms, imageIn.RawFormat);
                    return ms.ToArray();
                }
            }
            return null;
        }
        public static Image ByteArrayToImage(byte[] bytesArr)
        {
            if (bytesArr.Length > 0)
            {
                using (MemoryStream memstr = new MemoryStream(bytesArr))
                {
                    Image img = Image.FromStream(memstr);
                    return img;
                }
            }
            return null;
        }

        #endregion

        #region SelectLists
        //TODO:refaktorisanje, napraviti univerzalnu fn za convert enuma u listu
        public static List<MealType> MealTypeToSelectList()
        {
            var mealTypes = Enum.GetValues(typeof(MealType)).Cast<MealType>().ToList();
            mealTypes.Insert(0, new MealType());
            return mealTypes;
        }

        public static List<WeightOfPreparation> WeightOfPreparationToSelectList()
        {
            var weightOfPreparation = Enum.GetValues(typeof(WeightOfPreparation)).Cast<WeightOfPreparation>().ToList();
            weightOfPreparation.Insert(0, new WeightOfPreparation());
            return weightOfPreparation;
        }

        public static List<PreparationTimeCategory> PreparationTimeCategoryToSelectList()
        {
            var preparationTimeCategory = Enum.GetValues(typeof(PreparationTimeCategory)).Cast<PreparationTimeCategory>().ToList();
            preparationTimeCategory.Insert(0, new PreparationTimeCategory());
            return preparationTimeCategory;
        }

        public static List<int> RatingSelectList()
        {
            var list = new List<int>();

            for (int i = 0; i < 6; i++)
                list.Add(i);

            return list;
        }

        #endregion
        public static string GenerateCommentsDisplayList(List<CommentDto> comments)
        {
            var commentsList = "";
            foreach (var comment in comments)
            {
                commentsList += comment.User + ":" + Environment.NewLine + comment.Description + Environment.NewLine;
            }
            return commentsList;
        }
        public static void CloseAllOpenForms()
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "frmWelcome" && f.Name !="frmLogin")
                    f.Close();
            }
        }

        public static bool IsAdministrator(UserDto user)
        {
            for (int i = 0; i < user.UserRoles.Count() ; i++)
            {
                if ((user.UserRoles as List<UserRoleDto>)[i].Role.Name == Enum.GetName(typeof(Roles), Roles.Administrator))
                    return true;
            }
            return false;
        }
    }
}
