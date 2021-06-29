using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Classes
{
    public class ClientObject
    {
        string userName;
        protected internal string Id { get; private set; }

        protected internal NetworkStream Stream { get; private set; }
        TcpClient client;
        ServerObject server; // объект сервера

        dlgtAddToLog AddToLog;
        Form FormLog;

        public ClientObject(TcpClient tcpClient, ServerObject serverObject, dlgtAddToLog addToLog, Form formLog)
        {
            Id = Guid.NewGuid().ToString();
            client = tcpClient;

            server = serverObject;
            serverObject.AddConnection(this);

            AddToLog = addToLog;
            FormLog = formLog;
        }

        public void Process()
        {
            try
            {
                Stream = client.GetStream();
                
                // получаем имя пользователя. 
                //Первое сообщение от Clienta- это его имм
                string message = GetMessage();
                userName = message;

                // посылаем сообщение о входе в чат всем подключенным пользователям
                message = userName + " вошел в чат";
                InvokeAddToLog(message, Color.Blue);
                server.BroadcastMessage(message, this.Id);

                // в бесконечном цикле получаем сообщения от клиента
                while (true)
                {
                    try
                    {
                        message = GetMessage();

                        string cmdCode=null;
                        ParseMessage(message, ref cmdCode, ref message);

                        if (cmdCode == "9") //смена имени пользователя
                        {
                            string userNameOld = userName;
                            userName = message;
                            message = String.Format("Пользователь сменил имя: {0} на {1}", userNameOld, message);
                            InvokeAddToLog(message, Color.Blue);
                        }
                        else 
                        { 
                            message = String.Format("{0}: {1}", userName, message);
                            InvokeAddToLog(message, Color.Black);
                        }

                        server.BroadcastMessage(message, this.Id);
                    }
                    catch
                    {
                        message = String.Format("{0}: покинул чат", userName);
                        InvokeAddToLog(message, Color.Brown);
                        server.BroadcastMessage(message, this.Id);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                InvokeAddToLog(e.Message, Color.Red);
            }
            finally
            {
                // в случае выхода из цикла закрываем ресурсы
                server.RemoveConnection(this.Id);
                Close();
            }
        }
        private void ParseMessage(string inMessage, ref string outCmdCode,  ref string outMsgText) 
        {
            outMsgText = inMessage;

            if (inMessage.Substring(0,1) == "#")
            {
                outCmdCode = inMessage.Substring(1, 1);
                outMsgText = inMessage.Substring(2);
            }
        }

        // чтение входящего сообщения и преобразование в строку
        private string GetMessage()
        {
            byte[] data = new byte[64]; // буфер для получаемых данных
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = Stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (Stream.DataAvailable);

            return builder.ToString();
        }

        // закрытие подключения
        protected internal void Close()
        {
            if (Stream != null)
                Stream.Close();
            if (client != null)
                client.Close();
        }

        private void InvokeAddToLog(string text, Color color, bool isNewLine = true)
        {
            FormLog?.Invoke(AddToLog, new Object[] { text, color, isNewLine });
        }

    }
}
