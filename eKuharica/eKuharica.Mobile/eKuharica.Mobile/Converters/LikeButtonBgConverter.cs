using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace eKuharica.Mobile.Converters
{
    public class LikeButtonBgConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch (value)
            {
                case true:
                    return Color.Red;
                case false:
                    return Color.Gray;
            }

            return Color.Transparent;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
