using NewWpfApp.Attribiutes;
using NewWpfApp.Helpers;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace NewWpfApp.Convertes
{
    public class SpecializationToStringConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((Enum)value).GetAttributeOfType<NameAttribute>().Name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
