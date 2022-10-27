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

namespace WPF_Shovkun_PR6_UP
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void TB1_GotFocus(object sender, RoutedEventArgs e)

        {
            if (TB1.Text == String.Empty || TB1.Text == "Username")
            {
                TB1.Text = String.Empty;
                TB1.Foreground = Brushes.Black;
            }

        }

        private void TB1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TB1.Text == String.Empty || TB1.Text == "Username")
            {
                TB1.Text = "Username";
                TB1.Foreground = Brushes.Gray;
            }
        }

        private void TB2_GotFocus(object sender, RoutedEventArgs e)
        {
            TB2.Text = String.Empty;
            TB2.Foreground = Brushes.Black;
        }

        private void TB2_LostFocus(object sender, RoutedEventArgs e)
        {
            TB2.Text = "Password";
            TB2.Foreground = Brushes.Gray;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                if ((TB1.Text != String.Empty || TB1.Text == "User") && (TB2.Text != String.Empty || TB2.Text == "User"))
                {
                    Manager.Mainframe.Navigate(new Page2());
                }
                if ((TB1.Text == String.Empty || TB1.Text != "User") && (TB2.Text == String.Empty || TB2.Text != "User"))
                {
                    MessageBox.Show("Incorrect data");
                }
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
