using Newtonsoft.Json;
using ObjectCollection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        #region fields
        static IPAddress ip = IPAddress.Parse("127.0.0.1");
        static IPEndPoint ep = new IPEndPoint(ip, 12345);
        static TcpListener server = new TcpListener(ep);
        static Thread thread;
        static UsersCollection userList = new UsersCollection();
        static List<TcpClientWrapper> allClients = new List<TcpClientWrapper>();

        static string path_user_id_file = "../../../Server/HelpFiles/user_id.txt";

        #endregion

        static void Main(string[] args)
        {
            server.Start();
            Console.WriteLine("Server started...");
            while (true)
            {
                TcpClientWrapper client = new TcpClientWrapper(server.AcceptTcpClient());
                allClients.Add(client);
                Console.WriteLine($"[{DateTime.Now}]:{client.Client.Client.RemoteEndPoint.ToString()} has joined");

                thread = new Thread(() => Work(client));
                thread.Start();
            }
        }

        static void Work(TcpClientWrapper client)
        {
            while (client.Client.Connected)
            {
                    string tmp = client.ReadLine();
                    if (tmp.Contains("Type\":\"user"))//проверка на пользователя
                    {
                        User user = JsonConvert.DeserializeObject<User>(tmp);
                        if (user.NeedDelete)
                        {
                            Message notifMessage = new Message();
                            notifMessage.Content = $"[{DateTime.Now}][{user.Name}] has left chat\r\n";
                            string jsonMessage = JsonConvert.SerializeObject(notifMessage, Formatting.None);
                            foreach (var cl in allClients)
                            {
                                cl.WriteLine(jsonMessage);
                            }
                            Console.WriteLine($"[{DateTime.Now}]:{client.Client.Client.RemoteEndPoint.ToString()} left");
                            client.Client.Client.Close();
                            allClients.Remove(client);
                            userList.Data.Remove(user);
                            string jsonUsers = JsonConvert.SerializeObject(userList, Formatting.None);
                            foreach (var cl in allClients)
                            {
                                cl.WriteLine(jsonUsers);
                            }
                        }
                        else
                        {
                            StreamReader readId = new StreamReader(path_user_id_file);
                            int get_id = Convert.ToInt32(readId.ReadLine());
                            readId.Close();
                            user.Id = get_id;

                            StreamWriter writeId = new StreamWriter(path_user_id_file);
                            writeId.WriteLine(++get_id);
                            writeId.Flush();
                            writeId.Close(); 
                            userList.Data.Add(user);
                            string jsonUsers = JsonConvert.SerializeObject(userList, Formatting.None);

                            foreach (var cl in allClients)
                            {
                                cl.WriteLine(jsonUsers);
                            }
                            Message notifMessage = new Message();
                            notifMessage.Content = $"[{DateTime.Now}][{user.Name}] has joined chat\r\n";
                            string jsonMessage = JsonConvert.SerializeObject(notifMessage, Formatting.None);
                            foreach (var cl in allClients)
                            {
                                cl.WriteLine(jsonMessage);
                            }
                        }
                    }
                    else if (tmp.Contains("Type\":\"message"))
                    {
                        Message message = JsonConvert.DeserializeObject<Message>(tmp);
                        string fullMessage = $"[{DateTime.Now}][{message.Sender}]:{message.Content}\r\n";
                        message.Content = fullMessage;
                        string jsonMessage = JsonConvert.SerializeObject(message, Formatting.None);
                        foreach (var cl in allClients)
                        {
                            cl.WriteLine(jsonMessage);
                        }
                    }
            }
        }
    }
}
