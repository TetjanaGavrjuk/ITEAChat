using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;
using System.IO;

using Common.SimpleTypes;
using Common.Types;

namespace Common.AppSettings
{
    //Класс, определяющий какие настройки есть в программе
    public class PropsFields
    {
        public string Login;
        public int UserID;

        public string ServerIP;
        public int ServerPort;
        public MsgSendKey MsgSendKey= MsgSendKey.CtrlEnter; 

        public String XMLFileName;
    }

    public static class Settings 
    {
        public static PropsFields Fields;

        // полное имя файла настроек
        public static string CnfgFullFileName;

        static  Settings()
        {
            CnfgFullFileName = Environment.CurrentDirectory + "\\ITEAChatSettings.xml";  
            Fields = new PropsFields();
        }

        // Сохраняем ВСЕ настройки в конфигурационный файл
        public static void Load()
        {
            ReadXml();
        }

        // Сохраняем ВСЕ настройки в конфигурационный файл
        public static void Save()
        {
            WriteXml();
        }

        //Запись настроек в файл
        private static void WriteXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(PropsFields));
            TextWriter writer = new StreamWriter(CnfgFullFileName);
            ser.Serialize(writer, Fields);
            writer.Close();
        }

        //Чтение настроек из файла
        private static void ReadXml()
        {
            if (File.Exists(CnfgFullFileName))
            {
                XmlSerializer ser = new XmlSerializer(typeof(PropsFields));
                TextReader reader = new StreamReader(CnfgFullFileName);
                Fields = ser.Deserialize(reader) as PropsFields;
                reader.Close();
            }
            else 
            {
                //throw "Не найден файл конфигурации!";
            }
        }

    }
}
