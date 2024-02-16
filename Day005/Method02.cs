using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MeThod1
{
    internal class Program

    {
        double Avg(int kor,int eng, int math)
        {
            int total = kor + eng + math;
            return (double)total / 3.0;
        }
        static void Main(string[] args)
        {
            // int kor= int.Parse(Console.ReadLine());
            // int eng =int.Parse(Console.ReadLine());
            //int math =int.Parse(Console.ReadLine());

            // Program a = new Program();
            // Console.WriteLine(a.Avg(kor, eng, math));
            int[] score = new int[3];
            for(int i = 0; i<3; i++)
            {
                score[i] = int.Parse(Console.ReadLine());
            }
            Program a = new Program();
            double result = a.Avg(score[0], score[1], score[2]);
            Console.WriteLine(result);

        }
    }
}
