using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.AppSettings;

namespace Common.Types
{
    public class User
    {
        public long ID;
        public string Name;
        public string Login;
        public string IP; // ???? 

        public User() {
            ID = -1;
            Name = "Anonim U.S.";
            Login = "Anonim";
        }

        // Заполнить данные из последних сохраненных сведений
        public void FillFromSettings()
        {
            this.Login = Settings.Fields.Login;
        }

    }
}
