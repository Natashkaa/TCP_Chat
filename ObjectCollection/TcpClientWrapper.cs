using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCollection
{
    public class TcpClientWrapper
    {
        public TcpClient Client { get; set; }
        public StreamReader Reader { get; set; }
        public StreamWriter Writer { get; set; }

        public TcpClientWrapper(TcpClient client)
        {
            Client = client;
            Reader = new StreamReader(Client.GetStream());
            Writer = new StreamWriter(Client.GetStream());
        }

        public void WriteLine(string data)
        {
            Writer.WriteLine(data);
            Writer.Flush();
        }

        public string ReadLine()
        {
            return Reader.ReadLine();
        }

        public void Close()
        {
            Writer.Close();
            Reader.Close();
            Client.Close();
        }
    }
}
