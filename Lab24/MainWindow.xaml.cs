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

namespace Lab24
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mounth.IsEnabled = true;
        }

        private void Year_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 1990; i < DateTime.Now.Year; i++)
            {
                Year.Items.Add(i);
            }
        }

        private void Mounth_Loaded(object sender, RoutedEventArgs e)
        {
            Mounth.Items.Add("Январь");
            Mounth.Items.Add("Февраль");
            Mounth.Items.Add("Март");
            Mounth.Items.Add("Апрель");
            Mounth.Items.Add("Май");
            Mounth.Items.Add("Июнь");
            Mounth.Items.Add("Июль");
            Mounth.Items.Add("Август");
            Mounth.Items.Add("Сентябрь");
            Mounth.Items.Add("Октябрь");
            Mounth.Items.Add("Ноябрь");
            Mounth.Items.Add("Декабрь");
        }

        private void Mounth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Day.IsEnabled = true;
        }

        private void Day_Loaded(object sender, RoutedEventArgs e)
        {
            int days = DateTime.DaysInMonth(1990 + Year.SelectedIndex, Mounth.SelectedIndex + 1);
            for (int i = 1; i <= days; i++)
            {
                Day.Items.Add(i);
            }
        }
    }
}
