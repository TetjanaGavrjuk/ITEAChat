using System;
using System.Windows.Forms;
using System.Net;



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
        }

        private void frmSettings_Shown(object sender, EventArgs e)
        {
            txtLogin.Text = Globals.CurrUser.Login;
            txtServerPort.Text = Settings.Fields.ServerPort.ToString();
            txtServerIP.Text = Settings.Fields.ServerIP;
        }
        
        public void goToNet() { tabs.SelectTab( 1); }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Settings.Fields.Login = txtLogin.Text;
            Settings.Fields.ServerIP = txtServerIP.Text;
            Settings.Fields.ServerPort = int.Parse(txtServerPort.Text);

            //Значения настроек сохраняем в файл
            //При этом будет сгенерировано событие Changed,
            // которое потом перехватят глобальные объекты User и connection и обновят свои значения
            Settings.Save();

            Close();
        }

        private void OnChanged()
        {
            throw new NotImplementedException();
        }

        private void btnFillByLocalIP_Click(object sender, EventArgs e)
        {
            string Host = System.Net.Dns.GetHostName();
            string IP = System.Net.Dns.GetHostByName(Host).AddressList[0].ToString();
            txtServerIP.Text = IP;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }


    }
}
