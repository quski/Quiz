using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizzapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            al.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            test t = new test();
            t.Show();
        }
    }
}
