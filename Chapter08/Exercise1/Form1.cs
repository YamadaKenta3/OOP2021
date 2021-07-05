using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e)
        {

            /*
            //var today = DateTime.Today;
            var today = new DateTime((int)nudYear.Value,(int)nudMonth.Value,(int)nudDay.Value);
            DayOfWeek dayOfWeek = today.DayOfWeek;
            string dow = "";
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    dow = "日曜日";
                    break;
                case DayOfWeek.Monday:
                    dow = "月曜日";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火曜日";
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水曜日";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木曜日";
                    break;
                case DayOfWeek.Friday:
                    dow = "金曜日";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土曜日";
                    break;
                default:
                    break;
            }
            //Output.Text = dow + "です";

            var isLeapYear = DateTime.IsLeapYear((int)nudYear.Value);
            if (isLeapYear)
                tbLeapYear.Text = "閏年です";
            else
                tbLeapYear.Text = "閏年でない";

            /*
            var dt1 = new DateTime(1998, 1, 2, 15, 0, 0);
            var dt2 = DateTime.Now;
            TimeSpan diff = dt2.Date - dt1.Date;
            
            tbOutput.Text =  diff.Days.ToString() ;
            //utput.Text = DateTime.Today.DayOfYear.ToString();
            */

            /*
            var birthday = new DateTime(1998, 1, 2);
            var day = DateTime.Today;
            var age = GetAge(birthday, day);
            birthDay.Text = age.ToString() + "歳";
            */

            var today = DateTime.Today;
            tbOutput.Text = GetAge(dtp.Value, today).ToString();
        
        }

        public  int GetAge(DateTime birthday , DateTime targetDay)
        {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age))
            {
                age--;
            }
            return age;
        }

        
    }
}
