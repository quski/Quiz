namespace quizzapp
{
    partial class setexam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.studentrecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizappDataSet2 = new quizzapp.quizappDataSet2();
            this.student_recordTableAdapter = new quizzapp.quizappDataSet2TableAdapters.student_recordTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentrecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizappDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kod";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.studentrecordBindingSource;
            this.comboBox1.DisplayMember = "std_batchcode";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "std_batchcode";
            // 
            // studentrecordBindingSource
            // 
            this.studentrecordBindingSource.DataMember = "student_record";
            this.studentrecordBindingSource.DataSource = this.quizappDataSet2;
            // 
            // quizappDataSet2
            // 
            this.quizappDataSet2.DataSetName = "quizappDataSet2";
            this.quizappDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_recordTableAdapter
            // 
            this.student_recordTableAdapter.ClearBeforeFill = true;
            // 
            // setexam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "setexam";
            this.Text = "setexam";
            this.Load += new System.EventHandler(this.setexam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentrecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizappDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private quizappDataSet2 quizappDataSet2;
        private System.Windows.Forms.BindingSource studentrecordBindingSource;
        private quizappDataSet2TableAdapters.student_recordTableAdapter student_recordTableAdapter;
    }
}