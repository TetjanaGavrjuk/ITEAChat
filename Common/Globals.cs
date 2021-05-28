using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Common.SimpleTypes;
using Common.Types;
using Common.AppSettings;

namespace Common
{
    // Хдесь хранятся данные, глобальные для всего решения
    public static class Globals
    {
        // текущий пользователь
        public static User CurrUser;

        // Текущее соединение с сервером
        public static Connection CurrConnection;

        static Globals()
        {
            CurrUser = new User();
            CurrConnection = new Connection();
            FillFromSettings();
        }

        public static void FillFromSettings() 
        {
            CurrUser.FillFromSettings();
            CurrConnection.FillFromSettings();
        }

    }
}
