using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4줄구구단Win01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 2; i <= 9; i+=4)
            {
                for(int j = 1; j <=9; j++)
                {
                    for(int k = 0; k <= 3; k++)
                    {
                        textBox1.Text += (i + k).ToString() + " X " + j.ToString() + "=";
                        textBox1.Text += ((i + k) * j).ToString() + "        ";
                    }
                    textBox1.Text += "\r\n";
                }
                textBox1.Text += "\r\n";
            }
        }
    }
}
