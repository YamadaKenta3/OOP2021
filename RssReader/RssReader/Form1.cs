using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace RssReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void btRead_Click(object sender, EventArgs e)
        {

            setRssTitle(tbUrl.Text);


        }

        Form2 form2 = new Form2();

        List<string> link = new List<string>();
        List<string> description = new List<string>();
        List<string> pubdate = new List<string>();

        private void setRssTitle(string uri)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                
                var stream = wc.OpenRead(uri);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("item");
                foreach (var node in nodes)
                {
                    lbTitles.Items.Add(node.Element("title").Value );
                    link.Add(node.Element("link").Value);
                    description.Add(node.Element("description").Value);
                    pubdate.Add(node.Element("pubDate").Value);
                                       
                }
   
            }
        }

        private void lbTitles_Click(object sender, EventArgs e)
        {
            var num = lbTitles.SelectedIndex;

            lbdescription.Text = (description[num]);
            lbPubDate.Text = (pubdate[num]);

        }

        private void btForm2_Click(object sender, EventArgs e)
        {
            var num = lbTitles.SelectedIndex;

            form2.Show();

            form2.webBrowser1.Url = new Uri(link[num]);


        }

        private void tbUrl_TextChanged(object sender, EventArgs e)
        {

        }
    }
       
}


