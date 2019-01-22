using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2Tryparse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void secondsTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void processbutton1_Click(object sender, EventArgs e)
        {
            int seconds;

            if (int.TryParse(secondsTextBox1.Text, out seconds))
            {
                // here we are doing the minutes

            if (seconds >=60 && seconds < 3600)
                {
                    int minutes = seconds / 60;

                    if ( minutes == 1)
                    {
                        outputlabel1.Text = seconds.ToString() + " Seconds is equivalent " + minutes.ToString() + "  minute. ";
                    }

                    else
                    {
                        outputlabel1.Text = seconds.ToString() + " Seconds is equivalent " + minutes.ToString() + "  minute. ";
                    }
                }
            // converting to hours 

            else if ( seconds >=3600 && seconds < 86400)

                {
                    int hours = seconds / 3600;

                    if ( hours == 1)
                    {
                        outputlabel1.Text = seconds.ToString() + " Seconds is equivalent " + hours.ToString() + "  hours. ";
                    }

                    else
                    {
                        outputlabel1.Text = seconds.ToString() + " Seconds is equivalent " + hours.ToString() + "  hours. ";
                    }
                }

            // converting to days

            else if (seconds >= 86400)
                {
                    int days = seconds / 86400;

                    if ( days == 1)
                    {
                        outputlabel1.Text = seconds.ToString() + " Seconds is equivalent " + days.ToString() + "  hours. ";
                    }
                    else
                    {
                        outputlabel1.Text = seconds.ToString() + " Seconds is equivalent " + days.ToString() + "  hours. ";
                    }
                }
   // if inputs are less that 60 seconds

            else
                {
                    MessageBox.Show(" Ricardo Say; Please enter a number bigger that 59");
                }
            }
            else
            {
                MessageBox.Show(" Ricardo say: Enter only a valid integer Number");
            }
        }
    }
}
