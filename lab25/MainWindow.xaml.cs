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

namespace lab25
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int time = 0;
        string st = "";

        System.Windows.Threading.DispatcherTimer Timer;
        public MainWindow()
        {
            InitializeComponent();
            Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.Tick += new EventHandler(dispatcherTimer_Tick);
            Timer.Interval = new TimeSpan(0, 0, 0, 1, 0);

            //установка интервала между тиками
            //TimeSpan – переменная для хранения времени в формате часы/минуты/секунды
            //запуск таймера

        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            time += 1;

            lb.Content = st;

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Timer.Stop();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Timer.Start();
        }

        


        private void bdel_Click(object sender, RoutedEventArgs e)
        {
         lb.Content = "";
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (Minute.IsChecked == true)
            {
                st += ((time / 60) / 60).ToString() + ":";
                st += ((time / 60) % 60).ToString() + ":";
            }
            else if (Second.IsChecked == true)
            {
                st += ((time / 60) / 60).ToString() + ":";
                st += (time % 60).ToString();
            }
            else if (Minute.IsChecked == true && Second.IsChecked == true)
            {
                st += ((time / 60) / 60).ToString() + ":";
                st += ((time / 60) % 60).ToString() + ":";
                st += (time % 60).ToString();
            }
            else
            {
                st += ((time / 60) / 60).ToString();
            }
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            if (Hour.IsChecked == true)
            {
                st += ((time / 60) / 60).ToString() + ":";
                st += ((time / 60) % 60).ToString() + ":";
            }
            else if (Hour.IsChecked == true)
            {
                st += ((time / 60) / 60).ToString() + ":";
                st += (time % 60).ToString();
            }
            else if (Minute.IsChecked == true && Second.IsChecked == true)
            {
                st += ((time / 60) / 60).ToString() + ":";
                st += ((time / 60) % 60).ToString() + ":";
                st += (time % 60).ToString();
            }
            else
            {
                st += (time % 60).ToString();
            }
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            if (Minute.IsChecked == true)
            {
                st += ((time / 60) % 60).ToString() + ":";
                st += (time % 60).ToString();

            }
            else if (Second.IsChecked == true)
            {
                st += ((time / 60) / 60).ToString() + ":";
                st += (time % 60).ToString();
            }
            else if (Minute.IsChecked == true && Second.IsChecked == true)
            {
                st += ((time / 60) / 60).ToString() + ":";
                st += ((time / 60) % 60).ToString() + ":";
                st += (time % 60).ToString();
            }
            else
            {
                st += ((time / 60) / 60).ToString();
            }
        }
    }
}
