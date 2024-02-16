using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 번개이벤트
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach (FontFamily font in Fonts)
                cboFont.Items.Add(font.Name);
        }

        void ChangeFont()
        {
            if (cboFont.SelectedIndex < 0)
                return;

            FontStyle style = FontStyle.Regular;

            if(chkBold.Checked)
                style |= FontStyle.Bold;

            if(chkitalic.Checked)
                style |= FontStyle.Italic;

            txtSampleText.Font = new Font((string)cboFont.SelectedItem, 10, style);
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void cboFont_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkitalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
    }
}
