using System;

using System.Collections.Generic;

using System.Globalization;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace 성적

{

    class Avg

    {

        public int kor { get; set; }

        public int eng { get; set; }

        public int math { get; set; }



        public int executeTotalScore()

        {

            return kor + eng + math;

        }

        public int excuteAvg()

        {

            return (kor + math + eng)/3;

        }

    }

    internal class Program

    {

        static void Main(string[] args)

        {

            Avg avg = new Avg();

            Console.WriteLine("국어:");

            avg.kor = int.Parse(Console.ReadLine());

            Console.WriteLine("영어:");

            avg.eng = int.Parse(Console.ReadLine());

            Console.WriteLine("수학:");

            avg.math = int.Parse(Console.ReadLine());



            Console.WriteLine($"총점:{avg.executeTotalScore()}");

            Console.WriteLine($"평균:{avg.excuteAvg()}");





        }

    }

}
