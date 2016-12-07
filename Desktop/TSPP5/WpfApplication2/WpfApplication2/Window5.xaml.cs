using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// TSPP Lab 5
    /// <summary>
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1();
            a.Visibility = Visibility.Visible;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window2 a = new Window2();
            a.Visibility = Visibility.Visible;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Window3 a = new Window3();
            a.Visibility = Visibility.Visible;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Window4 a = new Window4();
            a.Visibility = Visibility.Visible;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Visibility = Visibility.Visible;
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Window6 a = new Window6();
            a.Visibility = Visibility.Visible;
        }
    }
}
