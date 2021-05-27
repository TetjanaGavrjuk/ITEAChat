using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Common.SimpleTypes;
using Common.Types;

namespace Common.Settings
{
    //Класс, определяющий какие настройки есть в программе
    public class AppSettingsFields
    {
        public string Login;
        public int UserID;
        
        public string ChatServerIP;
        
        public MsgSendKey MsgSendKey; // ???

        public String XMLFileName = Environment.CurrentDirectory + "\\ITEAChatSettings.xml";

        //Чтобы добавить настройку в программу просто добавьте туда строку вида -
        //public ТИП ИМЯ_ПЕРЕМЕННОЙ = значение_переменной_по_умолчанию;
        public String TextValue = @"File Settings";
        public DateTime DateValue = new DateTime(2011, 1, 1);
        public Decimal DecimalValue = 555;
        public Boolean BoolValue = true;
    }

    public static class Settings 
    {
        // комбинация клавиш для отправки сообщения (по-умолчанию  Ctrl+Enter)
        public static MsgSendKey MsgSendKey = MsgSendKey.CtrlEnter;

        // полное имя файла настроек
        public static string CnfgFullFileName = Environment.CurrentDirectory + "\\ITEAChatSettings.xml";

        // Объект, реализующий работу с ини-файлом...
        // ...  ??

        static void AppSettings()
        {
            // ПутьПриложения+ИмяПриложения+".ini"
            CnfgFullFileName = "";  //TODO
        }

        // Из конфигурационного файла загружаем ВСЕ настройки
        public static void Load()
        {
            //TODO
        }

        // Сохраняем ВСЕ настройки в конфигурационный файл
        public static void Save()
        {
            //TODO
        }

        // Сохраняем указанную настройку в конфигурационный файл
        public static void  Save(string settingName)
        {
            //TODO
        }

        //Сохранить  логин в конфигурационном файле
        public static void  Save(User user)
        {
            // TODO
        }

        public static void  Fill(User user) { }
        public static void  Fill(Connection connection) { }


    }


    public class AppSettings
    {
        // комбинация клавиш для отправки сообщения (по-умолчанию  Ctrl+Enter)
        public MsgSendKey MsgSendKey = MsgSendKey.CtrlEnter;
        
        // полное имя файла настроек
        public string CnfgFullFileName;

        // Объект, реализующий работу с ини-файлом...
        // ...  ??
       
        public AppSettings() 
        {
            // ПутьПриложения+ИмяПриложения+".ini"
            CnfgFullFileName = "";  //TODO
        }

        // Из конфигурационного файла загружаем ВСЕ настройки
        public void Load()
        {
            //TODO
        }

        // Сохраняем ВСЕ настройки в конфигурационный файл
        public void Save()
        {
            //TODO
        }

        // Сохраняем указанную настройку в конфигурационный файл
        public void Save(string settingName )
        {
            //TODO
        }

        //Сохранить  логин в конфигурационном файле
        public void SaveLogin(User user) 
        {
            // TODO
        }

        public void Fill(User user) { }
        public void Fill(Connection connection) { }


    }
}
