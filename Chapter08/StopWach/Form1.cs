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

            tm.Tick += Tm_Tick;
             tm.Start();
            
            tbTimer.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void Tm_Tick(object sender, EventArgs e)
        {
          //  DateTime d = DateTime;
        }
    }


}
