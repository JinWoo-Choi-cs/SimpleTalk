namespace Server_Client
{
    partial class MainForm
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
            this.tb_port_setting = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_server_start = new System.Windows.Forms.Button();
            this.btn_server_stop = new System.Windows.Forms.Button();
            this.rtb_server_log = new System.Windows.Forms.RichTextBox();
            this.rtb_error_log = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lv_handle_client = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.ch_handle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_connected = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_buffersize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_bufferlength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tb_port_setting
            // 
            this.tb_port_setting.Font = new System.Drawing.Font("Arial", 10F);
            this.tb_port_setting.Location = new System.Drawing.Point(60, 35);
            this.tb_port_setting.Name = "tb_port_setting";
            this.tb_port_setting.Size = new System.Drawing.Size(85, 23);
            this.tb_port_setting.TabIndex = 0;
            this.tb_port_setting.Text = "4426";
            this.tb_port_setting.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_port_setting.TextChanged += new System.EventHandler(this.tb_port_setting_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port :";
            // 
            // btn_server_start
            // 
            this.btn_server_start.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_server_start.Location = new System.Drawing.Point(164, 26);
            this.btn_server_start.Name = "btn_server_start";
            this.btn_server_start.Size = new System.Drawing.Size(61, 40);
            this.btn_server_start.TabIndex = 2;
            this.btn_server_start.Text = "Server\r\nStart";
            this.btn_server_start.UseVisualStyleBackColor = true;
            this.btn_server_start.Click += new System.EventHandler(this.btn_server_start_Click);
            // 
            // btn_server_stop
            // 
            this.btn_server_stop.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_server_stop.Location = new System.Drawing.Point(236, 26);
            this.btn_server_stop.Name = "btn_server_stop";
            this.btn_server_stop.Size = new System.Drawing.Size(61, 40);
            this.btn_server_stop.TabIndex = 2;
            this.btn_server_stop.Text = "Server\r\nStop";
            this.btn_server_stop.UseVisualStyleBackColor = true;
            this.btn_server_stop.Click += new System.EventHandler(this.btn_server_stop_Click);
            // 
            // rtb_server_log
            // 
            this.rtb_server_log.Location = new System.Drawing.Point(311, 38);
            this.rtb_server_log.Name = "rtb_server_log";
            this.rtb_server_log.Size = new System.Drawing.Size(278, 403);
            this.rtb_server_log.TabIndex = 3;
            this.rtb_server_log.Text = "";
            // 
            // rtb_error_log
            // 
            this.rtb_error_log.Location = new System.Drawing.Point(595, 38);
            this.rtb_error_log.Name = "rtb_error_log";
            this.rtb_error_log.Size = new System.Drawing.Size(717, 403);
            this.rtb_error_log.TabIndex = 3;
            this.rtb_error_log.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(592, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Error Log";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(308, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Server Log";
            // 
            // lv_handle_client
            // 
            this.lv_handle_client.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_handle,
            this.ch_connected,
            this.ch_buffersize,
            this.ch_bufferlength});
            this.lv_handle_client.HideSelection = false;
            this.lv_handle_client.Location = new System.Drawing.Point(8, 107);
            this.lv_handle_client.Name = "lv_handle_client";
            this.lv_handle_client.Size = new System.Drawing.Size(297, 331);
            this.lv_handle_client.TabIndex = 5;
            this.lv_handle_client.UseCompatibleStateImageBehavior = false;
            this.lv_handle_client.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "HandledClient";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 450);
            this.Controls.Add(this.lv_handle_client);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtb_error_log);
            this.Controls.Add(this.rtb_server_log);
            this.Controls.Add(this.btn_server_stop);
            this.Controls.Add(this.btn_server_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_port_setting);
            this.Name = "MainForm";
            this.Text = "MainServer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_port_setting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_server_start;
        private System.Windows.Forms.Button btn_server_stop;
        private System.Windows.Forms.RichTextBox rtb_server_log;
        private System.Windows.Forms.RichTextBox rtb_error_log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lv_handle_client;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader ch_handle;
        private System.Windows.Forms.ColumnHeader ch_connected;
        private System.Windows.Forms.ColumnHeader ch_buffersize;
        private System.Windows.Forms.ColumnHeader ch_bufferlength;
    }
}

