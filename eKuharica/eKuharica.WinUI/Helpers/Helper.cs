using eKuharica.Model.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        #region EnumerationSelectLists
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
        #endregion
    }
}
