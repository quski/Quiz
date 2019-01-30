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
    public partial class setexam : Form
    {
        public setexam()
        {
            InitializeComponent();
        }

        private void setexam_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'quizappDataSet2.student_record' . Możesz go przenieść lub usunąć.
            this.student_recordTableAdapter.Fill(this.quizappDataSet2.student_record);
            string q = "select * from student_record ";
            viewclass vc = new viewclass(q);
            dataGridView1.DataSource = vc.showrecord();
            q = "select distinct std_batchcode from student_record";
            viewclass vc2 = new viewclass(q);
            comboBox1.DataSource = vc.showrecord();
           

        }
    }
}
