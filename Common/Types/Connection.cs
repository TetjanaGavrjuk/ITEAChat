using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.AppSettings;

namespace Common.Types
    {
    public class Connection
    {
        public string ServerIP;
        public string ClientIP;
        public int ServerPort;

        //...

        public Connection()
        {
        }

        // Заполнить данные из последних сохраненных сведений
        public void FillFromSettings()
        {
            // получаем эти сведения из внешних источников, например из ini/xml/реестра
            // наверное это будет тесно связано с настройками AppSettings
            // ...
            ServerIP = Settings.Fields.ServerIP;
            ServerPort = Settings.Fields.ServerPort;
        }

        public void TryConnect()
        {
            if (ServerIP.Length < 1) {
               // throw InvalidOperationException;
            };

        }
    }
}
