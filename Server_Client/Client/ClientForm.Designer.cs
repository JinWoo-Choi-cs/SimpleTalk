namespace Client
{
    partial class ClientForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_handle_client = new System.Windows.Forms.ListView();
            this.ch_handle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_connected = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_buffersize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_bufferlength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.rtb_client_log = new System.Windows.Forms.RichTextBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_port_setting = new System.Windows.Forms.TextBox();
            this.tb_ipaddress_setting = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_error_log = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_handle_client
            // 
            this.lv_handle_client.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_handle,
            this.ch_connected,
            this.ch_buffersize,
            this.ch_bufferlength});
            this.lv_handle_client.HideSelection = false;
            this.lv_handle_client.Location = new System.Drawing.Point(12, 308);
            this.lv_handle_client.Name = "lv_handle_client";
            this.lv_handle_client.Size = new System.Drawing.Size(297, 244);
            this.lv_handle_client.TabIndex = 12;
            this.lv_handle_client.UseCompatibleStateImageBehavior = false;
            this.lv_handle_client.View = System.Windows.Forms.View.Details;
            // 
            // ch_handle
            // 
            this.ch_handle.Text = "Handle";
            // 
            // ch_connected
            // 
            this.ch_connected.Text = "Connect";
            // 
            // ch_buffersize
            // 
            this.ch_buffersize.Text = "BufferSize";
            this.ch_buffersize.Width = 79;
            // 
            // ch_bufferlength
            // 
            this.ch_bufferlength.Text = "LeftBuffer";
            this.ch_bufferlength.Width = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(12, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "HandledClient";
            // 
            // rtb_client_log
            // 
            this.rtb_client_log.Location = new System.Drawing.Point(340, 41);
            this.rtb_client_log.Name = "rtb_client_log";
            this.rtb_client_log.Size = new System.Drawing.Size(459, 514);
            this.rtb_client_log.TabIndex = 10;
            this.rtb_client_log.Text = "";
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_disconnect.Location = new System.Drawing.Point(160, 188);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(86, 40);
            this.btn_disconnect.TabIndex = 8;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_connect.Location = new System.Drawing.Point(58, 188);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(85, 40);
            this.btn_connect.TabIndex = 9;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(59, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Port  :";
            // 
            // tb_port_setting
            // 
            this.tb_port_setting.Font = new System.Drawing.Font("Arial", 10F);
            this.tb_port_setting.Location = new System.Drawing.Point(107, 159);
            this.tb_port_setting.Name = "tb_port_setting";
            this.tb_port_setting.Size = new System.Drawing.Size(139, 23);
            this.tb_port_setting.TabIndex = 6;
            this.tb_port_setting.Text = "4426";
            this.tb_port_setting.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_ipaddress_setting
            // 
            this.tb_ipaddress_setting.Font = new System.Drawing.Font("Arial", 10F);
            this.tb_ipaddress_setting.Location = new System.Drawing.Point(107, 130);
            this.tb_ipaddress_setting.Name = "tb_ipaddress_setting";
            this.tb_ipaddress_setting.Size = new System.Drawing.Size(139, 23);
            this.tb_ipaddress_setting.TabIndex = 6;
            this.tb_ipaddress_setting.Text = "127.0.0.1";
            this.tb_ipaddress_setting.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(59, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP     :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(337, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Client Log";
            // 
            // rtb_error_log
            // 
            this.rtb_error_log.Location = new System.Drawing.Point(839, 41);
            this.rtb_error_log.Name = "rtb_error_log";
            this.rtb_error_log.Size = new System.Drawing.Size(459, 514);
            this.rtb_error_log.TabIndex = 10;
            this.rtb_error_log.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.Location = new System.Drawing.Point(836, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Error Log";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 40F);
            this.label6.Location = new System.Drawing.Point(67, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 61);
            this.label6.TabIndex = 14;
            this.label6.Text = "Client";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1308, 567);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lv_handle_client);
            this.Controls.Add(this.rtb_error_log);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtb_client_log);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ipaddress_setting);
            this.Controls.Add(this.tb_port_setting);
            this.Name = "ClientForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientForm_Closed);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_handle_client;
        private System.Windows.Forms.ColumnHeader ch_handle;
        private System.Windows.Forms.ColumnHeader ch_connected;
        private System.Windows.Forms.ColumnHeader ch_buffersize;
        private System.Windows.Forms.ColumnHeader ch_bufferlength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtb_client_log;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_port_setting;
        private System.Windows.Forms.TextBox tb_ipaddress_setting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_error_log;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

