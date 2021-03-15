using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace CommonUI.Converters
{
    public class ValueOfWidthHeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //int item;
            //int.TryParse((string)value, out item);
            var result = value != null && (double)value < 100 ? "small" : "Big";
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}