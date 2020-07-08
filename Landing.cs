﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalkTalk
{
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }
    }
}
