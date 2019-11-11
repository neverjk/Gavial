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
        public GlavnoeOkno()
        {
            var color_query =
        from PropertyInfo property in typeof(Colors).GetProperties()
        orderby property.Name
                 //orderby ((Color)property.GetValue(null, null)).ToString()
                 select new ColorInfo(
            property.Name,
            (Color)property.GetValue(null, null));

            InitializeComponent();
            ColorCB.ItemsSource = color_query;


        }
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }


        private ComboBox FillSize()
        {
            ComboBox box;
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            //box.Items.Add();
    
            return null;
        }
    }
}
