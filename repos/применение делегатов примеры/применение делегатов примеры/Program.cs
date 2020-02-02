using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace применение_делегатов_примеры
{
    class Account
    {
        // Объявляем делегат
        public delegate void AccountStateHandler(string message);
        // Создаем переменную делегата
        AccountStateHandler _del;

        // Регистрируем делегат
        public void RegisterHandler(AccountStateHandler del)
        {
            _del += del; // добавляем делегат
        }
        // Отмена регистрации делегата
        public void UnregisterHandler(AccountStateHandler del)
        {
            _del -= del; // удаляем делегат
        }

        // Далее остальные строки класса Account
        int _sum; // Переменная для хранения суммы

        public Account(int sum)
        {
            _sum = sum;
        }

        public int CurrentSum
        {
            get { return _sum; }
        }

        public void Put(int sum)
        {
            _sum += sum;
        }

        public void Withdraw(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;

                if (_del != null)
                    _del($"Сумма {sum} снята со счета");
            }
            else
            {
                if (_del != null)
                    _del("Недостаточно денег на счете");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(200);
            Account.AccountStateHandler colorDelegate = new Account.AccountStateHandler(Color_Message);

            // Добавляем в делегат ссылку на методы
            account.RegisterHandler(new Account.AccountStateHandler(Show_Message));
            account.RegisterHandler(colorDelegate);
            // Два раза подряд пытаемся снять деньги
            account.Withdraw(100);
            account.Withdraw(150);

            // Удаляем делегат
            account.UnregisterHandler(colorDelegate);
            account.Withdraw(50);

            Console.ReadLine();
        }
        private static void Show_Message(String message)
        {
            Console.WriteLine(message);
        }
        private static void Color_Message(string message)
        {
            // Устанавливаем красный цвет символов
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            // Сбрасываем настройки цвета
            Console.ResetColor();
        }
    }
}
