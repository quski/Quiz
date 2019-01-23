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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void opt4_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (opt4.Checked)
                MessageBox.Show("Poprawna odpowiedź");
            else
                MessageBox.Show("Zła odpowiedź");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (opt4.Checked)
            {
                MessageBox.Show("Zdobyłeś: 2 punkty");
                Form4 f3 = new Form4();
                f3.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Błędna odpowiedź Przegrałeś!!");
                Form1 f3 = new Form1();
                f3.Show();
                this.Hide();
            }
        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            if (opt4.Checked)
                MessageBox.Show("Poprawna odpowiedź");
            else
                MessageBox.Show("Zła odpowiedź");
        }
        
     

        private void gbxQu1_Enter(object sender, EventArgs e)
        {

        }

        int timeleft = 30;

        public int Score { get; private set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                btnCheck.Visible = false;
                btnCheck.Enabled = false;
                timeleft = timeleft - 1;
                lblMyTime.Text = timeleft + "sekund";
            }
            else
            {
                btnCheck.Visible = true;
                btnCheck.Enabled = true;
                btnNext.Enabled = false;
                lblMyTime.Text = "time out";
            }
        }
    }
}
