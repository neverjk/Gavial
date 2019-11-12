using MahApps.Metro.Controls;
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

namespace Gavial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class GlavnoeOkno : MetroWindow
    {
        IEnumerable<ColorInfo> colors;
        public GlavnoeOkno()
        {
            colors =
        from PropertyInfo property in typeof(Colors).GetProperties()
        orderby property.Name
                 //orderby ((Color)property.GetValue(null, null)).ToString()
                 select new ColorInfo(
            property.Name,
            (Color)property.GetValue(null, null));

            InitializeComponent();
            canvas.Height = canvas.Width;
            ColorCB.ItemsSource = colors;
            for(int i=1;i<21;i++)
            {
                SizeCB.Items.Add(i);
            }
           
        }


        
        private void SizeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ActualBrush.Height = Convert.ToInt32(SizeCB.SelectedItem);
            ActualBrush.Width = ActualBrush.Height;
        }

        private void ColorCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<ColorInfo> cls = colors.ToList();
            ActualBrush.Color = cls[ColorCB.SelectedIndex].Color;
            ColorCB.Text = cls[ColorCB.SelectedIndex].ColorName;
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ActualBrush.StylusTip = System.Windows.Ink.StylusTip.Rectangle;
        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            ActualBrush.StylusTip = System.Windows.Ink.StylusTip.Ellipse;
        }
    }
}
