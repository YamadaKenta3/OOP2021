﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssReader
{
    public partial class Form2 : Form
    {
       


        public Form2()
        {
           

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            

        }

        private void wbBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            btBack.Enabled = webBrowser1.CanGoBack;

            btDingm.Enabled = webBrowser1.CanGoForward;

        }

        private void btDingm_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
    }
}
