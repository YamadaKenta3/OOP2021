using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWach
{
    public partial class Form1 : Form
    {

      Stopwatch sw = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

      
        //スタートボタン
        private void stButton_Click(object sender, EventArgs e)
        {
            tm.Start();
            sw.Start();

        }

        //ラップボタン
        private void rap_Click(object sender, EventArgs e)
        {

                LB.Items.Insert(0, label.Text);
          

          
        }

        //ストップボタン
        private void St_Click(object sender, EventArgs e)
        {
            tm.Stop();
            sw.Stop();
         

        }

        private void tm_Tick_1(object sender, EventArgs e)
        {
            sw.Start();
            label.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");


        }
        //リセットボタン
        private void rtButton_Click(object sender, EventArgs e)
        {
            sw.Reset();


            label.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }
    }


}
