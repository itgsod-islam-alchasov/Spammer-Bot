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
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void Spammer_Tick(object sender, EventArgs e)
        {
            //Gets a custom number for the delay
            int anInteger;
            anInteger = Convert.ToInt32(textBox2.Text);

            //Takes the text in text pox and sends the text to whatever you are using.
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{ENTER}");

            //The delay
            Thread.Sleep(anInteger * 1000);
        }

    }
}
