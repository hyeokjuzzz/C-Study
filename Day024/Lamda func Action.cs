using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 람다
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string> func1 = () => "안녕하세요";
            Console.WriteLine(func1());

            Func<double, double> func3 = (x) => x * 3.14;
            Console.WriteLine(func3(3));

            Func<int, int, int> func2 = (x, y) => x + y;
            Console.WriteLine(func2(1,2));

            Console.WriteLine();

            Action act1 = () => Console.WriteLine("ACT1");
            act1();

            int result = 0;
            Action<int> act2 = (x) => result = x * x;

            act2(3);
        }
    }
}
