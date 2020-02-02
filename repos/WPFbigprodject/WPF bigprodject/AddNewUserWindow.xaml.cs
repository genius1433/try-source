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

namespace WPF_bigprodject
{
    /// <summary>
    /// Логика взаимодействия для AddNewUserWindow.xaml
    /// </summary>
    public partial class AddNewUserWindow : Window
    {
        static string role = "";
        public AddNewUserWindow()
        {
            InitializeComponent();
        }

        private void JustTextAboutNameOfNewUser(object sender, TextChangedEventArgs e)
        {

        }

        private void JustTextAboutCreatingAccount(object sender, TextChangedEventArgs e)
        {

        }

        private void NameOfNewUser(object sender, TextChangedEventArgs e)
        {

        }

        private void JustTextAboutPasswordOfNewUser(object sender, TextChangedEventArgs e)
        {

        }

        private void PasswordOfNewUser(object sender, TextChangedEventArgs e)
        {

        }

        private void JustTextAboutRoleChooser(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButtonToAdmin(object sender, RoutedEventArgs e)
        {
            role = "Admin";
        }

        private void RadioButtonToStaff(object sender, RoutedEventArgs e)
        {
            role = "Staff";
        }

        private void RadioButtonToUser(object sender, RoutedEventArgs e)
        {
            role = "User";
        }

        private void ButtonToCreatePerson(object sender, RoutedEventArgs e)
        {
            int tr = 0;           
            List<DataBase> o = BigDataBase.ReaderAllDataBase();
            for (int i = 0; i < o.Count; i++)
            {
                if (o[i].Login == UserName.Text)
                {
                    tr = 1;
                    MessageBox.Show("Имя должно быть уникально");
                    break;
                }
            }
            if (tr == 0 && UserName.Text != null && UserPassword.Text != null && role != null)
            {
                Admin.AddToDataBase(UserName.Text, UserPassword.Text, role);
                MessageBox.Show("Повезло, ничего не сломалось");
                this.Close();
            }
            else MessageBox.Show("Обнаружено пустое поле");
        }

        private void ButtonToClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
