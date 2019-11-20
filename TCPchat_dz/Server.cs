using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPchat_dz
{
    public  static class Server
    {
        public static Socket Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public const string Host = "127.0.0.1";
        public const int Port = 12345;
        public static bool Work = true;
    }
}
