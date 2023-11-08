using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private void RGBSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            Color rgb = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            SolidColorBrush brush = new SolidColorBrush(rgb);
            colorArea.Background = brush;
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            stockList.Items.Add(" R " + rSlider.Value + " G " + gSlider.Value + " B " + bSlider.Value);

        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;
            SolidColorBrush brush = new SolidColorBrush(color);
            colorArea.Background = brush;
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            string[] s = stockList.SelectedItem.ToString().Split(' ');
            rValue.Text = s[1];
            gValue.Text = s[3];
            bValue.Text = s[5];
        }
    }
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
