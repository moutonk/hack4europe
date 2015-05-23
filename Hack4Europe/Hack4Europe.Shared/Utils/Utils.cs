using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Hack4Europe.UserControls;
using Hack4Europe.ViewModel;

namespace Hack4Europe.Utils
{
    public static class All
    {
        public static int? ConvertStringToInt(string d)
        {
            int? num = 0;

            try
            {
                num = Int32.Parse(d, CultureInfo.InvariantCulture);
            }
            catch (Exception exp)
            {
                Logs.Error.ShowError(exp);
            }

            return num;
        }

        public static double? ConvertStringToDouble(string d)
        {
            double? num = 0;

            try
            {
                num = Double.Parse(d, CultureInfo.InvariantCulture);
            }
            catch (Exception exp)
            {
                Logs.Error.ShowError("ConvertStringToDouble: " + d, exp);
            }

            return num;
        }

        public static bool IsEmailValid(string email)
        {
            try
            {
                return Regex.IsMatch(email,
                      @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,24}))$",
                      RegexOptions.IgnoreCase);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DateTime ConvertFromUnixTimestamp(double? timestamp)
        {
            var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return timestamp == null ? origin : origin.AddMilliseconds((double)timestamp);
        }
    }

    public class DomoItemVisibilityConverters : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (targetType != typeof(Visibility))
                throw new InvalidOperationException("The target must be a Visibility");

            switch ((DomoItemControl.DomoItemType)value)
            {
                case DomoItemControl.DomoItemType.Temperature:
                    return Visibility.Visible;

                case DomoItemControl.DomoItemType.Cooling:
                    return Visibility.Visible;

                case DomoItemControl.DomoItemType.Heating:
                    return Visibility.Visible;

                case DomoItemControl.DomoItemType.Safety:
                    return Visibility.Collapsed;
                
                default:
                    return Visibility.Visible;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

    public class ActionCubeNumberVisibilityConverters : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (targetType != typeof(Visibility))
                throw new InvalidOperationException("The target must be a Visibility");

            if (string.IsNullOrWhiteSpace((string) value))
                return Visibility.Collapsed;
            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
