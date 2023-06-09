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
    public partial class PrivateChattingRoom : Form
    {
        private string id;
        private Socket clientSocket;
        private bool chatting = false;
        private Socket ClientSocket
        {
            get => clientSocket;
            set => clientSocket = value;
        }
        private readonly static int BufferSize = 4096;
        private Thread t;
        public PrivateChattingRoom(Socket s, string id)
        {
            InitializeComponent();

            chattingList.Items.Clear();
            this.id = id;
            this.clientSocket = s;
            label1.Text = "";
            label2.Text = "ID : " + id;
        }

        private void chattingText_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendMsg_Click(object sender, EventArgs e)
        {
            string msg;
            if (!(chattingText.Text.Trim() == ""))
            {
                if (chatting == false)
                {
                    chattingList.Items.Add("연결된 클라이언트가 존재하지 않습니다.");
                    chattingText.Text = "";
                } else
                {
                    msg = "나  : " + chattingText.Text;
                    chattingList.Items.Add(msg);
                    msg = "randomMsg_" + id + "_" + chattingText.Text;
                    clientSocket.Send(Encoding.Unicode.GetBytes(msg));
                    chattingText.Text = "";
                }
            }
        }
        private void Received()
        {
            byte[] data = new byte[BufferSize];
            string str;
            string[] mode;
            try
            {
                do
                {
                    int n = clientSocket.Receive(data);
                    if (n > 0)
                    {
                        str = Encoding.Unicode.GetString(data);
                        str.Trim().Replace("\0", "");
                        mode = str.Split('_');
                        if (mode[0].Equals("waitState"))
                        {
                            chattingList.Items.Clear();
                            label1.Text = "wait";
                            chatting = false;
                        }
                        else if (mode[0].Equals("noClients"))
                        {
                            chattingList.Items.Clear();
                            label1.Text = "no clients";
                            chatting = false;
                        } else if (mode[0].Equals("chattingON")) {
                            chatting = true;
                            chattingList.Items.Clear();
                            chattingList.Items.Add("chatting start");
                            label1.Text = "";
                        } else if (mode[0].Equals("randomMsg"))
                        {
                            str = "익명:" + mode[1];
                            chattingList.Items.Add(str);
                        } else if (mode[0].Equals("disconnectChat"))
                        {
                            chattingList.Items.Add("[상대방이 연결을 종료하였습니다.]");
                            chatting = false;
                        }
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

        private void PrivateChattingRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientSocket.Close();
            Application.Exit();
        }

        private void PrivateChattingRoom_Load(object sender, EventArgs e)
        {
            t = new Thread(new ThreadStart(Received));
            t.Start();
        }

        private void waitState_Click(object sender, EventArgs e)
        {
            if (chatting == true)
            {
                clientSocket.Send(Encoding.Unicode.GetBytes("waitStateTrue_" + id));
            } else
            {
                clientSocket.Send(Encoding.Unicode.GetBytes("waitState_" + id));
            }
        }

        private void startChat_Click(object sender, EventArgs e)
        {
            if (chatting == true)
            {
                clientSocket.Send(Encoding.Unicode.GetBytes("startRandomChatTrue_" + id));
            } else
            {
                clientSocket.Send(Encoding.Unicode.GetBytes("startRandomChat_" + id));
            }
        }
    }
}
