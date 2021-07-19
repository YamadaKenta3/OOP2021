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

namespace Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                using (var reader = new StreamReader(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis")))
                {

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        tbOutput.Text += line + "\r\n";
                    }

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
