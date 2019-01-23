using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Form2 f3 = new Form2();
            f3.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int timeleft = 30;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                lblMyTime.Text = timeleft + "secounds";
            }
           else
            { lblMyTime.Text = "time out"; }
        }

        private void lblMyTime_Click(object sender, EventArgs e)
        {

        }
    }
}
