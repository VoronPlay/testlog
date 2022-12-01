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

namespace testlog
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void Log_in_Click(object sender, RoutedEventArgs e)
        {
            {
                if (Password.Text.ToString() == "User" && Username.Text.ToString() == "User")
                {
                    Manager.FrmMain.Navigate(new PageUser());
                }
                else if (Password.Text.ToString() == "Admin" && Username.Text.ToString() == "Admin")
                {
                    Manager.FrmMain.Navigate(new PageAdmin());
                }
                else if (Password.Text.ToString() != "User")
                {
                    MessageBox.Show("Пароль не верный",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (Username.Text.ToString() != "User")
                {
                    MessageBox.Show("Логин не верный",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (Password.Text.ToString() != "Admin")
                {
                    MessageBox.Show("Пароль не верный",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (Username.Text.ToString() != "Admin")
                {
                    MessageBox.Show("Логин не верный",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (Password.Text.ToString() != "Admin" && Username.Text.ToString() != "Admin")
                {
                    MessageBox.Show("Логин и пароль не верны",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (Password.Text.ToString() != "User" && Username.Text.ToString() != "User")
                {
                    MessageBox.Show("Логин и пароль не верны",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                Password.Text = "";
                Username.Text = "";

            }
        }

        private void Remember_Click(object sender, RoutedEventArgs e)
        {
            string username = this.Username.Text;
        }

        private void Remember_Checked(object sender, RoutedEventArgs e)
        {
            string username = this.Username.Text;
        }
    }
}
