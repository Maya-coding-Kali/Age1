using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Month1.Text = DateTime.Today.Month.ToString();
            Day1.Text = DateTime.Today.Day.ToString();
            Year1.Text = DateTime.Today.Year.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating Variables to 
            int By, Bm, Bd, Cy, Cm, Cd;
            int years, months, days;
            Bm = Convert.ToInt32(Month2.Text);
            By = Convert.ToInt32(Year2.Text);
            Bd = Convert.ToInt32(Day2.Text);

            Cm = Convert.ToInt32(Month1.Text);
            Cy = Convert.ToInt32(Year1.Text);
            Cd = Convert.ToInt32(Day1.Text);
         



            if (Cy <0 || Cy >2121)
            {
                MessageBox.Show("wrong Date, Try again");
                return;

            }
            if (By < 0 || By > 2021) 
            {
                MessageBox.Show("wrong Date, Try again");
                return;
            }
            if (Cm < 0 || Cm > 12 || Bm < 0 || Bm > 12)
            {
                MessageBox.Show("wrong Date, Try again");
                return;
            }
            if (Cd < 0 || Cd > 31 || Bd < 0 || Bd > 31)
            {
                MessageBox.Show("wrong Date, Try again");
                return;
            }
            years = Cy - By;
            months = Cm - Bm;
            days = Cd - Bd;

            if ( days < 0)
            {
                months = months - 1;
                days = days + 30;

            }
            if (months < 0)
            {
                years = years - 1;
                months = months + 12;


            }

            Result1.Text = " You are " + years.ToString() + " years and " + months.ToString() + " months and" + days.ToString() + " days";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Month2.Clear();
            Year2.Clear();
            Day2.Clear();
            Result1.Clear();
        }
    }
}
