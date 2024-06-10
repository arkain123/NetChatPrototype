using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChatTest
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
        string IP = "127.0.0.1";
        int PORT = 11200;
        string username = null;
        TcpClient client = null;
        StreamReader Reader = null;
        StreamWriter Writer = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            send(Writer, userTextBox.Text);
            userTextBox.Clear();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            chatTextBox.Clear();
        }

        private void hostBox_CheckedChanged(object sender, EventArgs e)
        {
            selfHost();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            string IP = ipBox.Text;
            int PORT = int.Parse(portBox.Text);
            //проверка на коннект или дисконект
            if (!isConnected)
            {
                //конект
                connect(IP, PORT);
                succesfullConnect();
            }
            else
            {
                //дисконект
                disconnect();
                succesfullDisconnect();
            }
        }

        private void succesfullConnect()
        {
            ipBox.Enabled = false;
            portBox.Enabled = false;
            userTextBox.Enabled = true;
            usernameBox.Enabled = false;
            sendButton.Enabled = true;
            onlineLight.Value = 1;
            connectButton.Text = "Отключиться";
            chatTextBox.Clear();

            chatTextBox.Text += Environment.NewLine + "---------------Подключено-к-" + IP + ":" + PORT.ToString() + "---------------";

        }

        private void succesfullDisconnect()
        {
            ipBox.Enabled = true;
            portBox.Enabled = true;
            userTextBox.Enabled = false;
            usernameBox.Enabled = true;
            sendButton.Enabled = false;
            onlineLight.Value = 0;
            connectButton.Text = "Подключиться";

            chatTextBox.Text += Environment.NewLine + "---------------Отключено-от-" + IP + ":" + PORT.ToString() + "---------------";
        }

        private void connect(string ip, int port)
        {
            username = usernameBox.Text;
            IP = ip;
            PORT = port;

            try
            {
                TcpClient client = new TcpClient();
                client.Connect(IP, PORT); //подключение клиента
                isConnected = true;
                Reader = new StreamReader(client.GetStream());
                Writer = new StreamWriter(client.GetStream());
                if (Writer is null || Reader is null) return;
                // запускаем новый поток для получения данных
                Task.Run(() => ReceiveMessageAsync(Reader));
                Writer.WriteLineAsync(username);
                Writer.FlushAsync();
                ReceiveMessageAsync(Reader);
            }
            catch (Exception ex)
            {} 
        }

        private void disconnect()
        {
            Writer.Close();
            Reader.Close();
            Writer = null;
            Reader = null;
            client = null;
            isConnected = false;
        }

        private void selfHost()
        {
            string IP = "127.0.0.1";
            int PORT = 11200;

            // тут создать свой сервер типо

            succesfullConnect();
        }

        private void send(StreamWriter writer, string message)
        {
            if (message == "") return;
            writer.WriteLineAsync(message);
            writer.FlushAsync();
        }
        // получение сообщений
        async Task ReceiveMessageAsync(StreamReader reader)
        {
            while (true)
            {
                try
                {
                    // считываем ответ в виде строки
                    string message = await reader.ReadLineAsync();
                    // если пустой ответ, ничего не выводим на консоль
                    if (string.IsNullOrEmpty(message)) continue;
                    chatTextBox.Text += Environment.NewLine + message;
                }
                catch
                {
                    break;
                }
            }
        }
    }
}
