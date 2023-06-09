using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkProject
{
    public partial class OpenChattingRoom : Form
    {
        private string id;
        private string anonymousID;
        private Socket clientSocket;
        private Socket ClientSocket
        {
            get => clientSocket;
            set => clientSocket = value;
        }
        private readonly static int BufferSize = 4096;
        private Thread t;
        public OpenChattingRoom(Socket s, string id, string anonymousID)
        {
            InitializeComponent();

            chattingList.Items.Clear();
            this.id = id;
            this.anonymousID = anonymousID;
            this.clientSocket = s;
            label1.Text = "ID : " + id + " - " + anonymousID;
        }

        private void chattingText_TextChanged(object sender, EventArgs e)
        {
        }

        private void sendMsg_Click(object sender, EventArgs e)
        {
            string msg;
            byte[] data;
            if (!(chattingText.Text.Trim() == ""))
            {
                msg = "openChatting_" + id + "=" + anonymousID + "_" + chattingText.Text;
                msg.Trim().Replace("\0", "");

                chattingList.Items.Add("나\t:" + chattingText.Text);
                data = Encoding.Unicode.GetBytes(msg);
                ClientSocket.Send(data);
                chattingText.Text = "";
            }
        }

        private void Received()
        {
            byte[] data = new byte[BufferSize];
            string str;
            try
            {
                do
                {
                    int n = clientSocket.Receive(data);
                    if (n > 0)
                    {
                        str = Encoding.Unicode.GetString(data, 0, n);
                        str.Trim().Replace("\0", "");
                        chattingList.Items.Add(str);
                        data = new byte[BufferSize];
                    }
                }
                while (true);
            }
            catch (Exception)
            {
                Console.WriteLine($"Server disconnected.");
                ClientSocket.Close();
            }
        }

        private void OpenChattingRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientSocket.Close();
            Application.Exit();
        }

        private void OpenChattingRoom_Load(object sender, EventArgs e)
        {
            t = new Thread(new ThreadStart(Received));
            t.Start();
        }
    }
}
