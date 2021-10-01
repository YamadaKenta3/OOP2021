using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail
{
    public partial class ConfigForm : Form
    {
         Form1 f1;
        private  Settings settings =  Settings.getInstance();

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, EventArgs e)
        {
           

            tbHost.Text = settings.sHost();
            tbUserName.Text = settings.sMailAddr();
            tbPort.Text = settings.sPost();
            tbPass.Text = settings.sPass();
            cbSsl.Checked = settings.bSsl();
           

            


        }
        private void ConfigForm_Load(object sender, EventArgs e)
        {
            f1 = new Form1();
        }
        private void btOk_Click(object sender, EventArgs e)
        {


            SettingsRegist();
           // f1.tbTo.Text = tbUserName.Text;
            //f1.ShowDialog();
            this.Close();
        }

        private void SettingsRegist()
        {
            Settings.Host = tbHost.Text;
            Settings.Port = int.Parse(tbPort.Text);
            Settings.MailAddr = tbUserName.Text;
            Settings.Pass = tbPass.Text;
            Settings.Ssl = cbSsl.Checked;
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            SettingsRegist();


        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
