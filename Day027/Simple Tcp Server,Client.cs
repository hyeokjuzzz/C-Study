using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTcpFileServer_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //인터넷주소만들고 포트만들기
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            int port = 13001;

               TcpListener server = new TcpListener(localAddr, port);
            server.Start();
            Console.WriteLine("서버시작....");

            //2.클라이언트아 접속할 소켓만들고클라이언트기다리기
            using (TcpClient client = server.AcceptTcpClient())
            {
                Console.WriteLine("연결 성공");


                //사진 전송

                using(NetworkStream stream = client.GetStream())
                {
                   byte[] data =  File.ReadAllBytes(@"./캡처.png");
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine("전송이 완료되었습니다");
                }


            }
            server.Stop();
        }
    }
}

-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTcpFileClient
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IPAddress serverAddr = IPAddress.Parse("127.0.0.1");

            int port1 = 13001;


            //클라이언트 소켓생성

            TcpClient client = new TcpClient();
            client.Connect(serverAddr, port1);//Accept
            Console.WriteLine("서버에 연결되었습니다");

            //주고받기 --> 사진받기
            string filePath = $"./newjeans.png";

            using (NetworkStream networkStream = client.GetStream())
            {
                byte[] data = new byte[1024];
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    int bytesRead;
                    while((bytesRead = networkStream.Read(data,0, data.Length)) > 0)
                    {
                        fs.Write(data, 0, bytesRead);
                    }
                }

            }
            Console.WriteLine($"파일 수신 완료: {filePath}");
            client.Close(); 

        }


    }
}
