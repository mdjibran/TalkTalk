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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            StartClient();
        }


        #region SocketsClient
        private Socket _clientSocketClient;
        //private byte[] buffer;
        int portToConnect = 61000;


        private void StartClient()
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
        private void _btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                _clientSocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //_clientSocketClient.BeginConnect(new IPEndPoint(IPAddress.Loopback, portToConnect), new AsyncCallback(ConnectCallBack), null);
                _clientSocketClient.BeginConnect(new IPEndPoint(IPAddress.Parse("99.241.68.158"), portToConnect), new AsyncCallback(ConnectCallBack), null);
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

        //private void _btnSend_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        byte[] buffer = Encoding.ASCII.GetBytes(_txtBoxNewMsg.Text);
        //        _clientSocketClient.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(SendCallBack), null);
        //    }
        //    catch (Exception ex)
        //    {
        //        ShowExceptionBox(ex.Message);
        //    }
        //}

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

        private void ShowExceptionBox(string msg)
        {
            MessageBox.Show(msg, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        private void _btnSend_Click_1(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = Encoding.ASCII.GetBytes(_txtBoxNewMsg.Text);
                _clientSocketClient.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(SendCallBack), null);
                _txtMsgHistory.Text += "Me: "+_txtBoxNewMsg.Text + Environment.NewLine;

            }
            catch (Exception ex)
            {
                ShowExceptionBox(ex.Message);
            }
        }
    }
}
