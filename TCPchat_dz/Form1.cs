using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using ObjectCollection;
using Newtonsoft.Json;
using System.Threading;
using System.Net.Mail;

namespace TCPchat_dz
{
    public partial class Form1 : Form
    {
        string myName;
        string myLoginMail, myMailPassword;
        string anothersMail;
        string newMessage;

        TcpClient client;
        StreamReader reader;
        StreamWriter writer;
        IPEndPoint ep;

        User me;
        public List<User> onlineUsers;

        Thread updateThread;

        public Form1()
        {
            InitializeComponent();
            myLoginMail = myMailLog.Text;
            myMailPassword = myMailPass.Text;
            anothersMail=usersMailBox.Text;
            ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            onlineUsers = new List<User>();   
        }
    
        private void loginButton_Click(object sender, EventArgs e)
        {
            myName = myNameBox.Text;
            myLoginMail = myMailLog.Text;
            myMailPassword = myMailPass.Text;
            if (myName == "" || myLoginMail == "" || myMailPassword == "")
            {
                MessageBox.Show("Fill in all fields", "log in false", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.Enabled = true;
            myNameBox.Enabled = false;
            newMessageBox.Enabled = true;
            loginButton.Enabled = false;
            ofdButton.Enabled = true;
            sendMessageButton.Enabled = true;
            logoutButton.Enabled = true;
            sendHistoryButton.Enabled = true;
            
            me = new User() { Name = myName, MailLog = myLoginMail, MailPas = myMailPassword };
            client = new TcpClient();
            client.Connect(ep);
            reader = new StreamReader(client.GetStream());
            writer = new StreamWriter(client.GetStream());

            string json = JsonConvert.SerializeObject(me, Formatting.None);
            writer.WriteLine(json);
            writer.Flush();

            updateThread = new Thread(UpdateUsersAndMessage);
            updateThread.Start();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            me.NeedDelete = true;
            string json = JsonConvert.SerializeObject(me, Formatting.None);
            writer.WriteLine(json);
            writer.Flush();

            dataGridView1.Invoke(new Action(() => { dataGridView1.DataSource = null; }));
            updateThread.Abort();
            client.GetStream().Close();
            client.Close();
            
            myNameBox.Enabled = true;
            newMessageBox.Enabled = false;
            loginButton.Enabled = true;
            ofdButton.Enabled = false;
            sendMessageButton.Enabled = false;
            logoutButton.Enabled = false;
            dataGridView1.Enabled = false;
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            newMessage = newMessageBox.Text;
            ObjectCollection.Message message = new ObjectCollection.Message() { Content = newMessage, Sender = me.Name };
            string json = JsonConvert.SerializeObject(message, Formatting.None);
            writer.WriteLine(json);
            writer.Flush();
            newMessageBox.Text = "";
        }

        private void sendHistoryButton_Click(object sender, EventArgs e)
        {
            anothersMail = usersMailBox.Text;
            if (anothersMail == "")
            {
                MessageBox.Show("What about recipient?", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(myLoginMail);
            mailMessage.To.Add(anothersMail);
            mailMessage.Subject = "message history";
            mailMessage.Body = messageList.Text;

            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com", 587);
            smtpServer.Credentials = new NetworkCredential(myLoginMail, myMailPassword);
            smtpServer.EnableSsl = true;
            smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            Task.Run(() =>
            {
                smtpServer.Send(mailMessage);
            });
        }

        void UpdateUsersAndMessage()
        {
            while (client.Connected)
            {
                string resFromServ = reader.ReadLine();
                if (resFromServ != null)
                {
                    if (resFromServ.Contains("Type\":\"users"))
                    {
                        UsersCollection resUsers = JsonConvert.DeserializeObject<UsersCollection>(resFromServ);
                        dataGridView1.Invoke(new Action(() => { dataGridView1.DataSource = resUsers.Data; }));
                    }
                    else if (resFromServ.Contains("Type\":\"message"))
                    {
                        ObjectCollection.Message resMessage = JsonConvert.DeserializeObject<ObjectCollection.Message>(resFromServ);
                        messageList.Text += resMessage.Content;
                    }
                }
            }
        }
    }
}
