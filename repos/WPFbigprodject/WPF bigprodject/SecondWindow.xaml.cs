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
using System.IO;

namespace WPF_bigprodject
{
    /// <summary>
    /// Логика взаимодействия для SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        MainWindow win1;
        static string role;
        List<Car> cars = new List<Car>();      
        public SecondWindow()
        {
            InitializeComponent();
        }
        public SecondWindow(string role)
        {
            SecondWindow.role = role;
            cars = DBCars.ReadCatalog(role);
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void BoxToRead_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonReturnToLogin(object sender, RoutedEventArgs e)
        {
            win1 = new MainWindow();
            win1.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EnterInPrintCars(object sender, RoutedEventArgs e)
        {
            cars = DBCars.ReadCatalog(role);
            Staff.PrintCars(cars);
            //string[] str = new string[cars.Count];
            //for (int i = 0; i < cars.Count; i++)
            //{
            //    BoxToRead.Text = User.ListToStr(cars[i], role);
            //}
            BoxToRead.Text = User.ListToStr(cars, role);
        }

       

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void GettingInformationFromAddingCarOrCars(object sender, TextChangedEventArgs e)
        {

        }

        private void EnterInAdding(object sender, RoutedEventArgs e)
        {

        }

        private void GettingInformationFromSellingCar(object sender, TextChangedEventArgs e)
        {

        }

        private void EnterInSelling(object sender, RoutedEventArgs e)
        {
            cars = DBCars.ReadCatalog(role);
            string Number = SellingBox.Text;
            Staff.SellCar(Number, cars); //может быть ref
            DBCars.WriteCatalog(cars);
        }

        private void PrintListOfCars(object sender, RoutedEventArgs e)
        {

        }

        private void GettingInformationFromCalculateRevenue(object sender, TextChangedEventArgs e)
        {

        }

        private void EnterInCalculateRevenue(object sender, RoutedEventArgs e)
        {

        }

        private void EnterNewUser(object sender, RoutedEventArgs e)
        {
            if (role == "admin")
            {
                AddNewUserWindow AddUserWindow = new AddNewUserWindow();
                AddUserWindow.Show();
            }

        }

        //private void GettingInformationFromAddNewUserLPR(object sender, TextChangedEventArgs e)
        //{

        //}

        private void ClearButton(object sender, RoutedEventArgs e)
        {
            BoxToRead.Clear();
        }

        private void GettingInformationFromSearcher(object sender, TextChangedEventArgs e)
        {

        }

        private void EnterInSearch(object sender, RoutedEventArgs e)
        {

        }

        private void ColourSearchButton(object sender, RoutedEventArgs e)
        {

        }

        private void SeatsMunMaxSearchButton(object sender, RoutedEventArgs e)
        {

        }

        private void VansSizeSearchButton(object sender, RoutedEventArgs e)
        {

        }

        private void ModelAndTransmissionTypeSearchButton(object sender, RoutedEventArgs e)
        {

        }
    }
}
