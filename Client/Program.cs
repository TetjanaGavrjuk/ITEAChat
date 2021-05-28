using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// подключаем проект 'Common', который будет использоваться и для Клиeнта и для Сервера
using Common;  
using Common.AppSettings;

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

            // Подгрузить настройки из файла конфигурации
            Settings.Load();

            // Пройти авторизацию
            if (  IsAutorised() ) 
            {
                // Войти в чат-рум
                Application.Run(new frmChatRoom());

                //сохраняем настройки
                Settings.Save();
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
