using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 람다연습문제
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 11, 22, 33, 44, 55 };
            //foreach(int a in arr)
            //{
            //    Action action = new Action
            //        (
            //        delegate ()
            //        {
            //            Console.WriteLine(a * a);
            //        });
            //    action.Invoke();
            //}

            foreach(int a in arr)
            {
                Action<int> act = (x) =>
                {
                    int result = x * x;
                    Console.WriteLine(result);
                };
                act(a);
            }
        }
    }
}
