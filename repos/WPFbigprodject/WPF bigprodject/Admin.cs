using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WPF_bigprodject
{
    class Admin : Staff //Админы могут создавать логины для стафа и пользвателей, но нет доступа к изменению данных системы!
    {
        static public int AddToDataBase(string login, string password, string role) //поидее здесь созадется админом профиль и роль кого-то
        {
            return BigDataBase.AddToDataBase(login, password, role);
        }
    }
}
