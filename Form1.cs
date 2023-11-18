using System;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientIP
{
    public partial class formClientIP : Form
    {
        public static TcpClient client;
        public static TimeSpan SendTimeout { get; set; }
        public static TimeSpan ReceiveTimeout { get; set; }

        public static byte[] buff = new byte[49152];
        public static string ipAddress = "127.0.0.3";
        public static int port = 8888;
        public bool workFlag = false;
        public static string logDir = string.Empty;
        public NetworkStream stream = null;
        TaskCompletionSource<bool> tcs = null;



        public formClientIP()
        {
            SendTimeout = TimeSpan.FromSeconds(50);
            ReceiveTimeout = TimeSpan.FromSeconds(50);
            InitializeComponent();
        }

        private void formClientIP_Load(object sender, EventArgs e)
        {
            LogLocal.logDir = LogLocal.GetLocalDirPath(); // получаю путь к каталогу с логами
            LogLocal.WriteLogLocal(LogLocal.logDir, "Start      PROG: " + Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location));
            tbIp.Text = ipAddress;
            tbPort.Text = port.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbReceive.Clear();
        }

        private void btnSetConn_Click(object sender, EventArgs e)
        {
            tbReceive.AppendText(LogLocal.logDir + "\n");
            tbReceive.ScrollToCaret();
            SetConnection();
        }

        public bool SetConnection() 
        {
            client = new TcpClient();
            client.NoDelay = true;
            client.SendTimeout = (int)SendTimeout.TotalMilliseconds;
            client.ReceiveTimeout = (int)ReceiveTimeout.TotalMilliseconds;
            client.ReceiveBufferSize = 1024; // ? 16.11.2023

            try
            {
                client.Connect(ipAddress, port);
            }
            catch (SocketException ex)
            {
                tbReceive.AppendText(ex.Message + "\n");
                tbReceive.ScrollToCaret();
                LogLocal.WriteLogLocal(LogLocal.logDir, ex.Message);
                return false;
            }

            if (client.Connected)
            { 
                tbReceive.AppendText("Client connected." + "\n");
                tbReceive.ScrollToCaret();
                LogLocal.WriteLogLocal(LogLocal.logDir, "Client connected.");
                return true;
            }
            else
            {
                tbReceive.AppendText("Connection failed." + "\n");
                tbReceive.ScrollToCaret();
                LogLocal.WriteLogLocal(LogLocal.logDir, "Connection failed.");
                return false;
            }
        }

        public async Task StartGettingData() 
        {
            #region Получение данных от сервера
            workFlag = true;
            //while (workFlag)
            //{
                if (client.Connected)
                {
                    await Task.Run(() =>
                    {
                        int numBytesRead = 0;
                        string str = string.Empty;

                        stream = client.GetStream();

                        // при обрыве связи - Unable to read data from the transport connection: A blocking operation was interrupted by a call to WSACancelBlockingCall.

                        numBytesRead = stream.Read(buff, 0, buff.Length); // прочитал сообщение из потока в буфер
                        
                        if (numBytesRead > 0)
                        {
                            str = Encoding.ASCII.GetString(buff, 0, numBytesRead); // перекодировал количество полученных байтов в строку
                            LogLocal.WriteLogLocal(logDir, str);

                            tbReceive.Invoke(new Action(() =>
                            {
                                tbReceive.AppendText(str + "\n");
                                tbReceive.ScrollToCaret();
                            }
                            ));

                        }
                    });
                }
            //}
            #endregion
        }

        #region Инициализирую процедуру получения данных от устройства
        private async void btnGetData_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                // Записать в поток управляющую команду.
                //tcs = new TaskCompletionSource<bool>();
                //tcs.Task.run
                //await tcs.Task;



                StartGettingData();
            }
            else
            {
                tbReceive.AppendText("Client disconnected." + "\n");
                tbReceive.ScrollToCaret();
            }
        }
        #endregion

        #region отправляю данные в порт
        private void btnSend_Click(object sender, EventArgs e)
        {
            // пишем серверу сообщение, если надо. Может использоваться для отправки управляющих команд. 
            SendComandGetWeight(stream, tbMessage.Text.Trim());
        }
        #endregion

        #region Запись в поток сообщения для устройства COM (исключением не оборачивал) 
        private void SendComandGetWeight(NetworkStream astream, string command) 
        {
            // try bloc must'll be here
            byte[] converted = System.Text.Encoding.ASCII.GetBytes(command);
            astream.Write(converted, 0, converted.Length);

        }
        #endregion

        #region btnCloseConn_Click
        private void btnCloseConn_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                try
                {
                    client.Close();
                    tbReceive.AppendText("Client disconnected." + "\n");
                    tbReceive.ScrollToCaret();  
                    LogLocal.WriteLogLocal(logDir, "Client disconnected.");
                }
                catch (Exception ex)
                {
                    LogLocal.WriteLogLocal(logDir, ex.Message);
                }
            }
        }
        #endregion

        #region FormClosed
        private void formClientIP_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client != null)
            {
                try 
                { 
                    client.Close(); 
                }
                catch (Exception ex) 
                {
                    LogLocal.WriteLogLocal(LogLocal.logDir, ex.Message);
                }
            }

            LogLocal.WriteLogLocal(LogLocal.logDir, "Stop     PROG: " + Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location));
        }
        #endregion
       
    }
}
