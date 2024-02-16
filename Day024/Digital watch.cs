using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 디지털시계
{
    public partial class Form1 : Form
    {
        private DateTime NowTime;
        void GetTime()
        {
            NowTime = DateTime.Now;
        }

        void OutTime()
        {
            label1.Text = NowTime.ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    GetTime();
                    this.Invoke(new Action(() =>
                    {
                        OutTime();
                    }));
                    Thread.Sleep(1000);
                }
            });
        }
    }
}
