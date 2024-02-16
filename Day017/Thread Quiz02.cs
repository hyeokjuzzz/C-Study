using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadApp001
{
    internal class Program
    {
        static void Plus()
        {
            int count = 0;
            for(int i=1; i<=100; i++)
            {
                count += i;
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            }
            Console.WriteLine(count);
        }
        static void Alpha()
        {
            for(int i=(int)'A'; i <= (int)'Z'; i++)
            {

                Console.Write((char)i+" ");
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            }

        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Plus));
            t1.Name = "Thread1";
            Thread t2 = new Thread(new ThreadStart(Alpha));
            t2.Name = "Thread2";
            t1.Start();
            t1.Join();
            t2.Start();
            t2.Join();
            Console.WriteLine("Main 종료");
        }
    }
}
