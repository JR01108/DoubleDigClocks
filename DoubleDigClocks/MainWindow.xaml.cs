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

namespace DoubleDigClocks
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        Time time;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            time = new Time();
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ShowTime();
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowTime();
        }
        private void ShowTime()
        {
            TimeText.Text = time.getBinTime();            
            DecimalTime.Text = time.getDecTime();
        }

        private void DecimalTime_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ChangeFormatButton_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeFormatButton.Content as string == "AM/PM")
            {
                ChangeFormatButton.Content = "24H";
            }
            else
            {
                ChangeFormatButton.Content = "AM/PM";
            }
            time.ChangeFormat();
        }
    }
}
