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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            ApplictionContext db = new ApplictionContext();
            List<Lud> users = db.Luds.ToList();
            dbplz.ItemsSource = users;
        }

        private void grid22_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void lk_Click(object sender, RoutedEventArgs e)
        {
            Window4 sss = new Window4();
            sss.Show();
            this.Close();
        }

        private void exit1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow r = new MainWindow();
            r.Show();
            this.Close();
        }

        private void grid22_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            Window3 re = new Window3();
            re.Show();
            this.Close();

        }
    }
}