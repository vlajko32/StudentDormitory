using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {

        private Server server = new Server();
        public FrmServer()
        {
            InitializeComponent();
            btnStop.Enabled = false;
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {

                server.Start();
                Thread thread = new Thread(server.Listen);
                thread.Start();
                thread.IsBackground = true;
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            } catch(SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
    }

        private void btnStop_Click(object sender, EventArgs e)
        {
            server.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
    }
}
