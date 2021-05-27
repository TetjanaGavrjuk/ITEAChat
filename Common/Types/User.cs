using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Types
{
    public class User
    {
        public long ID;
        public string Name;
        public string IP; // ???? 

        public User() {
            ID = -1;
            Name = "Anonim";
        }

        // Заполнить данные из последних сохраненных сведений
        public void FillByLastValue()
        {
          // получаем эти сведения из внешних источников, например из ini/xml/реестра
          // наверное это будет тесно связано с настройками AppSettings
          // ...
        }

    }
}
