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

            for(int i= 0; i < 5; i++)
            {

                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write(" ");
                }
               for(int k = 0; k <=i; k++)
                    {
                        Console.Write("*");
                    }

                Console.WriteLine();
            }

            
            }
            


        }
    }
