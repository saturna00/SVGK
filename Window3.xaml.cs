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

namespace WpfApp30
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        
        
        public Window3()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow r = new MainWindow();
            r.Show();
            this.Close();
        }

        private void lk_Click(object sender, RoutedEventArgs e)
        {
            Window4 sss = new Window4();
            sss.Show();
            this.Close();
        }
        private void blok_Click(object sender, RoutedEventArgs e)
        {
            if(card.Text.Length == 19 && fioo.Text.Length > 15)
            {
                MessageBox.Show($"Карта  клиента {fioo.Text} заблокирована", "СВГК", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Данные введены некорректно");
            }
        }
        
    }
}
