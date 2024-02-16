using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator01
{
    //사칙연산을 하는계산기 만들기
     class Calculator
    {
        //메소드
        public int Plus(int x, int y)
        {
            return x + y;

        }
        public int Mius(int x, int y)
        {
            return x - y;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Calculator calculator = new Calculator();
            int result1 = calculator.Plus(1, 2);
            int result2 = calculator.Mius(1, 2);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
