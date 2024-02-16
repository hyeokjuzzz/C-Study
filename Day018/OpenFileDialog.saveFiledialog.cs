using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private string sourceFile;
        private string destFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSrcFile_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    sourceFile = openFileDialog.FileName;
                    lblSrcPath.Text = sourceFile;
                }
            }
        }

        private void btnDstFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    destFile = saveFileDialog.FileName;
                    File.Copy(sourceFile, destFile,true);
                    lblDstPath.Text = "복사 완료!!" + destFile;
                }
            }
        }
    }
}
