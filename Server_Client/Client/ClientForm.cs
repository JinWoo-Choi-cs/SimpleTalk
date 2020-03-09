using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        Socket ClientSocket;
        readonly string _NL_ = Environment.NewLine;

        private void ClientForm_Load(object sender, EventArgs e)
        {
            ClientSocket = new Socket(SocketType.Stream, ProtocolType.IP);
            btn_disconnect.Enabled = false;
        }

        private void ClientForm_Closed(object sender, EventArgs e)
        {
            if (ClientSocket != null) ClientSocket.Dispose();
        }
      

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                IPEndPoint ServerEP = new IPEndPoint(IPAddress.Parse(tb_ipaddress_setting.Text), int.Parse(tb_port_setting.Text));
                ClientSocket.Connect(ServerEP);

                rtb_client_log.Text += "Server Connected" + _NL_;
                btn_connect.Enabled = false;
                btn_disconnect.Enabled = true;
            }
            catch(Exception msg)
            {
                rtb_error_log.Text += "------ Error : On Server Connect------" + _NL_ + msg + _NL_;
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                ClientSocket.Disconnect(true);

                rtb_client_log.Text += "Server Disconnected" + _NL_;
                btn_connect.Enabled = true;
                btn_disconnect.Enabled = false;
            }
            catch (Exception msg)
            {
                rtb_error_log.Text += "------ Error : On Server DisConnect------" + _NL_ + msg + _NL_;
            }
        }


    }
}
