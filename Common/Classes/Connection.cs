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
        public int ServerPort;

        public string ClientIP;

        public string ServerIPWithPort {
            get { return (ServerIP + ':' + ServerPort.ToString()); }
}

        //...

        public Connection()
        {
        }

        // Заполнить данные из последних сохраненных сведений
        public void FillFromSettings()
        {
            ServerIP = Settings.Fields.ServerIP;
            ServerPort = Settings.Fields.ServerPort;
        }

        public void TryConnect()
        {
            if (ServerIP.Length < 1) {
                throw new Exception("Невозможно установить соединение с Сервером!");
            };

        }

    }
}
