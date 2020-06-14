using System;
using System.ComponentModel.DataAnnotations;
using Windows.UI.Xaml.Data;

namespace DotaMax.Converter
{
    internal class DateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            try
            {
                if (value != null)
                {
                    DateTime dateTime = System.Convert.ToDateTime(value);

                    TimeSpan span = DateTime.Now - dateTime;
                    if (span.TotalDays > 365)
                    {
                        return System.Convert.ToInt32(span.TotalDays / 365) + "年前";
                    }
                    else if (span.TotalDays > 30)
                    {
                        return System.Convert.ToInt32(span.TotalDays / 30) + "个月前";
                    }
                    else if (span.TotalDays > 7)
                    {
                        return System.Convert.ToInt32(span.TotalDays / 7) + "周前";
                    }
                    else if (span.TotalDays > 1)
                    {
                        return System.Convert.ToInt32(span.TotalDays) + "天前";
                    }
                    else if (span.TotalHours > 1)
                    {
                        return System.Convert.ToInt32(span.TotalHours) + "小时前";
                    }
                    else if (span.TotalMinutes > 1)
                    {
                        return System.Convert.ToInt32(span.TotalMinutes) + "分钟前";
                    }
                    else if (span.TotalSeconds >= 1)
                    {
                        return System.Convert.ToInt32(span.TotalSeconds) + "秒前";
                    }
                    else
                    {
                        return value;
                    }
                }
            }
            catch
            { }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null;
        }
    }
}
