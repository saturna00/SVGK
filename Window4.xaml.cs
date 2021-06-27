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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        ApplictionContext db;
        public Window4()
        {
            InitializeComponent();
            db = new ApplictionContext();
        }

        private void bd_Click(object sender, RoutedEventArgs e)
        {
            Window1 rrr = new Window1();
            rrr.Show();
            this.Close();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow rr = new MainWindow();
            rr.Show();
            this.Close();
        }

        private void vnos_Click(object sender, RoutedEventArgs e)
        {
            string Фио = _1.Text.Trim();
            string Номер_телефона = _2.Text.Trim();
            string Номер_карты = _3.Text.Trim();
            string Серия_Номер_паспорта = _4.Text.Trim();
            string Трудоустройство = _5.Text.Trim();
            string Задолженности_по_кредитам = _6.Text.Trim();
            if(_1.Text.Length > 15 && _2.Text.Length == 11 && _3.Text.Length == 19 && _4.Text.Length == 12 && _5.Text.Length > 0)
            {

                Lud dnnie = new Lud(Фио, Номер_телефона, Номер_карты, Серия_Номер_паспорта, Трудоустройство, Задолженности_по_кредитам);
                db.Luds.Add(dnnie);
                db.SaveChanges();
                MessageBox.Show("Данные добавлены в базу");
            }
            else
            {
                MessageBox.Show("Данные введены некорректно");
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
        }

        private void blok_Click(object sender, RoutedEventArgs e)
        {
            Window3 r = new Window3();
            r.Show();
            this.Close();
        }
    }
}
