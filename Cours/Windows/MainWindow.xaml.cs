using Cours.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;
using static Cours.NotebookClass;

namespace Cours
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<NotebookClass> notebooks = new List<NotebookClass>();
        private DispatcherTimer timer = null;
        private User user = null;
        private int count = 0;
        public MainWindow(User user)
        {
            InitializeComponent();
            this.user = user;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            UpdateCountsPlan();
            notebooks = DbServiseClass.GetAllNotebooks();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Content = DateTime.Now.ToString("HH'-'MM'-'ss");
            dataLabel.Content = DateTime.Now.ToString("dd'-'MM'-'yyyy");
        }
        private void UpdateCountsPlan()
        {
            notebooks = DbServiseClass.GetAllNotebooks();
            int red = 0; int blue = 0; int gren = 0;
            count = 0;
            foreach (var item in notebooks)
            {
                if (item.Login == user.Login)
                {
                    count++;
                    if (item.Priority == Сategories.Red)
                        red++;
                    else if (item.Priority == Сategories.Green)
                        gren++;
                    else if (item.Priority == Сategories.Blue)
                        blue++;
                }
            }
            countLabel.Content = count.ToString();
            blueLabel.Content = blue.ToString();
            redPlanLabel.Content = red.ToString();
            greanLabel.Content = gren.ToString();
        }

        private void addBtm_Click(object sender, RoutedEventArgs e)
        {
            Windows.AddWindow window = new Windows.AddWindow(user);
            window.ShowDialog();
            UpdateCountsPlan();
        }

        private void showBtm_Click(object sender, RoutedEventArgs e)
        {
            UpdateCountsPlan();
            if (count == 0)
            {

            }
            else
            {
                Windows.ShowWindow window = new Windows.ShowWindow(user);
                window.ShowDialog();
            }
            UpdateCountsPlan();
        }
    }
}
