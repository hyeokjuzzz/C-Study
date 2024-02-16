using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lestgoStar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 5; i >0; i--)
            {
                    
                    for(int j = i; j>0; j--)
                {
                    Console.Write("*");
                }
                    Console.WriteLine();
                    
            }
        }
    }
}
