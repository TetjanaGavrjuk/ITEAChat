using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace Common.AppSettings
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            txtLogin.Text = Globals.CurrUser.Login;
            txtServerPort.Text = Settings.Fields.ServerPort.ToString();
            txtServerIP.Text = Settings.Fields.ServerIP;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Settings.Fields.Login = txtLogin.Text;
            Settings.Fields.ServerIP = txtServerIP.Text;
            Settings.Fields.ServerPort = int.Parse(txtServerPort.Text);

            //Значения настроек сохраняем в файл
            Settings.Save();

            // Настройки - раскидываем по объектам
            Globals.FillFromSettings();
        }
    }
}
