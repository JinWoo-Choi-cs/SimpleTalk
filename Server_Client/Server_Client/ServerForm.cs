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


namespace Server_Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Socket MainSocket;
        List<AsyncObject> HandleClients;

        private delegate void lvUpdate();

        private void btn_server_start_Click(object sender, EventArgs e)
        {
            InitMainSocket();
        }

        private void btn_server_stop_Click(object sender, EventArgs e)
        {
            DisposeMainSocket();
            DisposeClientSocket();

            RefreshHandledClientListview();

            btn_server_start.Enabled = true;
            btn_server_stop.Enabled = false;
            tb_port_setting.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btn_server_stop.Enabled = false;

            HandleClients = new List<AsyncObject>();
        }

        private void InitMainSocket()
        {
            int Port = 0;
            if(! GetDigitFromControlText(tb_port_setting, out Port))
            {
                rtb_error_log.Text += "Port Isn't Not Digital" + Environment.NewLine;
                return;
            }

            try
            {
                MainSocket = new Socket(SocketType.Stream, ProtocolType.IP);
                IPEndPoint ServerEP = new IPEndPoint(IPAddress.Any, int.Parse(tb_port_setting.Text));

                MainSocket.Bind(ServerEP);
                MainSocket.Listen(10);

                MainSocket.BeginAccept(AsyncAccepted, null);
                btn_server_stop.Enabled = true;
                rtb_server_log.Text += $"Server Opened " + Environment.NewLine;
            }
            catch(Exception msg)
            {
                rtb_error_log.Text += $"--------- Error : InitMainSocket ---------" + Environment.NewLine + msg + Environment.NewLine;
            }
            finally
            {
                tb_port_setting.Enabled = false;
                btn_server_start.Enabled = false;
            }
        }

        private void AsyncAccepted(IAsyncResult _async_res)
        {
            try
            { 
                Socket Client = MainSocket.EndAccept(_async_res);

                Socket e = new Socket(SocketType.Stream,ProtocolType.Tcp);


                AsyncObject obj = new AsyncObject(4096);
                obj.working_socket = Client;

                HandleClients.Add(obj);

                rtb_server_log.Text += $"{Client.Handle} : ClientAccepted " + Environment.NewLine;

                // Client.BeginReceive();
            }
            catch (System.ObjectDisposedException e)
            {

            }
            catch (Exception msg)
            {
                rtb_error_log.Text += $"--------- Error : AsyncAccepted ---------" + Environment.NewLine + msg + Environment.NewLine;
            }

            RefreshHandledClientListview();
        }

        private void tb_port_setting_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(tb_port_setting.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please enter only numbers.");
            //    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            //}
        }

        private void DisposeMainSocket()
        {
            try 
            {
                MainSocket.Dispose();
                rtb_server_log.Text += $"MainSocekt Disposed" + Environment.NewLine;
            }
            catch (Exception msg)
            {
                rtb_error_log.Text += $"--------- Error : Closing Client ---------" + Environment.NewLine + msg + Environment.NewLine;
            }
        }

        private void DisposeClientSocket()
        {
            foreach (AsyncObject o in HandleClients)
            {
                if (o.working_socket.Connected)
                {
                    try
                    {
                        o.working_socket.Close();
                        o.working_socket.Dispose();

                        rtb_server_log.Text += $"{o.working_socket.Handle} : Client Disposed" + Environment.NewLine;
                    }
                    catch (Exception msg)
                    {
                        rtb_error_log.Text += $"--------- Error : Closing Client ---------" + Environment.NewLine + msg + Environment.NewLine;
                    }
                }
                if(o.working_socket == null)
                {
                    HandleClients.Remove(o);
                }
            }
        }

        /// <summary>
        /// 접속중인 클라이언트 리스트를 리스트뷰에 갱신한다.
        /// </summary>
        private void RefreshHandledClientListview()
        {
            if(this.lv_handle_client.InvokeRequired)
            {
                this.Invoke(new lvUpdate(RefreshHandledClientListview));
            }

            else
            {
                lv_handle_client.BeginUpdate();
                lv_handle_client.Items.Clear();

                ListViewItem item;
                foreach (AsyncObject o in HandleClients)
                {
                    item = new ListViewItem(o.working_socket.Handle.ToString());

                    item.SubItems.Add($"{o.working_socket.Connected}");
                    item.SubItems.Add($"{o.buffer_size}");
                    item.SubItems.Add($"{o.received_buffer.Length}");

                    lv_handle_client.Items.Add(item);
                }

                lv_handle_client.EndUpdate();
            }
        }


        /// <summary>
        /// Control(TextBox)의 Text가  Digital 값인지 확인. 
        /// </summary>
        /// <param name="_control">Text 값을 변환시킬 컨트롤</param>
        /// <param name="_result">결과값, default = 0</param>
        /// <returns>성공 : true , 실패 : false</returns>
        private bool GetDigitFromControlText(Control _control, out int _result)
        {
            Dictionary<String, int> DefaultDigit = new Dictionary<string, int>();
            DefaultDigit.Add("tb_port_setting", 4426);

            if(int.TryParse(_control.Text, out _result))
            {
                return true;
            }
            else
            {
                if(DefaultDigit.ContainsKey(_control.Name))
                {
                    _result = DefaultDigit[_control.Name];
                    return true;
                }

                _result = 0;
                return false;
            }
        }


    }
}
