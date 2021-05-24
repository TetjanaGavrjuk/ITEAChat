using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Types
    {
    public class Connection
    {
        string IPServer;
        string IPClient;

        //...

        public Connection()
        {
        }

        // Заполнить данные из последних сохраненных сведений
        public void FillByLastValue()
        {
            // получаем эти сведения из внешних источников, например из ini/xml/реестра
            // наверное это будет тесно связано с настройками AppSettings
            // ...
        }

        public void TryConnect()
        {
            if (IPServer.Length < 1) {
               // throw InvalidOperationException;
            };

        }
    }
}
