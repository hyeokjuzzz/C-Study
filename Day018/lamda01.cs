using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaApp001
{
    delegate int Calculate(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            //delegate 방식
            Calculate calc = (int a, int b) => a + b;
            calc = (int a, int b) => a - b;
            Console.WriteLine(calc(100,200));
            //Func 방식
            Func<int, int, int> add = (a, b) => a + b;
            int sum = add(100, 200);
            Console.WriteLine("Func = " + sum);
        }
    }
}
