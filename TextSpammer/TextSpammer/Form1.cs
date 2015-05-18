using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TextSpammer
{
    public partial class Form1 : Form
    {
        //this is the most important bit for the anti bot thing.
        bool test;
        bool btnSec;
        int Delay;

        public Form1()
        {
            InitializeComponent();
            //I though that it was anyoing when the timer stared blank and everything crashed.
            textBox2.Text = "1";
        }
        
        //Start Button(Enables the spammer)
        private void button1_Click(object sender, EventArgs e)
        {
            Spammer.Enabled = true;
        }

        //Stop button(Disables the spammer)
        private void button2_Click(object sender, EventArgs e)
        {
            Spammer.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            test = true;
            btnSec = true;
        }

        private void Spammer_Tick(object sender, EventArgs e)
        {
            //Gets a custom number for the delay
            Delay = Convert.ToInt32(textBox2.Text);

            //This loop does the same thing as the bit below, but it adds a space at the end.
            //I did this so that anti spam bots don't notice too easily.
            while (test)
            {
                SendKeys.Send(textBox1.Text + " Worked");
                SendKeys.Send("{ENTER}");
                test = false;
            }

            //Takes the text in text pox and sends the text to whatever you are using.
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{ENTER}");

            //If the user presed the other button this will make it work.
            if (btnSec)
            {
                test = true;
            }

            //The delay
            Thread.Sleep(Delay * 1000);
        }
    }
}
