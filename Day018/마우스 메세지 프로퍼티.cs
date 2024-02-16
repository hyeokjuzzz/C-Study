마우스 메시지 (마우스 프로퍼티)
-Button : 마우스의 방향 (왼쪽, 오른쪽, 위, 아래)를 나타냄
-Clicks : 마우스 버튼의 클릭한 횟수를 나타냄
-Delta : 휠의 회전방향과 회전한 거리
-X : x 좌표
-Y : y 좌표



using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEventApp
{
    internal class MainApp : Form
    {
        public void MyMouseHandler(object sender, MouseEventArgs e)
        {
            Console.WriteLine($"Sender : {((Form)sender).Text}");
            Console.WriteLine($"X : {e.X} Y : {e.Y}");
            Console.WriteLine($"Button : {e.Button} {e.Clicks}");
            Console.WriteLine();
        }
        public MainApp(string title)
        {
            this.Text = title;
            this.MouseClick += new MouseEventHandler(MyMouseHandler);

        }
        static void Main(string[] args)
        {
            Application.Run(new MainApp("마우스 이벤트 테스트"));
        }
    }
}
