using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayapp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            
            for(int i =0;  i<100; i++)
            {
                arr[i] = i + 1;
                Console.WriteLine(arr[i]);
            }
             

            for(int j  = 0; j < arr.Length; j++)
           {
                Console.Write(arr[j]);
            }
            
        }
    }
}
