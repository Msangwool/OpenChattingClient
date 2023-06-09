using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkProject
{
    public partial class login : Form
    {
        private string id;                                                          // 사용자 아이디 전역변수
        private Socket clientSocket;                                                // 소켓 선언
        public Socket ClientSocket
        {
            get => clientSocket;
            set => clientSocket = value;
        }
        private readonly static int BufferSize = 4096;
        private IPEndPoint EndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3000);

        public login()
        {
            InitializeComponent();

            ClientSocket = new Socket(                                              // 소켓 생성
                EndPoint.AddressFamily,
                SocketType.Stream,
                ProtocolType.Tcp
            );

            ClientSocket.Connect(EndPoint);                                         // 소켓 connect
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btnAnonymous_Click(object sender, EventArgs e)     // anonymous 버튼 클릭시
        {
            id = userID.Text;                                           // 사용자가 입력한 아이디 값을 불러옴(필요없는 공백제거).
            if (id.Trim() == "")                                        // 사용자가 빈 값을 입력했다면, 
            {
                label.Text = "아이디를 입력해주세요.";                  // label에 힌트를 줌.
                userID.Text = "";                                       // userID -- TextBox 초기화
            } else
            {
                id = "anonymous_" + id;                                 // 랜덤 익명 채팅을 하는 사용자임을 알려줌.
                byte[] dataID = Encoding.Unicode.GetBytes(id);          // 위 id를 byte 배열로 변환.
                clientSocket.Send(dataID);                              // byte 배열을 client에게 보냄.

                dataID = new byte[BufferSize];                          // dataID 초기화.
                try
                {
                    int n = ClientSocket.Receive(dataID);               // 바이트 배열 receive
                    if (n > 0)
                    {                                                   // 범위가 정상적이라면 Redirect 메소드 호출
                        Redirect(dataID);
                    }
                    else { throw new Exception(); }
                }
                catch (Exception)
                {
                    label.Text = "서버오류 발생.";
                }
            }
        }

        private void btnNomal_Click(object sender, EventArgs e)
        {
            id = userID.Text;                                           // 사용자가 입력한 아이디 값을 불러옴(필요없는 공백제거).
            if (id.Trim() == "")                                        // 사용자가 빈 값을 입력했다면, label에 힌트를 줌.
            {
                label.Text = "아이디를 입력해주세요.";
                userID.Text = "";                                       // userID -- TextBox 초기화
            }
            else
            {
                id = "general_" + id;                                   // 일반 채팅을 하는 사용자임을 알려줌.
                byte[] dataID = Encoding.Unicode.GetBytes(id);          // 위 id를 byte 배열로 변환.
                ClientSocket.Send(dataID);                              // byte 배열을 client에게 보냄.

                dataID = new byte[BufferSize];                          // dataID 초기화.
                try
                {
                    int n = ClientSocket.Receive(dataID);
                    if (n > 0)
                    {
                        Redirect(dataID);
                    }
                    else { throw new Exception(); }
                }
                catch (Exception)
                {
                    label.Text = "서버오류 발생.";
                }
            }
        }

        private void Redirect(byte[] byteID)
        {
            string str = Encoding.Unicode.GetString(byteID);
            str = str.Trim().Replace("\0", "");                         // 받아온 바이트 배열 str로 문자열 처리
            string[] tokens = str.Split('_');                           // receive한 문자열 이렇게 처리 안 해주면 같아도 같지 않다고 나옴. (Trim도 소용없음)
            string mode = tokens[0];
            if (mode.Equals("anonymous"))                               // 익명 채팅을 위한 문자인지 확인.
            {
                if (str.Equals(id))                                     // 공백을 제거한 strID를 기존 id와 비교함.
                {                                                       // 만일 기존 id와 같다면 유효한 것임.
                    this.Hide();                                        // 기존 form 숨김
                    Start start = new Start(ClientSocket, tokens[1]);          // strat form을 생성
                    start.Owner = this;                                 // 주체 설정.
                    start.Show();                                       // 보여줌
                }
                else
                {
                    label.Text = "아이디가 잘못되었습니다.";                                // 아이디 중복 메시지
                    userID.Text = "";                                   // userID -- TextBox 초기화
                }
            }
            else if (mode.Equals("general"))
            {
                if (str.Equals(id))                                                                             // 공백을 제거한 strID를 기존 id와 비교함.
                {                                                                                               // 만일 기존 id와 같다면 유효한 것임.
                    this.Hide();
                    GroupChattingRoom groupChattingRoom = new GroupChattingRoom(ClientSocket, tokens[1]);
                    groupChattingRoom.Owner = this;
                    groupChattingRoom.Show();
                }
                else
                {
                    label.Text = "아이디가 잘못되었습니다.";                // 아이디 중복 메시지
                    userID.Text = "";                                   // userID -- TextBox 초기화
                }
            } else  // 아예 아이디가 아닌거임.
            {
                label.Text = str;                // 아이디 중복 메시지
                userID.Text = "";
            }
        }

        private void userID_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientSocket.Close();
            Application.Exit();
        }
    }
}
