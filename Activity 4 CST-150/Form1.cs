using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_4_CST_150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            /* First, we declare our variables. 
             * A double type can represent fractional as well as whole values. 
             * It can contain up to 15 digits in total, including those before and after the decimal point.
             * Because our program has a heavy reliance on division, it is wiser to use doubles rather than
             integers. We want to ensure we round our results properly to avoid needlessly long lines of numbers.*/
            double seconds; double minutes; double hours; double days; 
            /* This line will allow us to get our text from the txtSeconds textbox and convert that text into a double for our
             variable, seconds.*/
            seconds = double.Parse(txtSeconds.Text);
            // If the number of seconds the user inputs is less than or equal to 59, we output this string.
            if (seconds <= 59)
            {
                txtOutput.Text = Convert.ToString(seconds + " is less than 60 seconds.");
            }
            // If the number of seconds the user inputs is less than or equal to 60 and is less than 3600 seconds, we output this string.
            else if (seconds >= 60 && seconds < 3600)
            {
                minutes = seconds / 60.0;
                txtOutput.Text = Convert.ToString(seconds + " is " + (Math.Round(minutes, 2) + " minute(s)."));
            }
            // If the number of seconds the user inputs is less than or equal to 3600 and is less than 86400 seconds, we output this string.
            else if (seconds >= 3600 && seconds < 86400)
            {
                hours = seconds / 3600.0;
                txtOutput.Text = Convert.ToString(seconds + " is " + (Math.Round(hours, 2) + " hour(s)."));
            }
            // If the number of seconds the user inputs is less than or equal to 86400, we output this string.
            else if (seconds >= 86400)
            {
                days = seconds / 86400.0;
                txtOutput.Text = Convert.ToString(seconds + " is " + (Math.Round(days, 2) + " day(s)."));
            }
            }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // This will clear all of our text when btnClear is clicked. 
            txtSeconds.Text = "";
            txtOutput.Text = "";
            txtSeconds.Focus();
        }
    }
}
