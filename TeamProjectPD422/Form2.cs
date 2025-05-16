using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TeamProjectPD422
{
    public partial class Form2 : Form
    {
        TcpClient client;
        NetworkStream stream;
        Thread receiveThread;
        string userName = "User_Name" + new Random().Next(1000, 9999); // Можна зробити поле для вводу імені

        public Form2()
        {
            InitializeComponent();
            this.FormClosing += Form2_FormClosing;
            Send.Click += Send_Click;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ConnectToServer();
        }

        private void ConnectToServer()
        {
            try
            {
                client = new TcpClient("127.0.0.1", 5000);
                stream = client.GetStream();

                byte[] nameData = Encoding.UTF8.GetBytes(userName);
                stream.Write(nameData, 0, nameData.Length);

                receiveThread = new Thread(ReceiveMessages);
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося підключитися до сервера: " + ex.Message);
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (stream == null || !stream.CanWrite) return;

            string message = EnterChat.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
                ChatBox.AppendText($"[You] {message}\r\n");
                EnterChat.Clear();
            }
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            try
            {
                while (client.Connected)
                {
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    if (bytes == 0) break;
                    string msg = Encoding.UTF8.GetString(buffer, 0, bytes);

                    Invoke((MethodInvoker)(() =>
                    {
                        ChatBox.AppendText(msg + "\r\n");
                    }));
                }
            }
            catch
            {
                Invoke((MethodInvoker)(() =>
                {
                    ChatBox.AppendText("[Server] З'єднання втрачено.\r\n");
                }));
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                stream?.Close();
                client?.Close();
                receiveThread?.Abort();
            }
            catch { }
        }

        private void NewClient_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

    }
}
