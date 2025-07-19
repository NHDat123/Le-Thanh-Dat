using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;

namespace OrderCoffeeApp.Converters
{
    public class StringToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            try
            {
                string str = value as string;
                return string.IsNullOrWhiteSpace(str) ? Visibility.Collapsed : Visibility.Visible;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi (nếu cần)
                System.Diagnostics.Debug.WriteLine($"Error in StringToVisibilityConverter: {ex.Message}");
                // Trả về giá trị mặc định
                return Visibility.Collapsed;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
