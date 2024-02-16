using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void DoSomething()
        {
            for(int i = 0; i < 1000; i++)
            {

            }
            Console.WriteLine($"DoSomething Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        }

        static void Print()
        {
            Console.WriteLine($"Print Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            Print();
            Thread t = new Thread(new ThreadStart(DoSomething));
            t.Start();
        }
    }
}
