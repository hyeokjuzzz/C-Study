using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace statementlambda
{
    internal class Program
    {
        static void threadFunc()
        {
            Console.WriteLine("5초후 종료");
            Thread.Sleep(5000);
            Console.WriteLine("스레드 종료");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(threadFunc));
            t.IsBackground = false;
            t.Start();
            Console.WriteLine("메인 스레드 종료");
        }
    }
}
