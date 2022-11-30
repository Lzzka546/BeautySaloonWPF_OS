using BeautySaloonWPF.Controllers;
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

namespace BeautySaloonWPF.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Autoriz.xaml
    /// </summary>
    public partial class AutorizPage : Page
    {

        public AutorizPage()
        {
            InitializeComponent();
        }

       private void SignInbuttonClick(object sender, RoutedEventArgs e)
        {
            {
                if (UsersController.Auth(LoginTextBox.Text, PasswordPasswordBox.Password))
                {
                    this.NavigationService.Navigate(new PersonalPage());
                }
                else
                {
                    MessageBox.Show("Вход не выполнен");
                }
            }

        }

        private void RegButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegPage());
        }

       
    }
        
}
