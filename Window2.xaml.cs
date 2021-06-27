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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        ApplictionContext db;
        public Window2()
        {
            InitializeComponent();
            db = new ApplictionContext();
        }
        private void REG_Click(object sender, RoutedEventArgs e)
        {
            string login = log.Text.Trim();
            string password = par.Text.Trim();
            if (log.Text.Length > 0)
            {
                if (par.Text.Length > 0)
                {
                    if (par2.Text.Length > 0)
                    {
                        if (par2.Text == par.Text)
                        {
                            User user = new User(login, password);

                            db.Users.Add(user);
                            db.SaveChanges();

                            MainWindow qqq = new MainWindow();
                            qqq.Show();
                            this.Close();
                            MessageBox.Show("НЕТ ПРОБЛЕМ И ЕСТЬ ДВА ЛЯМА В БАНКЕ");
                        }
                        else
                        {
                            MessageBox.Show("Неверный повтор пароля", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Повторите пароль", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Stop);
                    }
                }
                else
                {

                    MessageBox.Show("Введите пароль", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Stop);
                }
            }
            else
            {
                MessageBox.Show("введите логин", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow qqq = new MainWindow();
            qqq.Show();
            this.Close();
        }
    }
}
    

