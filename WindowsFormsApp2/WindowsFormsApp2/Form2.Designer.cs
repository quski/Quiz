using System;

namespace WindowsFormsApp2
{
    partial class Form2
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
            this.gbxQu1 = new System.Windows.Forms.GroupBox();
            this.opt4 = new System.Windows.Forms.RadioButton();
            this.opt3 = new System.Windows.Forms.RadioButton();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.timele = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMyTime = new System.Windows.Forms.Label();
            this.punkty = new System.Windows.Forms.Label();
            this.gbxQu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxQu1
            // 
            this.gbxQu1.Controls.Add(this.opt4);
            this.gbxQu1.Controls.Add(this.opt3);
            this.gbxQu1.Controls.Add(this.opt2);
            this.gbxQu1.Controls.Add(this.opt1);
            this.gbxQu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbxQu1.Location = new System.Drawing.Point(182, 55);
            this.gbxQu1.Name = "gbxQu1";
            this.gbxQu1.Size = new System.Drawing.Size(440, 214);
            this.gbxQu1.TabIndex = 3;
            this.gbxQu1.TabStop = false;
            this.gbxQu1.Text = "Które z miast jest stolicą Polski ?";
            this.gbxQu1.Enter += new System.EventHandler(this.gbxQu1_Enter_1);
            // 
            // opt4
            // 
            this.opt4.AutoSize = true;
            this.opt4.Location = new System.Drawing.Point(17, 173);
            this.opt4.Name = "opt4";
            this.opt4.Size = new System.Drawing.Size(123, 29);
            this.opt4.TabIndex = 3;
            this.opt4.TabStop = true;
            this.opt4.Text = "Warszawa";
            this.opt4.UseVisualStyleBackColor = true;
            // 
            // opt3
            // 
            this.opt3.AutoSize = true;
            this.opt3.Location = new System.Drawing.Point(17, 122);
            this.opt3.Name = "opt3";
            this.opt3.Size = new System.Drawing.Size(96, 29);
            this.opt3.TabIndex = 2;
            this.opt3.TabStop = true;
            this.opt3.Text = "Kraków";
            this.opt3.UseVisualStyleBackColor = true;
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.Location = new System.Drawing.Point(17, 76);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(97, 29);
            this.opt2.TabIndex = 1;
            this.opt2.TabStop = true;
            this.opt2.Text = "Poznań";
            this.opt2.UseVisualStyleBackColor = true;
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.Location = new System.Drawing.Point(17, 29);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(106, 29);
            this.opt1.TabIndex = 0;
            this.opt1.TabStop = true;
            this.opt1.Text = "Wrocław";
            this.opt1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNext.Location = new System.Drawing.Point(505, 350);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(117, 45);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Następne";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCheck.Location = new System.Drawing.Point(178, 330);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(117, 45);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Sprawdź";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btncbtnCheck_Click);
            // 
            // timele
            // 
            this.timele.Location = new System.Drawing.Point(0, 0);
            this.timele.Name = "timele";
            this.timele.Size = new System.Drawing.Size(100, 23);
            this.timele.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMyTime
            // 
            this.lblMyTime.AutoSize = true;
            this.lblMyTime.BackColor = System.Drawing.SystemColors.Info;
            this.lblMyTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMyTime.Location = new System.Drawing.Point(628, 74);
            this.lblMyTime.Name = "lblMyTime";
            this.lblMyTime.Size = new System.Drawing.Size(103, 25);
            this.lblMyTime.TabIndex = 6;
            this.lblMyTime.Text = "30 sekund";
            // 
            // punkty
            // 
            this.punkty.AutoSize = true;
            this.punkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.punkty.Location = new System.Drawing.Point(633, 131);
            this.punkty.Name = "punkty";
            this.punkty.Size = new System.Drawing.Size(94, 25);
            this.punkty.TabIndex = 7;
            this.punkty.Text = "Punkty: 0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.punkty);
            this.Controls.Add(this.lblMyTime);
            this.Controls.Add(this.timele);
            this.Controls.Add(this.gbxQu1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCheck);
            this.Name = "Form2";
            this.Text = "Form2";
            this.gbxQu1.ResumeLayout(false);
            this.gbxQu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion

        private System.Windows.Forms.GroupBox gbxQu1;
        private System.Windows.Forms.RadioButton opt4;
        private System.Windows.Forms.RadioButton opt3;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label timele;
        private System.Windows.Forms.Timer timer1;
        private EventHandler btnCheck_Click;
        private System.Windows.Forms.Label lblMyTime;
        private System.Windows.Forms.Label punkty;

        public EventHandler BtnCheck_Click { get => btnCheck_Click; set => btnCheck_Click = value; }
    }
}