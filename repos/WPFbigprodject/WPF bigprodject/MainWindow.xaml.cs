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
//<TextBox x:Name="RoleWord" BorderBrush="{x:Null}"  Background="LightBlue" Width="180" Height="40" Text="Введите роль: " VerticalAlignment="Top" Margin="105,291,507,0" TextChanged="TextBox4_TextChanged" FontSize="18" TextAlignment="Right"/>
//<TextBox x:Name="BoxToRole" Width="180" Height="40" VerticalAlignment="Top" Margin="285,291,327,0" TextChanged="TextBox3_TextChanged" HorizontalAlignment="Center"/>

namespace WPF_bigprodject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string role = "";
        SecondWindow win2;

        public MainWindow()
        {
            InitializeComponent();
            BigDataBase.CreateDataBase();
        }

        private void BoxToWriteLogin(object sender, TextChangedEventArgs e)
        {
            
        }

        private void BoxToWritePassword(object sender, TextChangedEventArgs e)
        {
            
        }
        private void AuthorizationClick(object sender, RoutedEventArgs e)
        {
            bool isUser = false;
            string text = "Wrong login or password or role";
            List<DataBase> o = BigDataBase.ReaderAllDataBase();
            for (int i = 0; i < o.Count; i++)
            {
                if (o[i].Login == BoxToLogin.Text && o[i].Password == BoxToPassword.Text && o[i].Role == role)
                {
                    isUser = true;
                }
            }
            if (isUser == true)
            {
                win2 = new SecondWindow(role);
                win2.Show();
                this.Close();
            }
            else MessageBox.Show(text);
        }

        private void ExitToFirstWindow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonExit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RadioButtonToAdmin(object sender, RoutedEventArgs e) //Admin
        {
            role = "admin";
        }

        private void RadioButtonToStaff(object sender, RoutedEventArgs e) //Staff
        {
            role = "staff";
        }

        private void RadioButtonToUser(object sender, RoutedEventArgs e) //User
        {
            role = "user";
        }

        private void JustTextAboutPassword(object sender, TextChangedEventArgs e)
        {
            
        }

        private void JustTextAboutRole(object sender, TextChangedEventArgs e)
        {
            
        }

        private void JustTextAboutLogin(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
