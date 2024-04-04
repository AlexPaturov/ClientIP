using System;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
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
        public static string ipAddress = "127.0.0.1";
        public static int port = 8888;
        public volatile bool _workFlag = false;
        public static string logDir = string.Empty;
        public NetworkStream stream = null;
        TaskCompletionSource<bool> tcs = null;



        public formClientIP()
        {
            SendTimeout = TimeSpan.FromSeconds(200);
            ReceiveTimeout = TimeSpan.FromSeconds(200);
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
                client.Connect(tbIp.Text, Int32.Parse(tbPort.Text));
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
            _workFlag = true;
            while (_workFlag)
            {
                if (client.Connected)
                {
                    await Task.Run(() =>
                    {
                        int numBytesRead = 0;
                        stream = client.GetStream();

                        // при обрыве связи - Unable to read data from the transport connection: A blocking operation was interrupted by a call to WSACancelBlockingCall.
                        try 
                        { 
                            numBytesRead = stream.Read(buff, 0, buff.Length); // прочитал сообщение из потока в буфер
                        }catch (IOException ex) 
                        {
                            #region Show exception message
                            tbReceive.Invoke(new Action(() =>
                            {
                                tbReceive.AppendText(ex.StackTrace + "\n");
                                tbReceive.ScrollToCaret();
                                LogLocal.WriteLogLocal(LogLocal.logDir, ex.StackTrace);
                            }
                            ));
                            stream.Dispose();
                            #endregion
                        }

                        if (numBytesRead > 0)
                        {

                            tbReceive.Invoke(new Action(() =>
                            {
                                tbReceive.AppendText("get bytes: " + numBytesRead.ToString() + "\n");
                                tbReceive.ScrollToCaret();
                            }
                            ));

                            tbReceive.Invoke(new Action(() =>
                            {
                                tbReceive.AppendText(Encoding.GetEncoding(1251).GetString(buff, 0, numBytesRead) + "\n");
                                tbReceive.ScrollToCaret();
                                LogLocal.WriteLogLocal(LogLocal.logDir, Encoding.GetEncoding(1251).GetString(buff, 0, numBytesRead));
                            }
                            ));
                        }
                        else 
                        { 
                            Thread.Sleep(10);
                        }
                    });
                }
            }

            try
            {
                
                client.Close();
                stream.Close();
                tbReceive.AppendText("Client disconnected." + "\n");
                tbReceive.ScrollToCaret();
                LogLocal.WriteLogLocal(logDir, "Client disconnected.");
            }
            catch (Exception ex)
            {
                LogLocal.WriteLogLocal(logDir, ex.Message);
            }


            #endregion
        }

        #region Инициализирую процедуру получения данных от устройства
        private async void btnGetData_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
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
            if (chbSentQueue.Checked)
                timerSend.Enabled = true;
            else
                SendComandGetWeight(stream, tbMessage.Text.Trim());
        }
        #endregion

        #region Запись в поток сообщения для устройства COM 
        private bool SendComandGetWeight(NetworkStream astream, string command) 
        {
            byte[] converted = null;
            
            try
            {
               converted = System.Text.Encoding.GetEncoding(1251).GetBytes(command);
            }
            catch (ArgumentNullException ex)
            {
                // command is null.
                LogLocal.WriteLogLocal(LogLocal.logDir, ex.Message);
                return false;
            } 
            catch (EncoderFallbackException ex) 
            {
                // A fallback occurred (see Character Encoding in .NET for complete explanation)
                // -and- System.Text.Encoding.EncoderFallback is set to System.Text.EncoderExceptionFallback.
                LogLocal.WriteLogLocal(LogLocal.logDir, ex.Message);
                return false;
            }
            
            try
            {
                astream.Write(converted, 0, converted.Length); // пробуем записать в поток сообщение
                return true;
            }
            catch (ArgumentNullException ex)
            {
                //     The buffer parameter is null.
                LogLocal.WriteLogLocal(LogLocal.logDir, ex.Message);
                return false;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // The offset parameter is less than 0. -or- The offset parameter is greater than the length of buffer. -or- The size
                // parameter is less than 0. -or- The size parameter is greater than the length of buffer minus the value of the offset parameter.
                LogLocal.WriteLogLocal(LogLocal.logDir, ex.Message);
                return false;
            }
            catch (IOException ex)
            {
                // There was a failure while writing to the network. -or- An error occurred when accessing the socket.
                LogLocal.WriteLogLocal(LogLocal.logDir, ex.Message);
                return false;
            }
            catch (ObjectDisposedException ex) 
            {
                // The System.Net.Sockets.NetworkStream is closed. -or- There was a failure reading from the network.
                LogLocal.WriteLogLocal(LogLocal.logDir, ex.Message);
                return false;
            }
        }
        #endregion

        #region btnCloseConn_Click
        private void btnCloseConn_Click(object sender, EventArgs e)
        {
            //if (client != null)
            //{
            //    try
            //    {
            //        _workFlag = false;
            //        client.Close();
            //        tbReceive.AppendText("Client disconnected." + "\n");
            //        tbReceive.ScrollToCaret();  
            //        LogLocal.WriteLogLocal(logDir, "Client disconnected.");
            //    }
            //    catch (Exception ex)
            //    {
            //        LogLocal.WriteLogLocal(logDir, ex.Message);
            //    }
            //}
            _workFlag = false;
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

        private void timerSend_Tick(object sender, EventArgs e)
        {
            SendComandGetWeight(stream, tbMessage.Text.Trim());
        }

        private void chbSentQueue_CheckedChanged(object sender, EventArgs e)
        {
            timerSend.Stop();

            if(tbWaitSentMillisec.Enabled == true)
                tbWaitSentMillisec.Enabled = false; 
            else
                tbWaitSentMillisec.Enabled = true;  
        }

        private void formClientIP_Leave(object sender, EventArgs e)
        {
            _workFlag = false;
            
            if(client != null)
              client.Dispose();

            if (stream != null)
              stream.Dispose();
        }
    }
}
