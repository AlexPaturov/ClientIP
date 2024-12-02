using ClientIP.UDPservices;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ClientIP
{
    public partial class FormClientIP : Form, IDisposable
    {
        private TcpClient _client;
        private CancellationTokenSource _udpCts;
        private UdpClient _udpServer;
        private TimeSpan _sendTimeout { get; set; }
        private TimeSpan _receiveTimeout { get; set; }
        private byte[] _buffer;
        private string _ipAddress = "127.0.0.1";
        private int _port = 8888;
        private string _ipUdp = "192.168.0.106"; // for client
        private int _UDPport = 10001;
        private IPEndPoint _epContr31;
        private volatile bool _workFlag = false;
        private NetworkStream _stream = null;
        private TaskCompletionSource<bool> tcs = null;
        private CancellationTokenSource _cancellationTokenSource;

        public FormClientIP()
        {
            _sendTimeout = TimeSpan.FromSeconds(200);
            _receiveTimeout = TimeSpan.FromSeconds(200);
            _buffer = new byte[1024];
            InitializeComponent();
        }

        private void formClientIP_Load(object sender, EventArgs e)
        {
            LogLocal.logDir = LogLocal.GetLocalDirPath(); // получаю путь к каталогу с логами
            LogLocal.WriteLogLocal(LogLocal.logDir, "Start      PROG: " + Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location));
            tbIp.Text = _ipAddress;
            tbPort.Text = _port.ToString();
            tbPortUDP.Text = _UDPport.ToString();
            tbIpUDP.Text = _ipUdp;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbReceive.Clear();
            tbBrutto.Clear();
            tbV13.Clear();  
            tbV24.Clear();
            tbV12.Clear();
            tbV34.Clear();
            tbPR.Clear();
            tbPP.Clear();
            tbDELTA.Clear();
        }

        private async void btnSetConn_Click(object sender, EventArgs e)
        {
            btnSetConn.Enabled = false;
            btnCloseConn.Enabled = true;
            tbReceive.AppendText(LogLocal.logDir + "\n");
            tbReceive.ScrollToCaret();

            bool connected = await SetConnectionAsync();
            if (connected)
            {
                await StartGettingDataAsync();
            }

            btnSetConn.Enabled = true;
        }

        private async Task<bool> SetConnectionAsync()
        {
            try
            {
                _client = new TcpClient();
                _client.NoDelay = true;
                _client.SendTimeout = (int)_sendTimeout.TotalMilliseconds;
                _client.ReceiveTimeout = (int)_receiveTimeout.TotalMilliseconds;
                _client.ReceiveBufferSize = _buffer.Length;

                await _client.ConnectAsync(_ipAddress, _port);
                _stream = _client.GetStream();

                LogLocal.WriteLogLocal($"Connected to {_ipAddress}:{_port}");
                tbReceive.AppendText($"Connected to {_ipAddress}:{_port}\n");
                tbReceive.ScrollToCaret();

                return true;
            }
            catch (SocketException ex)
            {
                LogLocal.WriteLogLocal($"Socket error: {ex.Message}");
                AppendTextToReceive($"Socket error: {ex.Message}\n");
                return false;
            }
            catch (Exception ex)
            {
                LogLocal.WriteLogLocal($"Unexpected error: {ex.Message}");
                AppendTextToReceive($"Unexpected error: {ex.Message}\n");
                return false;
            }
        }

        //------------------------------------------------------------------------------------------------------
        public async Task StartGettingDataAsync()
        {
            if (_workFlag)
            {
                AppendTextToReceive("Data reception is already running.\n");
                return;
            }

            if (_stream == null || !_client.Connected)
            {
                AppendTextToReceive("Client is not connected.\n");
                return;
            }

            _workFlag = true;
            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            try
            {
                while (_workFlag && _client.Connected)
                {
                    int bytesRead = await _stream.ReadAsync(_buffer, 0, _buffer.Length, token);
                    if (bytesRead > 0)
                    {
                        string receivedText = Encoding.GetEncoding(1251).GetString(_buffer, 0, bytesRead);
                        AppendTextToReceive($"Received {bytesRead} bytes: {receivedText}\n");
                        LogLocal.WriteLogLocal(receivedText);
                    }
                    else
                    {
                        await Task.Delay(10, token); // Non-blocking delay
                    }
                }
            }
            catch (OperationCanceledException)
            {
                AppendTextToReceive("Data reception canceled.\n");
            }
            catch (Exception ex)
            {
                AppendTextToReceive($"Data receiving error: {ex.Message}\n");
                LogLocal.WriteLogLocal($"Data receiving error: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
        }

        #region CloseConnection()
        private void CloseConnection()
        {
            if (_workFlag)
            {
                _cancellationTokenSource?.Cancel();
                _workFlag = false;
            }

            try
            {
                _stream?.Close();
                _client?.Close();
                AppendTextToReceive("Client disconnected.\n");
                LogLocal.WriteLogLocal("Client disconnected.");
            }
            catch (Exception ex)
            {
                LogLocal.WriteLogLocal($"Error closing connection: {ex.Message}");
                AppendTextToReceive($"Error closing connection: {ex.Message}\n");
            }
        }
        #endregion

        #region Инициализирую процедуру получения данных от устройства
        private async void BtnGetData_Click(object sender, EventArgs e)
        {
            if (_workFlag)
            {
                AppendTextToReceive("Data reception is already running.\n");
                return;
            }

            if (_client != null && _client.Connected)
            {
                btnGetData.Enabled = false;
                await StartGettingDataAsync();
                btnGetData.Enabled = true;
            }
            else
            {
                AppendTextToReceive("Client is not connected.\n");
                LogLocal.WriteLogLocal("Client is not connected.");
            }
        }
        #endregion

        #region отправляю данные в порт
        private async void BtnSend_Click(object sender, EventArgs e)
        {
            if (chbSentQueue.Checked)
            {
                timerSend.Enabled = true;
            }
            else
            {
                timerSend.Enabled = false;
                await SendCommandAsync(_stream, tbMessage.Text.Trim());
            }
        }
        #endregion

        #region Запись в NetworkStream сообщения для устройства 
        private async Task SendCommandAsync(NetworkStream aStream, string command)
        {
            if (aStream == null || !aStream.CanWrite)
            {
                AppendTextToReceive("Cannot write to the network stream.\n");
                LogLocal.WriteLogLocal("Cannot write to the network stream.");
                return;
            }

            try
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                byte[] converted = Encoding.GetEncoding(1251).GetBytes(command);
                await aStream.WriteAsync(converted, 0, converted.Length);
                LogLocal.WriteLogLocal($"Sent command: {command}");
                AppendTextToReceive($"Sent command: {command}\n");
            }
            catch (Exception ex)
            {
                LogLocal.WriteLogLocal($"Error sending command: {ex.Message}");
                AppendTextToReceive($"Error sending command: {ex.Message}\n");
            }
        }

        #endregion

        #region Закрыть соединение с устройством btnCloseConn()
        private void btnCloseConn_Click(object sender, EventArgs e)
        {
            CloseConnection();
        }
        #endregion

        #region AppendTextToReceive()
        private void AppendTextToReceive(string text)
        {
            if (tbReceive.InvokeRequired)
            {
                tbReceive.BeginInvoke(new Action<string>(AppendTextToReceive), text);
            }
            else
            {
                tbReceive.AppendText(text);
                tbReceive.ScrollToCaret();
            }
        }
        #endregion

        private void timerSend_Tick(object sender, EventArgs e)
        {
            SendCommandAsync(_stream, tbMessage.Text.Trim());
        }

        private void chbSentQueue_CheckedChanged(object sender, EventArgs e)
        {
            timerSend.Stop();

            if (tbWaitSentMillisec.Enabled == true)
                tbWaitSentMillisec.Enabled = false;
            else
                tbWaitSentMillisec.Enabled = true;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _cancellationTokenSource?.Cancel();
                _stream?.Dispose();
                _client?.Dispose();
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        #region UDP section ----------------------------------------
        private void setConnectionUDP_Click(object sender, EventArgs e)
        {
            try
            {
                _udpCts = new CancellationTokenSource();
                _udpServer = new UdpClient(Int32.Parse(tbPortUDP.Text.Trim())); // maby will be an exception, but maby )))))
                AppendTextToReceive($"UDP server is listening on port 10001 {DateTime.Now.ToString("HH:mm:ss.fff")} \n");
                Debug.WriteLine($"UDP server is listening on port 10001 {DateTime.Now.ToString("HH:mm:ss.fff")}");
            }
            catch (Exception ex)
            {
                AppendTextToReceive($"Set conn err:\n {ex.Message}\n");
                LogLocal.WriteLogLocal($"Set conn err:\n {ex.Message}");
            }
        }

        private async void startGetDataUDP_Click(object sender, EventArgs e)
        {
            try
            {
                while (!_udpCts.Token.IsCancellationRequested)
                {
                    // Use Task.Run to allow for cancellation checks
                    var receiveTask = _udpServer.ReceiveAsync();

                    // Wait for data or handle timeout
                    if (await Task.WhenAny(receiveTask, Task.Delay(5000, _udpCts.Token)) == receiveTask)
                    {
                        // Data received
                        var result = receiveTask.Result;
                        if ((result.Buffer is not null) && (result.Buffer.Length == 93))
                        {
                            UdpDecoder resultOfValue = new UdpDecoder(result);
                            ControllerMessage mess = resultOfValue.GetControllerMessage();
                            if (mess.wasError == false)
                            {
                                foreach (var item in mess.setOfValues)
                                {
                                    // добавить заполнение объекта XML формата
                                    // если данные принятые из udp корректные - возвращаю сообщение,
                                    // нет - возвращаю сообщение об ошибке 
                                    AppendTextToReceive(String.Format("{0,-8} [{1,-15:D}]\n", item.Key, item.Value));
                                    LogLocal.WriteLogLocal(String.Format("{0,-8} [{1,-15:D}]\n", item.Key, item.Value));
                                }
                            }
                        }
                        AppendTextToReceive($"You can process the received message further here {DateTime.Now.ToString("HH:mm:ss.fff")}\n");
                        LogLocal.WriteLogLocal($"You can process the received message further here {DateTime.Now.ToString("HH:mm:ss.fff")}");
                    }
                    else
                    {
                        AppendTextToReceive($"No data received within timeout period {DateTime.Now.ToString("HH:mm:ss.fff")}\n");
                        LogLocal.WriteLogLocal($"No data received within timeout period {DateTime.Now.ToString("HH:mm:ss.fff")}");
                    }
                }
            }
            catch (OperationCanceledException ex)
            {
                AppendTextToReceive($"UDP server has been stopped\n {ex.Message}\n");
                LogLocal.WriteLogLocal($"UDP server has been stopped\n {ex.Message}");
            }
            catch (SocketException ex)
            {
                AppendTextToReceive($"Socket error:\n {ex.Message}\n");
                LogLocal.WriteLogLocal($"Socket error:\n {ex.Message}");
            }
            catch (Exception ex)
            {
                AppendTextToReceive($"Unexpected error:\n {ex.Message}\n");
                LogLocal.WriteLogLocal($"Unexpected error:\n {ex.Message}");
            }
            finally
            {
                _udpServer.Dispose();
                Console.WriteLine(".");
                AppendTextToReceive($"UDP server resources have been released \n");
                LogLocal.WriteLogLocal($"UDP server resources have been released \n");
            }
        }

        private void closeConnectionUDP_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Stopping UDP server...");
            _udpCts.Cancel();
            _udpServer.Close();
        }

        private async void btnSendUDP_Click(object sender, EventArgs e)
        {
            _epContr31 = new IPEndPoint(IPAddress.Parse(_ipUdp), _UDPport);
            //_epContr31 = new IPEndPoint(IPAddress.Parse(_ipUdp), 10002);
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            byte[] buffer = Encoding.GetEncoding(1251).GetBytes(tbSendUDP.Text.Trim());
            await _udpServer.SendAsync(buffer, buffer.Length, _epContr31);
        }
        #endregion
    }
}
