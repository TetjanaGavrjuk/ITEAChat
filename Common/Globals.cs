using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Common.SimpleTypes;
using Common.Types;
using Common.Settings;

namespace Common
{
    // Хдесь хранятся данные, глобальные для всего решения
    public static class Globals
    {
        // текущий пользователь
        public static User CurrUser;

        // Текущее соединение с сервером
        public static Connection CurrConnection;

        // Настройки для приложения
        public static AppSettings AppSettings;

        static Globals()
        {
            CurrUser = new User();
            CurrConnection = new Connection();
            AppSettings = new AppSettings();
        }

        public static void Load() 
        {
            AppSettings.Load();
            AppSettings.Fill(CurrUser);
            AppSettings.Fill(CurrConnection);
        }

        public static void SaveLogin()
        {
            AppSettings.SaveLogin(CurrUser);
        }

    }
}
