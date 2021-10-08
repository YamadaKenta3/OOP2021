using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail
{

    public partial class ConfigForm : Form
    {
         
        private Settings settings =  Settings.getInstance();

        XmlDocument doc = new XmlDocument();



        public ConfigForm()
        {
            InitializeComponent();
        
        
        }
        
        
        private void btOk_Click(object sender, EventArgs e)
        {

            btApply_Click(sender, e);//適用ボタンの処理を呼び出し
            this.Close();

        }



        private void btApply_Click(object sender, EventArgs e)
        {
            //  Apply();
            //セッティングイブジェクトに入力データを渡して登録を行う
            settings.setSendConfig(tbHost.Text, int.Parse(tbPort.Text),
                                          tbUserName.Text, tbPass.Text, cbSsl.Checked);

        }



        private Settings Setreturn()
        {
            return settings;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btDefault_Click(object sender, EventArgs e)
        {

           
            tbHost.Text = settings.sHost();
            tbUserName.Text = settings.sMailAddr();
            tbPort.Text = settings.sPort();
            tbPass.Text = settings.sPass();
            cbSsl.Checked = settings.sSsl();
            tbSender.Text = settings.sMailAddr();



        }

        //設定画面をロードすると一度だけ実行されるイベントハンドラ
        private void ConfigForm_Load(object sender, EventArgs e)
        {
            tbHost.Text = settings.Host;
            tbPort.Text = settings.Port.ToString();
            tbPass.Text = settings.Pass;
            tbUserName.Text = settings.MailAddr;
            cbSsl.Checked = settings.Ssl;
            tbSender.Text = settings.MailAddr;
        }
    }
}