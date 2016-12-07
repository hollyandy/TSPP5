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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int i=0,k=0,v=0,z=0;
        public MainWindow()
        {
            InitializeComponent();
            InitializeComponent();
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
 

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.ToString().Equals("* * * *") && textBox.IsFocused == true)
            {
                textBox.Text = "";
            }

           


        }

        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.ToString().Equals("") && textBox.IsFocused == false)
            {
                textBox.Text = "* * * *";
            }

        }

        private void button1_MouseDown(object sender, MouseButtonEventArgs e)
        {
        
        }

        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            passwordBox.Visibility = Visibility.Hidden;
            textBox1.Text = passwordBox.Password;
            textBox1.Visibility = Visibility.Visible;
        }

        private void button1_MouseLeave(object sender, MouseEventArgs e)
        {
            textBox1.Visibility = Visibility.Hidden;
            textBox1.Text= "";
            passwordBox.Visibility = Visibility.Visible;
        }

        private void Border1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (i == 0)
            {
                SolidColorBrush b = new SolidColorBrush();
               b.Color = Color.FromArgb(255, 243, 240, 240);
                i++;
            }
            else { 
            SolidColorBrush a = new SolidColorBrush();
            a.Color = Color.FromArgb(255, 255, 255, 161);
       
            }
            //#FFF3F0F0 207,207,207
            //#FFCFCFCF 243,240,240
        }

        private void Border1_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush a = new SolidColorBrush();
            a.Color = Color.FromArgb(255, 243, 240, 240);

        }


        private void textBox_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
          
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (z >= 1)
            {
                if (textBox.Text.ToString().Equals("* * * *"))
                {
                    image1.Visibility = Visibility.Hidden;
                    label1.Content = "";
                }
                else
                {

                    if (textBox.Text.ToString().Length < 4)
                    {
                        image1.Visibility = Visibility.Visible;
                        label1.Content = "Перевірте введений UI";
                    }

                    if (textBox.Text.ToString().Length == 4)
                    {
                        image1.Visibility = Visibility.Hidden;

                        label1.Content = "";
                    }
                }
            }
            else
            {
               z++;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.ToString().Equals("1111"))
            {
                MessageBox.Show("Ви успішно увійшли. Вітаємо!");
            }
            else
            { label1.Content = "Перевірте правильність введених даних"; }
        }

        private void textBox_Copy_TextChanged(object sender, TextChangedEventArgs e)
        { 
            if (v >= 1)
            {
                if (textBox.Text.ToString().Equals("* * * *"))
                {
                    image1.Visibility = Visibility.Hidden;
                    label1.Content = "";
                }
                else
                {

                    if (textBox.Text.ToString().Length < 4)
                    {
                        image1.Visibility = Visibility.Visible;
                        label1.Content = "Перевірте введений UI";
                    }

                    if (textBox.Text.ToString().Length == 4)
                    {
                        image1.Visibility = Visibility.Hidden;
                        label1.Content = "";

                    }
                }
            }
            else
            {
                v++;
            }
        }

        private void textBox_Copy1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (k >= 1)
            {
                if (textBox.Text.ToString().Equals("* * * *"))
                {
                    image1.Visibility = Visibility.Hidden;
                    label1.Content = "";
                }
                else {

                if (textBox.Text.ToString().Length< 4)
                {
                    image1.Visibility = Visibility.Visible;
                        label1.Content = "Перевірте введений UI";
                    }

                if (textBox.Text.ToString().Length == 4)
                { 

                    image1.Visibility = Visibility.Hidden;
                        label1.Content = "";
                    }
                }
            }
            else
            {
                k++;
            }

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
         
        }
    }
}
