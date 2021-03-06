using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SocketClient_Test
{
    public class SocketClient
    {
        private string _ip = string.Empty;
        private int _port = 0;
        private Socket _socket = null;
        private byte[] buffer = new byte[1024 * 1024 * 2];
        string status;


        /// <summary>
        /// 开启服务,连接服务端
        /// </summary>
        public string StartClient(string _ip, int _port)
        {
            try
            {
                //1.0 实例化套接字(IP4寻址地址,流式传输,UDP协议)
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                //2.0 创建IP对象
                IPAddress address = IPAddress.Parse(_ip);

                //3.0 创建网络端口包括ip和端口
                IPEndPoint endPoint = new IPEndPoint(address, _port);

                //4.0 建立连接
                _socket.Connect(endPoint);  
                //Console.WriteLine("连接服务器成功");
                status = ("连接服务器成功");
                
                //5.0 接收数据
                //int length = _socket.Receive(buffer);
                //Console.WriteLine("接收服务器{0},消息:{1}", _socket.RemoteEndPoint.ToString(), Encoding.UTF8.GetString(buffer, 0, length));

                ////6.0 向服务器发送消息
                //for (int i = 0; i < 10; i++)
                //{
                //    Thread.Sleep(2000);
                //    string sendMessage = string.Format("客户端发送的消息,当前时间{0}", DateTime.Now.ToString());
                //    _socket.Send(Encoding.UTF8.GetBytes(sendMessage));
                //    //Console.WriteLine("向服务端发送的消息:{0}", sendMessage);
                //}

            }
            catch (Exception ex)
            {
                _socket.Shutdown(SocketShutdown.Both);
                _socket.Close();
                Console.WriteLine(ex.Message);
            }
            //Console.WriteLine("发送消息结束");
            return status;
        }

        public static void SendData(string data)
        {
            
        }
    }
}


