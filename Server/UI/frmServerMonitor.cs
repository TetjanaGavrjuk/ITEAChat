using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Common;
using Classes;

namespace UI
{
    public partial class frmServerMonitor : Form
    {
        ServerObject server; // сервер
        Thread listenThread; // потока для прослушивания

        public frmServerMonitor()
        {
            InitializeComponent();

            // инициализируем сервер чата
            server = new ServerObject(AppendTextToLog, this);
            AppendTextToLog("Сервер инициализирован!", Color.Blue, "1");
        }

        private void frmServerMonitor_Load(object sender, EventArgs e)
        {
            txtServerIPAndPort.Text = "123"; //server.IP;

            try
            {
                AppendTextToLog("Сервер запускается...", Color.Blue, "1");
                listenThread = new Thread(new ThreadStart(server.Listen));
                listenThread.Start(); //старт потока
            }
            catch (Exception ex)
            {
                server.Disconnect();
                AppendTextToLog(ex.Message, Color.Red, "1");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CloseServer();
            //Sleep(2000);
            this.Close();
        }

        private void CloseServer()
        {
            server.Disconnect();
            
            // еще нужно как то остановить треды
            // ...

            AppendTextToLog("Сервер остановлен!", Color.Red, "1");

        }

        #region Logging
        private void AppendTextToLog(string text, Color color, string isEmpty )
        {
            bool isNewLine = true;

            Font font = new Font("Cambria", 10, FontStyle.Regular);

            txtLog.SuspendLayout();
            txtLog.SelectionStart = txtLog.TextLength;
            txtLog.SelectionLength = 0;

            txtLog.SelectionColor = color;
            txtLog.SelectionFont = font;
            txtLog.AppendText(isNewLine ? $"{text}{ Environment.NewLine}" : text);

            txtLog.SelectionColor = txtLog.ForeColor;
            txtLog.ScrollToCaret();
            txtLog.ResumeLayout();
        }

        private void AppendTextToLog( string text, Color color , bool isNewLine = true)
        {
            //return;

            Font font = new Font("Cambria", 10, FontStyle.Regular);

            txtLog.SuspendLayout();
            txtLog.SelectionStart = txtLog.TextLength;
            txtLog.SelectionLength = 0;

            txtLog.SelectionColor = color;
            txtLog.SelectionFont = font;
            txtLog.AppendText(isNewLine ? $"{text}{ Environment.NewLine}" : text);

            txtLog.SelectionColor = txtLog.ForeColor;
            txtLog.ScrollToCaret();
            txtLog.ResumeLayout();
        }

        #endregion
    }
}
