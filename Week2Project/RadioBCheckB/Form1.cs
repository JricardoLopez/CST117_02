using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioBCheckB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateLabel1(object sender, EventArgs e)
        {
            
                if (checkBox1.Checked)
            { 
                    label1.Text = "Item Checked";
          
            }
            else
            {
                label1.Text = "Item Un-Checked";
            }
        }

        private void changecolorbutton1_Click(object sender, EventArgs e)
        {
            if (redradioButton1.Checked)
            {
                panel1.BackColor = Color.Red;
            }
            else if (greenradioButton2.Checked)
            {
                panel1.BackColor = Color.Green;
            }
            else if (blueradioButton3.Checked)
            {
                panel1.BackColor = Color.Blue;
            }
            {

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label2.Text = "Item Checked";

            }
            else
            {
                label2.Text = "Item Un-Checked";
            }
        }
    }
}
