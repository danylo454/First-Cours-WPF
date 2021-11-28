using Cours.Class;
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

namespace Cours.Windows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void cancelBtm_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void loginBtm_Click(object sender, RoutedEventArgs e)
        {
            User user = DbServiseClass.LoadUser(loginTextBox.Text, passwdTextBox.Password);
            if (user != null)
            {
                MainWindow main = new MainWindow(user);
                this.Visibility = Visibility.Hidden;
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show($"\tError\nPassword or login!!!");
            }
            

        }

        private void registerBtm_Click(object sender, RoutedEventArgs e)
        {
            Windows.RegOrLoginWindow reg = new RegOrLoginWindow();
            this.Visibility = Visibility.Hidden;
            reg.ShowDialog();
            this.Visibility = Visibility.Visible;
        }
    }
}
