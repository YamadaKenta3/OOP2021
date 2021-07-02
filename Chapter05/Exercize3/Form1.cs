using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercize3
{
    public partial class Form1 : Form
    {
       //コンストラクタ
        public Form1()
        {
            InitializeComponent();
        }
        //フォームがロードされるタイミングで一回だけ実行される
        private void Form1_Load(object sender, EventArgs e)
        {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";

        }

        private void button5_3_1_Click(object sender, EventArgs e)
        {

            string word = inputStrText.Text;

              var count = word.Count(c => c == ' ');

            TextBoxSpaceCount.Text = word.ToString();



        }

        private void button5_3_2_Click(object sender, EventArgs e)
        {

            string word = inputStrText.Text;

            word.Replace("big", "small");

            bigSmall.Text = word.ToString();
            

        }

        private void button5_3_3_Click(object sender, EventArgs e)
        {

            count.Text = inputStrText.Text.Split(' ').Length.ToString();

              

        }

        private void button5_3_4_Click(object sender, EventArgs e)
        {
            var word = inputStrText.Text.Split().Where(c =>  c.Length <= 4);


            foreach (var s in word)
            {
                mojiji.Text += s + ",";
            }
        }

        private void button5_3_5_Click(object sender, EventArgs e)
        {
           var word = inputStrText.Text.Split(' ').ToArray();
           
            var sb = new StringBuilder();

            foreach (var s in word)
            {
                sb.Append(s + " ");
            }
            

             rkt.Text +=  sb.ToString();
           
            
           
        }
        
    }
}
