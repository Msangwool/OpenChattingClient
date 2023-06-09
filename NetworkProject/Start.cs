using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkProject
{
    public partial class Start : Form
    {
        private string id;
        private Socket clientSocket;
        private readonly static int BufferSize = 4096;
        public Start(Socket s, string id)
        {
            InitializeComponent();

            this.id = id;
            this.clientSocket = s;
        }

        private void startRandom_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrivateChattingRoom privateChattingRoom = new PrivateChattingRoom(clientSocket, id);
            privateChattingRoom.Owner = this;
            privateChattingRoom.Show();
        }

        private void openChatting_Click(object sender, EventArgs e)
        {
            string[] newID;
            byte[] bytes = new byte[BufferSize];
            string msg = "connectOpenChatting_" + id;
            bytes = Encoding.Unicode.GetBytes(msg);
            clientSocket.Send(bytes);

            bytes = new byte[BufferSize];
            int nbytes = clientSocket.Receive(bytes);
            if (nbytes > 0)
            {
                msg = Encoding.Unicode.GetString(bytes);
                msg = msg.Trim().Replace("\0", "");
                newID = msg.Split('=');
                this.Hide();
                OpenChattingRoom openChattingRoom = new OpenChattingRoom(clientSocket, newID[0], newID[1]);
                openChattingRoom.Owner = this;
                openChattingRoom.Show();
            }
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientSocket.Close();
            Application.Exit();
        }
    }
}
