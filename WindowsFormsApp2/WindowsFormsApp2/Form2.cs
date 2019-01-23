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
    public partial class Form2 : Form
    {   
        

        public Form2()
        {
            
            InitializeComponent();
        }

        private void btncbtnCheck_Click(object sender, EventArgs e)
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
                MessageBox.Show("Zdobyłeś: 1 Punkt");
                Form3 f3 = new Form3();
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
                lblMyTime.Text = "time out"; }
        }

        private void lblM_Click(object sender, EventArgs e)
        {

        }

        private void gbxQu1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        
    }    }
