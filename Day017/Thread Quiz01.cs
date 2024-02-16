using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadApp001
{
    internal class Program
    {
        static void Print()
        {
            for(int i=1; i<=100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("스레드 프로그램 종료");
        }
        static void Main(string[] args)
        {
            //Thread를 이용해서 1~100 출력하는 프로그램 작성!!!
            Thread t = new Thread(new ThreadStart(Print));
            t.Start();
            t.Join();  // 메인 프로그램이 먼저 끝나는 것을 방지함
            Console.WriteLine("Main 프로그램 종료");
            

        }
    }
}
