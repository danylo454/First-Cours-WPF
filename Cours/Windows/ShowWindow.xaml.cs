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
    /// Interaction logic for ShowWindow.xaml
    /// </summary>
    public partial class ShowWindow : Window
    {
        List<NotebookClass> list = null;
        User user = null;
        public ShowWindow(User user)
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.user = user;
            listViev.SelectedItem = null;
            UpdateList();
        }
        private void UpdateList()
        {

            int count = 0;
            listViev.Items.Clear();
            list = DbServiseClass.GetAllNotebooks();
            foreach (var item in list)
            {
                if (item.Login == user.Login)
                {
                    count++;
                    listViev.Items.Add(item);
                }
            }
            if (count == 0)
            {
                foreach (var item in menu.Items.OfType<Button>())
                {
                    item.IsEnabled = false;
                }
                exitBtm.IsEnabled = true;
            }
            else
            {
                foreach (var item in menu.Items.OfType<Button>())
                {
                    item.IsEnabled = true;
                }
            }
        }

        private void deleteBtm_Click(object sender, RoutedEventArgs e)
        {
            if (listViev.SelectedItem != null)
            {
                NotebookClass notebookClass = listViev.SelectedItem as NotebookClass;
                DbServiseClass.DeleteNotebook(notebookClass);
            }
            UpdateList();
        }

        private void ShowBtm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (listViev.SelectedItem != null)
                {
                    NotebookClass n = listViev.SelectedItem as NotebookClass;
                    MessageBox.Show($"Name: {n.NameNotebook}\n" +
                        $"Priority: {n.Priority}\n" +
                        $"Start do: {n.StartDo.ToString("d")}\n" +
                        $"End do: {n.EndDo.ToString("d")}\n" +
                        $"\tComment\n" +
                        $"{n.Comment}");
                }

            }
            catch (Exception)
            {

            }
            UpdateList();
        }

        private void priorityGrinBtm_Click(object sender, RoutedEventArgs e)
        {
            if (listViev.SelectedItem != null)
            {
                NotebookClass notebookClass = listViev.SelectedItem as NotebookClass;
                notebookClass.Priority = Сategories.Green;
                DbServiseClass.UpdateNotebook(notebookClass);
            }
            UpdateList();
        }

        private void priorityBlueBtm_Click(object sender, RoutedEventArgs e)
        {
            if (listViev.SelectedItem != null)
            {
                NotebookClass notebookClass = listViev.SelectedItem as NotebookClass;
                notebookClass.Priority = Сategories.Blue;
                DbServiseClass.UpdateNotebook(notebookClass);
            }
            UpdateList();
        }

        private void priorityRedBtm_Click(object sender, RoutedEventArgs e)
        {
            if (listViev.SelectedItem != null)
            {
                NotebookClass notebookClass = listViev.SelectedItem as NotebookClass;
                notebookClass.Priority = Сategories.Red;
                DbServiseClass.UpdateNotebook(notebookClass);
            }
            UpdateList();
        }

        private void exitBtm_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
