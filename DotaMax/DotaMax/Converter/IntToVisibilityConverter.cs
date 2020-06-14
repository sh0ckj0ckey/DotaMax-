using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace DotaMax.Converter
{
    public class IntToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string culture)
        {
            try
            {
                if (parameter == null && value != null)
                {
                    return int.Parse(value.ToString()) > 0 ? Visibility.Visible : Visibility.Collapsed;
                }
                else if (parameter != null && parameter.ToString() == "-")
                {
                    return int.Parse(value.ToString()) > 0 ? Visibility.Collapsed : Visibility.Visible;
                }
                else if (parameter != null && value != null)
                {
                    return parameter.ToString() == value.ToString() ? Visibility.Visible : Visibility.Collapsed;
                }
            }
            catch (Exception e1)
            {
                System.Diagnostics.Debug.WriteLine("IntToVisibleConvert " + e1.Message.ToString());
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string culture)
        {
            return null;
        }
    }
}
