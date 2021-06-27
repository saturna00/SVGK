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

namespace WpfApp30
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
        int k = 0;
        private void proverk_Click(object sender, RoutedEventArgs e)
        {
            if (tb1.Text.Length == 6)
            {
                if (tb1.Text == capcha.Text)
                {
                    Button.IsEnabled = true;
                    MessageBox.Show("Капча введена верно!", "Мы убедились,что вы реальный человек!", MessageBoxButton.OK);
                }
            }
            else
                MessageBox.Show("Введите капчу","Ошибка", MessageBoxButton.OK);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = log.Text;
            string password = parol.Password;
            k++;
            if (log.Text.Length > 0)
            {
                if (parol.Password.Length > 0)
                {
                    User authUser = null;
                    using (ApplictionContext db = new ApplictionContext())
                    {

                        authUser = db.Users.Where(b => b.Login == login && b.Password == password).FirstOrDefault();
                    }

                    if (authUser != null)
                    {
                        MessageBox.Show("Успешно!");
                        Window4 eee = new Window4();
                        eee.name.Text = login;
                        eee.Show();
                        Hide();
                    }
                    else
                        MessageBox.Show("Неверные данные!");
                }
                else
                {
                    MessageBox.Show("Введите LOGIN", "ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (k > 5)
                {
                    MessageBox.Show("Введите капчу", "Проверка", MessageBoxButton.OK);
                    Button.IsEnabled = false;
                    k = 0;
                }
            }
        }
        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2();
            win2.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window3 win3 = new Window3();
            win3.Show();
            this.Close();
        }

        private void resett_Click(object sender, RoutedEventArgs e)
        {
            String allowchar;
            allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
            allowchar += "1,2,3,4,5,6,7,8,9,0";
            char[] a = {','};
            String[] ar = allowchar.Split(a);
            String pwd = "";
            string temp;
           Random r = new Random();
            for (int i = 0; i < 6; i++)
            {
                temp = ar[(r.Next(0, ar.Length))];
                pwd += temp;
            }
            capcha.Text = pwd;
        }
    }

}
