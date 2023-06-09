using System;
using System.Net;
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
    public partial class GroupChattingRoom : Form
    {
        private string id;
        private Socket clientSocket;
        private Socket ClientSocket
        {
            get => clientSocket;
            set => clientSocket = value;
        }
        private readonly static int BufferSize = 4096;
        private Thread t;
        public GroupChattingRoom(Socket s, string id)
        {
            InitializeComponent();

            chattingList.Items.Clear();
            silenceChat.Items.Clear();
            this.id = id;
            this.ClientSocket = s;
            userID.Text = "ID : " + id;
            chattingList.Items.Add("Chatting Start");
        }

        private void sendMsg_Click(object sender, EventArgs e)
        {
            
            string msg;
            string[] sendTo;
            byte[] data;
            if (!(chattingText.Text.Trim() == ""))
            {
                msg = chattingText.Text;
                msg.Trim().Replace("\0", "");
                sendTo = msg.Split(':');
                if (sendTo.Length == 1)
                {
                    msg = "groupMessage_" + id + "_" + chattingText.Text;
                    chattingList.Items.Add("나\t:" + chattingText.Text);
                    data = Encoding.Unicode.GetBytes(msg);
                    ClientSocket.Send(data);
                    chattingText.Text = "";
                } else
                {
                    msg = "sendTo_" + id + "_" + chattingText.Text;
                    if (msg.Length == 2)
                    {
                        silenceChat.Items.Add($"[나 -> {sendTo[0]}]{sendTo[1]}");
                        data = Encoding.Unicode.GetBytes(msg);
                        ClientSocket.Send(data);
                        chattingText.Text = "";
                    } else
                    {
                        string str;
                        int leng;

                        str = sendTo[0];
                        leng = sendTo.Length - 1;
                        for (int i = 1; i < leng; i++)
                        {
                            str += $" ,{sendTo[i]}";
                        }
                        silenceChat.Items.Add($"[나 -> {str}]{sendTo[leng]}");
                        data = Encoding.Unicode.GetBytes(msg);
                        ClientSocket.Send(data);
                        chattingText.Text = "";
                    }
                }
            }
        }

        private void GroupChattingRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientSocket.Close();
            Application.Exit();
        }
        private void Received()
        {
            byte[] data = new byte[BufferSize];
            string[] mode;
            string str;
            try
            {
                do
                {
                    int n = clientSocket.Receive(data);
                    if (n > 0)
                    {
                        str = Encoding.Unicode.GetString(data, 0, n);
                        str = str.Trim().Replace("\0", "");
                        mode = str.Split(',');
                        if (mode[0] == "list")
                        {
                            showList.Items.Clear();
                            for (int i = 1; i < mode.Length; i++)
                            {
                                showList.Items.Add(mode[i]);
                            }
                        } else if (mode[0] == "silence")
                        {
                            silenceChat.Items.Add("[" + mode[1] + "]" + mode[2]);
                        } else if (mode[0] == "newConnect")
                        {
                            chattingList.Items.Add($"[{mode[1]} 님이 입장하셨습니다.]");
                            string msg;
                            byte[] datas;
                            msg = "showList_" + id;
                            datas = Encoding.Unicode.GetBytes(msg);
                            ClientSocket.Send(datas);
                        } else if (mode[0] == "disConnect")
                        {
                            chattingList.Items.Add($"[{mode[1]} 님이 채팅방을 나갔습니다.]");
                            string msg;
                            byte[] datas;
                            msg = "showList_" + id;
                            datas = Encoding.Unicode.GetBytes(msg);
                            ClientSocket.Send(datas);
                        } else if (mode[0] == "groupMessage")
                        {
                            chattingList.Items.Add(mode[1]);
                        } else if (mode[0].Equals("failSilence"))
                        {
                            silenceChat.Items.Add($"{mode[1]} - 사용자를 찾을 수 없습니다.");
                        } 
                    }
                }
                while (true);
            } catch (Exception)
            {
                Console.WriteLine($"Server disconnected.");
                ClientSocket.Close();
            }
        }

        private void GroupChattingRoom_Load(object sender, EventArgs e)
        {
            t = new Thread(new ThreadStart(Received));
            t.Start();
            string msg;
            byte[] datas;
            msg = "showList_" + id;
            datas = Encoding.Unicode.GetBytes(msg);
            ClientSocket.Send(datas);
        }

        private void showList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string str = $"{showList.SelectedItem}:";
            chattingText.Text = chattingText.Text + str;
        }

        private void chattingList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
