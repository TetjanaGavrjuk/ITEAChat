using Classes;
using Common;
using Common.AppSettings;
using Common.Types;
using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Common.UIUtls;

namespace Client.UI
{
    public partial class frmChatRoom : Form
    {
        string userName { get => Globals.CurrUser.Login;  }
        
        //private const string host = "127.0.0.1";
        //private const int port = 8888;
        private string host  { get => Globals.CurrConnection.ServerIP;  }
        private int port { get => Globals.CurrConnection.ServerPort; }

        static TcpClient tcpClient;
        static NetworkStream stream;

        #region Form
        public frmChatRoom()
        {
            InitializeComponent();

            // инициализируем сервер чата
             tcpClient = new TcpClient();
            ;

        }

        private void frmChatRoom_Load(object sender, EventArgs e)
        {
            FillScrFields();
            //---------------------------------------------

            try
            {
                tcpClient.Connect(host, port);  // подключение клиента
                stream = tcpClient.GetStream(); // получаем поток

                // первым этапом сообщим свое имя серверу чата
                SendMessage(userName);

                // Запускаем новый поток для получения данных. 
                // Он же и будет отбражать полученные сообщения в окне чата
                Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                receiveThread.Start(); //старт потока

                AddTextToChat("Добро пожаловать, " + userName, Color.Blue);
            }
            catch (Exception ex)
            {
                AddTextToChat(ex.Message, Color.Red);
            }
            finally
            {
 //               Disconnect();
            }
        }


        private void frmChatRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
                Disconnect();
        }

        private void FillScrFields()
        {
            txtUserName.Text = Globals.CurrUser.Login;
            txtServerIPAndPort.Text = Globals.CurrConnection.ServerIPWithPort;

            Text = Globals.CurrUser.Login;
        }
        #endregion

        #region Обработка сообщений
        // отправка сообщений
        void SendMessage(string message)
        {
            
            byte[] data = Encoding.Unicode.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }

        // получение сообщений
        void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    byte[] data = new byte[64]; // буфер для получаемых данных
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    string message = builder.ToString();
                    InvokeAddTextToChat(message, Color.Black);//вывод сообщения
                }
                catch
                {
                    InvokeAddTextToChat("Подключение прервано!", Color.Red); //соединение было прервано
                    Disconnect();
                    Environment.Exit(0); //завершение процесса
               }
            }
        }

        void Disconnect()
        {
            if (stream != null)
            {
                stream.Close();//отключение потока
                stream.Dispose();
            }
            if (tcpClient != null)
                tcpClient.Close();//отключение клиента
           Environment.Exit(0); //завершение процесса
     }
        #endregion


       // Отправить на чат-сервер сообщение, введенное пользователем
       private void cmdSendMessage_Click(object sender, EventArgs e)
        {
            // Формируем сообщение для отправки серверу
            string Msg = txtUserMessage.Text; // здесь может быть более сложный функционал!

            // Отправляем сообщение серверу
            SendMessage(Msg);

            //отобразим свое сообщение в окне чата
            AddTextToChat(Msg, Color.BlueViolet);

            //Очищаем окно для ввода сообщения
            txtUserMessage.Text="";
        }

        #region Вспомогательные методы

        private void InvokeAddTextToChat(string text, Color color)
        {
            this.Invoke( (dlgtAddToLog)AddTextToChat, new Object[] { text, color, true });
        }

        private void AddTextToChat(string text, Color color,bool isNewLine = true)
        {
            Font font = new Font("Cambria", 10, FontStyle.Regular);
            utls.AppendTextToRichTextBox(txtChat, text, color, font, true);
        }

        private void mnuSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.ShowDialog(this);
        }

        private void btnServerIP_Click(object sender, EventArgs e)
        {
            string userNameOld = userName;

            frmSettings frmSettings = new frmSettings();
            frmSettings.goToNet();
            frmSettings.ShowDialog(this);

            // При изменении настроек- пезаполнить поля формы, переконнектиться
            FillScrFields();

            //Reconnect();   //TODO
            if (userNameOld != userName)
            {
                SendMessage("#9" + userName);

                //отобразим свое сообщение в окне чата
                AddTextToChat("Сменился login  на " + userName, Color.BlueViolet);
            }
        }

        #endregion
    }
}
