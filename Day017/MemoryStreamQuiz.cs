using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Streamquiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream();
            byte[] arrbytes = new byte[] { 1, 2, 3, 4, 5 };
            ms.Write(arrbytes, 0, arrbytes.Length);

            ms.Position = 0;

            byte[] buffer = new byte[5];
            ms.Read(buffer, 0, buffer.Length);

            foreach(byte b in buffer)
            {
                Console.Write(b+" ");
            }

        }
    }
}
