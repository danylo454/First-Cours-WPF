using Cours.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for RegOrLoginWindow.xaml
    /// </summary>
    public partial class RegOrLoginWindow : Window
    {
        public RegOrLoginWindow()
        {
            InitializeComponent();
            nameTextBox.Background = Brushes.IndianRed;
            loginTextBox.Background = Brushes.IndianRed;
            surnameTextBox.Background = Brushes.IndianRed;
            passwordTextBox.Background = Brushes.IndianRed;
            repitPswdTextBox.Background = Brushes.IndianRed;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void cancelBtm_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void registerBtm_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.Login = loginTextBox.Text;
            user.Name = nameTextBox.Text;
            user.SurName = surnameTextBox.Text;
            user.Password = passwordTextBox.Password;
            DbServiseClass.AddUser(user);
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == nameTextBox)
            {
                if (nameTextBox.Text.Length < 3)
                {
                    nameTextBox.Background = Brushes.IndianRed;
                }
                else
                {
                    nameTextBox.Background = Brushes.Transparent;
                }
            }
            else if (sender == loginTextBox)
            {
                if (loginTextBox.Text.Length < 4)
                {
                    loginTextBox.Background = Brushes.IndianRed;
                }
                else
                {
                    loginTextBox.Background = Brushes.Transparent;
                }
            }
            else if (sender == surnameTextBox)
            {
                if (surnameTextBox.Text.Length < 3)
                {
                    surnameTextBox.Background = Brushes.IndianRed;
                }
                else
                {
                    surnameTextBox.Background = Brushes.Transparent;
                }
            }
            EnableRegisterBtm();
        }

        private void passwordTextBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            string passwdPattern = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$";
            var regexPasswd = new Regex(passwdPattern);
            if (regexPasswd.IsMatch(passwordTextBox.Password.Substring(0).ToString()) == true && passwordTextBox.Password == repitPswdTextBox.Password)
            {
                passwordTextBox.Background = Brushes.Transparent;
                repitPswdTextBox.Background = Brushes.Transparent;
            }
            else
            {
                passwordTextBox.Background = Brushes.IndianRed;
                repitPswdTextBox.Background = Brushes.IndianRed;
            }
            EnableRegisterBtm();
        }
        private void EnableRegisterBtm()
        {
            if (nameTextBox.Background != Brushes.IndianRed &&
                surnameTextBox.Background != Brushes.IndianRed &&
                loginTextBox.Background != Brushes.IndianRed &&
                passwordTextBox.Background != Brushes.IndianRed &&
                repitPswdTextBox.Background != Brushes.IndianRed)
            {
                registerBtm.IsEnabled = true;
            }
            else
            {
                registerBtm.IsEnabled = false;
            }
        }
    }
}
