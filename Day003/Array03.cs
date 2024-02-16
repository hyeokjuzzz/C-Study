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
            int[] arr = new int[5];
            int j = 1;

            //메모리에 입력
            for (int i = 0,cnt= 1; i < 5; i++, cnt+=2)
            {
                arr[i] = cnt;
                
                
            }
            //화면(콘솔에)출력
            for(int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }
          

            
        }
    }
}
