using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace Classes
{
    public  delegate void dlgtAddToLog(string text, Color color, bool isNewLine = true);
 


    public class ServerObject
    {
        #region поля и properties
        public string IP { get => "xxx"; }
        public string Port { get => "8888"; }

        static TcpListener tcpListener; // сервер для прослушивания
        List<ClientObject> clients = new List<ClientObject>(); // все подключения

        dlgtAddToLog AddToLog;
        Form FormLog;
        #endregion

        #region  Constructor
        public ServerObject(dlgtAddToLog addToLog, Form formLog)
        {
            AddToLog = addToLog;
            FormLog = formLog;
        }
        #endregion

        #region connection
        protected internal void AddConnection(ClientObject clientObject)
        {
            clients.Add(clientObject);
        }
        protected internal void RemoveConnection(string id)
        {
            // получаем по id закрытое подключение
            ClientObject client = clients.FirstOrDefault(c => c.Id == id);
            // и удаляем его из списка подключений
            if (client != null)
                clients.Remove(client);
        }
        
        // отключение всех клиентов
        protected internal void Disconnect()
        {
            tcpListener.Stop(); //остановка сервера

            for (int i = 0; i < clients.Count; i++)
            {
                clients[i].Close(); //отключение клиента
            }
            Environment.Exit(0); //завершение процесса
        }
        #endregion

        #region MessageProcessing
        // прослушивание входящих подключений
        protected internal void Listen()
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, 8888);
                tcpListener.Start();

                InvokeAddToLog("Сервер запущен. Ожидание подключений...", Color.Black);

                while (true)
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();

                    // каждого клиента обслуживаем в его отдельном потоке
                    ClientObject clientObject = new ClientObject(tcpClient, this, AddToLog, FormLog);
                    Thread clientThread = new Thread(clientObject.Process);
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Disconnect();
                InvokeAddToLog(ex.Message, Color.Red);
            }
        }

        // трансляция сообщения подключенным клиентам
        protected internal void BroadcastMessage(string message, string id)
        {
            byte[] data = Encoding.Unicode.GetBytes(message);
            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].Id != id) // если id клиента не равно id отправляющего
                {
                    clients[i].Stream.Write(data, 0, data.Length); //передача данных
                }
            }
        }
        #endregion

        private void InvokeAddToLog(string text, Color color, bool isNewLine = true)
        {
            FormLog.Invoke(AddToLog, new Object[] { text, color, isNewLine });
        }

    }
}
