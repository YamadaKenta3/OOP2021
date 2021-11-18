using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace NamberGame
{
   
    /// <summary> の相互作用ロジック
    /// </summary>
    /// MainWindow.xaml
    public partial class MainWindow : Window
    {
        int num;
        public MainWindow()
        {
            
            InitializeComponent();
            Random ram= new Random();
            num = ram.Next(1, 25);
          
        }

       



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var bnum = int.Parse(((Button)sender).Content.ToString());

            if(bnum == num)
            {
                tbnum.Text = "正解";

            }
            else if (bnum > num)
            {
                tbnum.Text = "もっと小さい数字です。";
            }
            else
            {
                tbnum.Text = "もっと大きい数字です。";
            }
           

        }
    }
}
