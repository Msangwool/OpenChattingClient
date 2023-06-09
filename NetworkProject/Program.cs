using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net;       ////이 이하 3가지는 네트워크 소켓 쓰레딩을 하기 위해서 선언해줍니다.
using System.Net.Sockets;
using System.Threading;

namespace NetworkProject
{
    internal static class Program
    {
        // 해당 애플리케이션의 주 진입점입니다.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}

