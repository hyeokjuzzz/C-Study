
using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Net.Sockets;

using System.Net;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;



namespace WindowsFormsApp27

{

    public partial class Form1 : Form

    {

        public Form1()

        {

            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)

        {

            Dispose();

            //Environment.Exit(0 );

        }



        private async void Form1_Load(object sender, EventArgs e)

        {

            //인터넷 주소만들기 127.0.0.1은 localhost와 동치임

            IPAddress localAddr = IPAddress.Parse("127.0.0.1");

            //포트만들기

            int port = 13000;

            //서버만들기

            TcpListener server = new TcpListener(localAddr, port);

            //시작

            server.Start();

            //Console.WriteLine("연결을 기다리는 중...");

            richTextBox1.AppendText("연결을 기다리는 중...\n");

            while(true)

            {

                //클라이언트 연결 수락

                TcpClient client = await server.AcceptTcpClientAsync();

                Task task = Task.Run(() =>  HandleClient(client));

            }

        }//end of form load

        private async void HandleClient(TcpClient client)

        {

            // richTextBox1.AppendText("연결 성공\n");

            AppendText("연결 성공!\n");

            using (NetworkStream stream = client.GetStream())

            {

                byte[] data = new byte[256];

                int bytes;

                while ((bytes = await stream.ReadAsync(data, 0, data.Length))!=0)

                {

                    string s = Encoding.UTF8.GetString(data, 0, bytes); 

                    AppendText(s+'\n');

                   string a="", b="";

                    bool flag = true;

                    for(int i=0; i<s.Length; i++)

                    {

                        if (s[i] == '+')

                        {

                            flag = false;

                            continue;

                        }

                        if (flag == true)

                            a += s[i];

                        else

                        {

                            b+= s[i];

                        }  

                    }

                    label1.Text = int.Parse(a) + int.Parse(b) + "";

                   

                }

            }

            client.Close();

        }

        private void AppendText(string text)

        {

            if(richTextBox1.InvokeRequired)

            {

                richTextBox1.Invoke(new Action<string>(AppendText), text);

            }

            else

            {

                richTextBox1.AppendText(text);

            }

        }

    }

}
