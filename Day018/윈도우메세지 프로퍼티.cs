윈도우 메시지 (메시지 프로퍼티)
-Hwnd : 메시지를 받는 윈도우의 핸들
	윈도우 객체를 식별하고 관리하기 위해 O/S가 붙이는 번호
-Msg : 메시지 ID
-LParam : 메시지를 처리하는 정보가 담겨있습니다.
-WParam : 부가정보(조이스틱, 키보드, 마우스 값)
-Result : 메시지 처리에 대한 응답으로 O/S에 반환되는 값을 지정합니다.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    class MessageFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x0f || m.Msg == 0xA0 || m.Msg == 0x200 || m.Msg == 0x13)
                return false;
            Console.WriteLine($"{m.ToString()} : {m.Msg}");

            if (m.Msg == 0x201)
                Application.Exit();

            return true;
        }
    }

    internal class MainApp : Form
    {
        static void Main(string[] args)
        {
            Application.AddMessageFilter(new MessageFilter());
            Application.Run(new MainApp());
        }
    }
}
