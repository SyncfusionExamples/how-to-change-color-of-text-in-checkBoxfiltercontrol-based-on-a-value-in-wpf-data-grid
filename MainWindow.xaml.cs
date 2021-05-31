using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace SfDataGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Get the CheckBox
            var checBox = value as CheckBox;

            //Get the content of CheckBox 
            var record = checBox.Content.ToString();

            //You can use a BrushConverter
            SolidColorBrush redBrush = (SolidColorBrush)new BrushConverter().ConvertFromString(record);

            //return the color based on DataBase text in GridFilterControl 
            return redBrush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
