using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 스톱워치Win01
{
    public partial class btn_start : Form
    {
        private TimeSpan time;

        public btn_start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btn_start_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = time.ToString("mm' : 'ss");
            time = time.Add(TimeSpan.FromSeconds(0.5));
        }
    }
}
