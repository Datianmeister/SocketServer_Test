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
using System.Threading;



namespace Socket_Test
{
    public partial class Form1 : Form
    {
        private string _ip;
        private int _port;
        private Socket _socket = null;
        private byte[] buffer = new byte[1024 * 1024 * 2];
        string status;
        int count = 0;

        public Thread Thread_Receive;                //声明一个Socket线程
        public Thread MainThread;


        //SocketClient client = new SocketClient();  //新建一个关于 SocketClient 的一个对象  这样才可以使用 SocketClient 中的函数

        int year, month, day, hour, Minute, Secend;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;  //不捕获跨线程控件调用检查
            MainThread = new Thread(Basic);
        }

        public void Basic()
        {
            while (true) 
            {
                if (this._socket.Connected == true)
                {
                    label_Status.Text = "连接成功";
                }
                else
                {
                    label_Status.Text = "未连接";
                }
            }
        }
        public void GetDateTime()
        {      
            DateTime dt = DateTime.Now;

            year = dt.Year;
            month = dt.Month;
            day = dt.Day;
            hour = dt.Hour;
            Minute = dt.Minute;
            Secend = dt.Second;
        }

        private void BT_TimeCheck_Click(object sender, EventArgs e)
        {
            GetDateTime();
            string DateTime = year.ToString() + month.ToString() + day.ToString();
            _socket.Send(Encoding.UTF8.GetBytes(DateTime));
        }

        public string StartClient()
        {
            try
            {
                label_Status.Text = "请稍等....";
                //1.0 实例化套接字(IP4寻址地址,流式传输,TCP协议)
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //允许SOCKET被绑定在已使用的地址上。
                _socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

                //2.0 创建IP对象
                IPAddress address = IPAddress.Parse(_ip);
                //3.0 创建网络端口包括ip和端口
                IPEndPoint endPoint = new IPEndPoint(address, _port);
                //4.0 建立连接
                _socket.Connect(endPoint);
                status = ("连接服务器成功");
                Thread_Receive = new Thread(Socket_Receive);
                Thread_Receive.Start();

            }
            catch
            {
                //_socket.Shutdown(SocketShutdown.Both);
                //_socket.Close();
                
                MessageBox.Show("连接超时，请检查IP地址与端口号是否正确", "Warning");
            }

            return status;
        }

        

        private void BT_SocketConnect_Click(object sender, EventArgs e)
        {
            Thread BT_Click = new Thread(delegate () { BT_SocketConnect_Click_Thread(); });
            
            
            BT_Click.IsBackground = true; //当主线程退出时，后台线程会被CLR调用Abort()来彻底终止程序
            BT_Click.Start();


        }

        public  void BT_SocketConnect_Click_Thread()
        {
            this._ip = TB_Ip.Text;
            this._port = int.Parse(TB_Port.Text);

            label_Status.Text = StartClient();
            if (label_Status.Text == "连接成功")
            {
                BT_SocketConnect.Enabled = false;
            }
        }

       /// <summary>
       /// 发送指定数据
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void BT_Send_Click(object sender, EventArgs e)
        {
            _socket.Send(Encoding.UTF8.GetBytes(TB_Send.ToString()));
        }
        /// <summary>
        /// 按键--断开端口连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_SocketDisConnect_Click(object sender, EventArgs e)
        {
            _socket.Shutdown(SocketShutdown.Both);
            _socket.Close();


            Thread_Receive.Interrupt();
            Thread_Receive.Abort();

            if (_socket.Connected == false) 
            {
                BT_SocketConnect.Enabled = true;
                label_Status.Text = "未连接";
            }
            

        }

        private void Socket_Receive()
        {
            byte[] buffer = new byte[2048];
            
            while (true)
            {
                if (buffer != null)
                {
                    TB_Receive.Text = _socket.Receive(buffer).ToString(); //会导致跨线程调用控件
                    label3.Text = count++.ToString();
                    //Thread thread1 = new Thread(new ParameterizedThreadStart(TB_Receive_delegate));
                    //thread1.Start(_socket.Receive(buffer).ToString());



                }
                
            }
        }


        ////TB_Receive访问委托 
        //private void TB_Receive_delegate(object str) 
        //{
        //    if (TB_Receive.InvokeRequired)// 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
        //    {
        //        Action<string> TB_ReceiveDelegate = (x) => { this.TB_Receive.Text = x.ToString(); };
        //        this.TB_Receive.Invoke(TB_ReceiveDelegate, str);
        //    }
        //    else
        //    {
        //        this.TB_Receive.Text = str.ToString();
        //    }

        //    if (label3.InvokeRequired)
        //    {
        //        Action<string> label3Delegate1 = (count) => { this.label3.Text = count.ToString(); };
        //        this.label3.Invoke(label3Delegate1,count);
        //    }

        //}

    }
}
