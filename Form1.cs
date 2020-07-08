using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalkTalk
{
    public partial class Form1 : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        int portToConnect = 61000;
        public Form1()
        {
            InitializeComponent();
            StartServer();
        }

        #region  WebCam
        private void _BtnStartCam_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[_cmbCamList.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += videoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();

        }

        private void videoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            _pbUser1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
            {
                _cmbCamList.Items.Add(device.Name);
            }

            _cmbCamList.SelectedIndex = 0;

        }

        private void _BtnStopCam_Click(object sender, EventArgs e)
        {
            ReleaseResources();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReleaseResources();
        }

        private void ReleaseResources()
        {
            if (videoCaptureDevice.IsRunning)
                videoCaptureDevice.Stop();
        }

        #endregion


        #region SocketsServer
        private Socket _serverSocketServer, _clientSocketServer;
        private byte[] _buffer;

        private void ShowExceptionBox(string msg)
        {
            MessageBox.Show(msg, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void StartServer()
        {
            try
            {
                _serverSocketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _serverSocketServer.Bind(new IPEndPoint(IPAddress.Any, portToConnect));
                _serverSocketServer.Listen(0);
                _serverSocketServer.BeginAccept(new AsyncCallback(AcceptCallBack), null);
            }
            catch (Exception ex)
            {
                ShowExceptionBox(ex.Message);
            }
        }

        private void AcceptCallBack(IAsyncResult AR)
        {
            try
            {
                _clientSocketServer = _serverSocketServer.EndAccept(AR);
                _buffer = new byte[_clientSocketServer.ReceiveBufferSize];
                _clientSocketServer.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), null);
            }
            catch (Exception ex)
            {
                ShowExceptionBox(ex.Message);
            }
        }

        private void ReceiveCallBack(IAsyncResult AR)
        {
            try
            {
                int received = _clientSocketServer.EndReceive(AR);
                Array.Resize(ref _buffer, received);
                string text = Encoding.ASCII.GetString(_buffer);
                AppendToTextBox(text);
                Array.Resize(ref _buffer, _clientSocketServer.ReceiveBufferSize);
                _clientSocketServer.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), null);
            }
            catch (Exception ex)
            {
                ShowExceptionBox(ex.Message);
            }
        }

        private void AppendToTextBox(string text)
        {
            MethodInvoker invoker = new MethodInvoker(delegate
            {
                _txtServer.Text += text + Environment.NewLine;
            }
                );

            this.Invoke(invoker);
        }
        #endregion

        #region SocketsClient
        private Socket _clientSocketClient;
        //private byte[] buffer;

        private void _btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                _clientSocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _clientSocketClient.BeginConnect(new IPEndPoint(IPAddress.Loopback, portToConnect), new AsyncCallback(ConnectCallBack), null);
            }
            catch (Exception ex)
            {
                ShowExceptionBox(ex.Message);
            }
        }

        private void ConnectCallBack(IAsyncResult AR)
        {
            try
            {
                _clientSocketClient.EndConnect(AR);

                MessageBox.Show("Connected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowExceptionBox(ex.Message);
            }
        }

        private void _btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = Encoding.ASCII.GetBytes(_txtClient.Text);
                _clientSocketClient.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(SendCallBack), null);
            }
            catch (Exception ex)
            {
                ShowExceptionBox(ex.Message);
            }
        }

        private void SendCallBack(IAsyncResult AR)
        {
            try
            {
                _clientSocketClient.EndSend(AR);
            }
            catch (Exception ex)
            {
                ShowExceptionBox(ex.Message);
            }
        }
        #endregion

    }
}
