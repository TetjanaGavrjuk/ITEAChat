using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Common;  // подключаем проект 'Common', который будет использоваться и для Клинта и для Сервера
using Client.UI;

namespace Client
{

    // Это пока что ЗАГОТОВКА будущего приложения:
    // Набросана архитекрута(структура) проекта.
    // Имплементации большинства объектов- еще нет!
    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Заполнить настройки
            //Globals.AppSettings.Fill();  ???

            // ЗАполнить значения глобальных данных последними введенными
            Globals.AppSettings.LoadLogin(Globals.CurrUser);
            Globals.AppSettings.LoadConnection(Globals.CurrConnection);

            // Пройти авторизацию
            if (  IsAutorised() ) 
            {
                //Сохранить введенный логин в конфигурационном файле
                Globals.AppSettings.SaveLogin(Globals.CurrUser);

                // Войти в чат-рум
                Application.Run(new frmChatRoom());
            }
        }

        //TODO
        private static bool IsAutorised() {
            // Вывод формы авторизации
            // Ввод пользователем пароля и логина
            // Проверка введенного пароля и логина
            return true;
        }

    }
}
