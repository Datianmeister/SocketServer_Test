
namespace Socket_Test
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_SocketConnect = new System.Windows.Forms.Button();
            this.TB_Ip = new System.Windows.Forms.TextBox();
            this.TB_Port = new System.Windows.Forms.TextBox();
            this.TB_Receive = new System.Windows.Forms.TextBox();
            this.label_Status = new System.Windows.Forms.Label();
            this.TB_Send = new System.Windows.Forms.TextBox();
            this.BT_Send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_SocketDisConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_SocketConnect
            // 
            this.BT_SocketConnect.Location = new System.Drawing.Point(217, 78);
            this.BT_SocketConnect.Name = "BT_SocketConnect";
            this.BT_SocketConnect.Size = new System.Drawing.Size(126, 52);
            this.BT_SocketConnect.TabIndex = 0;
            this.BT_SocketConnect.Text = "连接至服务端";
            this.BT_SocketConnect.UseVisualStyleBackColor = true;
            this.BT_SocketConnect.Click += new System.EventHandler(this.BT_SocketConnect_Click);
            // 
            // TB_Ip
            // 
            this.TB_Ip.Location = new System.Drawing.Point(56, 68);
            this.TB_Ip.Name = "TB_Ip";
            this.TB_Ip.Size = new System.Drawing.Size(140, 21);
            this.TB_Ip.TabIndex = 1;
            this.TB_Ip.Text = "192.168.4.1";
            // 
            // TB_Port
            // 
            this.TB_Port.Location = new System.Drawing.Point(56, 109);
            this.TB_Port.Name = "TB_Port";
            this.TB_Port.Size = new System.Drawing.Size(58, 21);
            this.TB_Port.TabIndex = 2;
            this.TB_Port.Text = "1001";
            // 
            // TB_Receive
            // 
            this.TB_Receive.Location = new System.Drawing.Point(49, 166);
            this.TB_Receive.Multiline = true;
            this.TB_Receive.Name = "TB_Receive";
            this.TB_Receive.Size = new System.Drawing.Size(207, 189);
            this.TB_Receive.TabIndex = 4;
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(215, 63);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(41, 12);
            this.label_Status.TabIndex = 5;
            this.label_Status.Text = "未连接";
            // 
            // TB_Send
            // 
            this.TB_Send.Location = new System.Drawing.Point(292, 166);
            this.TB_Send.Multiline = true;
            this.TB_Send.Name = "TB_Send";
            this.TB_Send.Size = new System.Drawing.Size(204, 189);
            this.TB_Send.TabIndex = 6;
            // 
            // BT_Send
            // 
            this.BT_Send.Location = new System.Drawing.Point(421, 361);
            this.BT_Send.Name = "BT_Send";
            this.BT_Send.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BT_Send.Size = new System.Drawing.Size(75, 23);
            this.BT_Send.TabIndex = 7;
            this.BT_Send.Text = "发送数据";
            this.BT_Send.UseVisualStyleBackColor = true;
            this.BT_Send.Click += new System.EventHandler(this.BT_Send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "发送数据";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "接受数据";
            // 
            // BT_SocketDisConnect
            // 
            this.BT_SocketDisConnect.Location = new System.Drawing.Point(363, 78);
            this.BT_SocketDisConnect.Name = "BT_SocketDisConnect";
            this.BT_SocketDisConnect.Size = new System.Drawing.Size(126, 52);
            this.BT_SocketDisConnect.TabIndex = 10;
            this.BT_SocketDisConnect.Text = "断开连接";
            this.BT_SocketDisConnect.UseVisualStyleBackColor = true;
            this.BT_SocketDisConnect.Click += new System.EventHandler(this.BT_SocketDisConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 396);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BT_SocketDisConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_Send);
            this.Controls.Add(this.TB_Send);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.TB_Receive);
            this.Controls.Add(this.TB_Port);
            this.Controls.Add(this.TB_Ip);
            this.Controls.Add(this.BT_SocketConnect);
            this.Name = "Form1";
            this.Text = "无线对时器(邱瀚天)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_SocketConnect;
        private System.Windows.Forms.TextBox TB_Ip;
        private System.Windows.Forms.TextBox TB_Port;
        private System.Windows.Forms.TextBox TB_Receive;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.TextBox TB_Send;
        private System.Windows.Forms.Button BT_Send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_SocketDisConnect;
        private System.Windows.Forms.Label label3;
    }
}

