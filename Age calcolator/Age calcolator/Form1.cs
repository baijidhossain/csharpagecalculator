using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Age_calcolator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

         



             toyear_textBox.Text = DateTime.Now.Year.ToString();
            tomonth_textBox.Text = DateTime.Now.Month.ToString();
            today_textBox.Text = DateTime.Now.Day.ToString();
        }

        private void Calcolate_Click(object sender, EventArgs e)
        {
            int d, m, y, d2, d22, d222,d333;
            int totalhour, totalminute, totalsecond;
            int today, tomonth, toyear;
            int birthday, birthmonth, birthyear;
            int resultday, resultmonth, resultyear;
            //today
            today = Convert.ToInt32(today_textBox.Text);
            tomonth = Convert.ToInt32(tomonth_textBox.Text);
            toyear = Convert.ToInt32(toyear_textBox.Text);
            //birthday
            birthday = Convert.ToInt32(birthday_textBox.Text);
            birthmonth = Convert.ToInt32(birthmonth_textBox.Text);
            birthyear = Convert.ToInt32(birthyear_textBox.Text);


            if (birthday > 29)
            {


                if (birthmonth == 2)
                {
                    if (birthyear % 4 == 0)
                    {
                        birthday = 00;
                        birthmonth = 00;
                        birthyear = 00;
                        today = 00;
                        tomonth = 00;
                        toyear = 00;


                        Day.Text = " Day: 00";
                        month.Text = " Month: 00";
                        Year.Text = "Year: 00";

                        Total_day.Text = " Total day: 00";
                        Total_hour.Text = " Total hour: 00";
                        Total_minute.Text = "Total minute: 00";
                        total_second.Text = " Total second: 00";
                        MessageBox.Show("Fabroary < 30 Day","Pleases",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        birthday_textBox.Focus();


                    }
                }
            }



            if (birthday > 28)
            {

                if (birthmonth == 2)
                {
                    if (birthyear % 4 == 1)
                    {
                        birthday = 00;
                        birthmonth = 00;
                        birthyear = 00;
                        today = 00;
                        tomonth = 00;
                        toyear = 00;


                        Day.Text = " Day: 00";
                        month.Text = " Month: 00";
                        Year.Text = "Year: 00";

                        Total_day.Text = " Total day: 00";
                        Total_hour.Text = " Total hour: 00";
                        Total_minute.Text = "Total minute: 00";
                        total_second.Text = " Total second: 00";
                        MessageBox.Show("Fabroary < 29 Day", "Pleases", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        birthday_textBox.Focus();

                    }
                }

            }
            else
            {
                if (today < birthday && tomonth > birthmonth)
                {
                    resultday = (today + 30) - birthday;
                    Day.Text = "Daye " + resultday.ToString();

                    resultmonth = tomonth - (birthmonth + 1);
                    month.Text = "Month" + resultmonth.ToString();


                    resultyear = toyear - birthyear;
                    Year.Text = "Year" + resultyear.ToString();

                    d = resultday;
                    m = resultmonth;
                    y = resultyear;
                    d2 = y * 365;
                    d22 = m * 30;
                    d222 = d2 + d22;
                    Total_day.Text = "Total day " + d222.ToString();
                    totalhour = d222 * 24;
                    Total_hour.Text = "Total hour " + totalhour.ToString();
                    totalminute = totalhour * 60;
                    Total_minute.Text = "Total minute " + totalminute.ToString();
                    totalsecond = totalminute * 60;
                    total_second.Text = "Total second " + totalsecond.ToString();


                }


                else if (tomonth < birthmonth && today > birthday)
                {
                    resultday = today - birthday;

                    Day.Text = "Daye " + resultday.ToString();

                    resultmonth = (tomonth + 12) - birthmonth;

                    month.Text = "Month" + resultmonth.ToString();

                    resultyear = toyear - (birthyear + 1);

                    Year.Text = "Year" + resultyear.ToString();

                    d = resultday;
                    m = resultmonth;
                    y = resultyear;
                    d2 = y * 365;
                    d22 = m * 30;
                    d222 = d2 + d22;
                    Total_day.Text = "Total day " + d222.ToString();
                    totalhour = d222 * 24;
                    Total_hour.Text = "Total hour " + totalhour.ToString();
                    totalminute = totalhour * 60;
                    Total_minute.Text = "Total minute " + totalminute.ToString();
                    totalsecond = totalminute * 60;
                    total_second.Text = "Total second " + totalsecond.ToString();

                }


                else if (today < birthday && tomonth < birthmonth)
                {

                    resultday = (today + 30) - birthday;
                    Day.Text = "Daye " + resultday.ToString();

                    resultmonth = (tomonth + 12) - (birthmonth + 1);

                    month.Text = "Month" + resultmonth.ToString();

                    resultyear = toyear - (birthyear + 1);

                    Year.Text = "Year" + resultyear.ToString();

                    d = resultday;
                    m = resultmonth;
                    y = resultyear;
                    d2 = y * 365;
                    d22 = m * 30;
                    d222 = d2 + d22;
                    Total_day.Text = "Total day " + d222.ToString();
                    totalhour = d222 * 24;
                    Total_hour.Text = "Total hour " + totalhour.ToString();
                    totalminute = totalhour * 60;
                    Total_minute.Text = "Total minute " + totalminute.ToString();
                    totalsecond = totalminute * 60;
                    total_second.Text = "Total second " + totalsecond.ToString();

                }


                else
                {
                    resultday = today - birthday;
                    Day.Text = "Daye " + resultday.ToString();
                    resultmonth = tomonth - birthmonth;

                    month.Text = "Month" + resultmonth.ToString();
                    resultyear = toyear - birthyear;

                    Year.Text = "Year" + resultyear.ToString();


                        d = resultday;
                        m = resultmonth;
                        y = resultyear;

                        total_year.Text = "Total year "+resultyear.ToString();
                        int totalmonth = resultyear * 12 + resultmonth;
                        total_month.Text="Total month "+totalmonth.ToString();
                        d2 = (y * 364)+resultday+(resultmonth*30);
                        d333 = d2 / 7;
                        Total_wek.Text="Total wek"+d333.ToString();
                        Total_day.Text = "Total day " + d2.ToString();
                        totalhour = d2 * 24;
                        Total_hour.Text = "Total hour " + totalhour.ToString();
                        totalminute = totalhour * 60;
                        Total_minute.Text = "Total minute " + totalminute.ToString();
                        totalsecond = totalminute * 60;
                        total_second.Text = "Total second " + totalsecond.ToString();


                    
            

                }
            }          
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            toyear_textBox.Text = DateTime.Now.Year.ToString();
            tomonth_textBox.Text = DateTime.Now.Month.ToString();
            today_textBox.Text = DateTime.Now.Day.ToString();
       
            birthday_textBox.Text = "00";
            birthmonth_textBox.Text = "00";
            birthyear_textBox.Text = "00";
            Day.Text = " Day: 00";
            month.Text = " Month: 00";
            Year.Text = "Year: 00";
            Total_day.Text = " Total day: 00";
            Total_hour.Text = " Total hour: 00";
            Total_minute.Text = "Total minute: 00";
            total_second.Text = " Total second: 00";
        }
        int b = 1;
        private void birthmonth_textBox_TextChanged(object sender, EventArgs e)
        {
          
         }
        }
    }
  

