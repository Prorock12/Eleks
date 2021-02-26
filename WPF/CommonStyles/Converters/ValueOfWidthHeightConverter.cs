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
            var result = value != null && (int)value < 100 ? "small" : "Big";
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}