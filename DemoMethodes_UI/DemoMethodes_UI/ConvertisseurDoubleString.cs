using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace DemoMethodes_UI
{
    [ValueConversion(typeof(string), typeof(double))]

    public class ConvertisseurDoubleString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double num;
            string chaine = value as string;
            if (double.TryParse(chaine, out num) && !chaine.EndsWith("."))
            {
                return num; // auto-boxing (transtypage vers objet Double automatique)
            }
            return DependencyProperty.UnsetValue;
        }
    }
}

