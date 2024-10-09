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
    public partial class FormClientIP : Form, IDisposable
    {
        private TcpClient _client;
        private TimeSpan _sendTimeout { get; set; }
        private TimeSpan _receiveTimeout { get; set; }
        private byte[] _buffer;
        private string _ipAddress = "127.0.0.1";
        private int _port = 8887;
        private volatile bool _workFlag = false;
        private string _logDir = string.Empty;
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbReceive.Clear();
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

                LogLocal.WriteLogLocal(_logDir, $"Connected to {_ipAddress}:{_port}");
                tbReceive.AppendText($"Connected to {_ipAddress}:{_port}\n");
                tbReceive.ScrollToCaret();

                return true;
            }
            catch (SocketException ex)
            {
                LogLocal.WriteLogLocal(_logDir, $"Socket error: {ex.Message}");
                AppendTextToReceive($"Socket error: {ex.Message}\n");
                return false;
            }
            catch (Exception ex)
            {
                LogLocal.WriteLogLocal(_logDir, $"Unexpected error: {ex.Message}");
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
                        LogLocal.WriteLogLocal(_logDir, receivedText);
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
                LogLocal.WriteLogLocal(_logDir, $"Data receiving error: {ex.Message}");
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
                LogLocal.WriteLogLocal(_logDir, "Client disconnected.");
            }
            catch (Exception ex)
            {
                LogLocal.WriteLogLocal(_logDir, $"Error closing connection: {ex.Message}");
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
                LogLocal.WriteLogLocal(_logDir, "Client is not connected.");
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
                LogLocal.WriteLogLocal(_logDir, "Cannot write to the network stream.");
                return;
            }

            try
            {
                byte[] converted = Encoding.GetEncoding(1251).GetBytes(command);
                await aStream.WriteAsync(converted, 0, converted.Length);
                LogLocal.WriteLogLocal(_logDir, $"Sent command: {command}");
                AppendTextToReceive($"Sent command: {command}\n");
            }
            catch (Exception ex)
            {
                LogLocal.WriteLogLocal(_logDir, $"Error sending command: {ex.Message}");
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

            if(tbWaitSentMillisec.Enabled == true)
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
    }
}
