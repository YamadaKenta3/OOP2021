using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0823
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Exec_Click(object sender, EventArgs e)
        {
            
            var n = int.Parse(Value.Text);
            var m = int.Parse(Jyou.Text);

            var result = n;
            
            for(int i = 1;i < m; i++)
            {
                result = result * n;

            }
            Result.Text = result.ToString();
            
        }
    }
}
