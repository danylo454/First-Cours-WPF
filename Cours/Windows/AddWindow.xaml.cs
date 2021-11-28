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
using static Cours.NotebookClass;

namespace Cours.Windows
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        User u = null;
        public AddWindow(User user)
        {
            InitializeComponent();
            u = user;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void canselBtm_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addBtm_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(nameTextBox.Text) && String.IsNullOrEmpty(commentTexbox.Text) && greenRadioBtm.IsChecked == true || blueRadioBtm.IsChecked == true || redRadioBtm.IsChecked == true)
            {
            NotebookClass notebook = new NotebookClass();
            notebook.Login = u.Login;
            notebook.NameNotebook = nameTextBox.Text;
            if (greenRadioBtm.IsChecked == true)
                notebook.Priority = Сategories.Green;
            else if (blueRadioBtm.IsChecked == true)
                notebook.Priority = Сategories.Blue;
            else if (redRadioBtm.IsChecked == true)
                notebook.Priority = Сategories.Red;
            notebook.StartDo = calendarWith.DisplayDate;
            notebook.EndDo = calendarTo.DisplayDate;
                notebook.Comment = commentTexbox.Text;
            DbServiseClass.AddNotebook(notebook);
            this.Close();

            }
            else
            {
                MessageBox.Show("Enter all line pls!!!");
            }
        }
    }
}
