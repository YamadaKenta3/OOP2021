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

namespace Exercise2
{
    public partial class Form1 : Form
    {

        private string inputPath = ""; //変換元ファイル(読み込むファイル)
        private string outputPath = ""; //変換先ファイル
        public Form1()
        {
            InitializeComponent();
        }

        

        


        
        //変換元のファイルを指定
        private void button1_Click(object sender, EventArgs e)
        {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                inputPath = ofdOpenFile.FileName;




            }
        }
        //変換したファイルの保存先を指定
        private void btTrance_Click(object sender, EventArgs e)
        {
            if (sfdSaveFile.ShowDialog() == DialogResult.OK)
            {
                outputPath = sfdSaveFile.FileName;


            }
        }

        //行番号を追加する処理
        private void btChange_Click(object sender, EventArgs e)
        {
            var lines = File.ReadLines(inputPath).Select((s, n) => string.Format("{0,4}: {1}", n + 1, s)).ToArray();

            File.WriteAllLines(outputPath,lines);

        }

        private void btGyou_Click(object sender, EventArgs e)
        {

        }
    }


}
