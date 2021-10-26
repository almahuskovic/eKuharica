using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static eKuharica.Model.Enumerations.Enumerations;

namespace eKuharica.WinUI.Helpers
{
    public static class Helper
    {
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
