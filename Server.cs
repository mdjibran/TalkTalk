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
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        #region SocketsServer
        private Socket _serverSocketServer, _clientSocketServer;
        private byte[] _buffer;
        int portToConnect = 61000;

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
    }
}
