using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Common.SimpleTypes;
using Common.Types;

namespace Common.Settings
{
    public class AppSettings
    {
        // комбинация клавиш для отправки сообщения (по-умолчанию  Ctrl+Enter)
        public MsgSendKey MsgSendKey = MsgSendKey.CtrlEnter;
        
        // полное имя файла к файлу настроек
        public string CnfgFullFileName;

        // Объект, реализующий работу с ини-файлом...
        // ...  ??
       
        public AppSettings() 
        {
            // ПутьПриложения+ИмяПриложения+".ini"
            CnfgFullFileName = "";  //TODO
        }

        //Загрузить  значение последнего введенного логина из конфигурационного файла
        public void LoadLogin(User user)
        {
            // TODO
        }

        //Сохранить  логин в конфигурационном файле
        public void SaveLogin(User user) 
        {
            // TODO
        }

        //Загрузить  значение последнего коннекта из конфигурационного файла
        public void LoadConnection( Connection connection)
        {
            // TODO
        }


    }
}
