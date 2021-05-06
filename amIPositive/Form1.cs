/*
 * Gurvir Uppal
 * may 5 2021 
 * Am I Positive?
 * Mr. T 
 * ICS3U
 * */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amIPositive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            int numb = Convert.ToInt32(inputBox.Text);

            if ( numb > 0 )
            {
                numberSignLabel.Text = $"{numb} is a positive number"; 
            }
            else if ( numb < 0)
            {
                numberSignLabel.Text = $"{numb} is a negative number";
            }

            else
            {
                numberSignLabel.Text = $"{numb} is the origin number";
            }

            if (numb % 7 ==0)                                               // if the number can be divided by 7 and have no remainder go into the statement below
            {
                divisbleLabel.Text = $"{numb} is divisble by 7";
            }
            else
            {
                divisbleLabel.Text = $"{numb} is not divisble by 7";
            }




        }
    }
}
