﻿namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMyTime = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(238, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "WITAJ W GRZE QUIZ !!!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rozpocznij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(516, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Zakończ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.lblMyTime.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMyTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMyTime.Location = new System.Drawing.Point(289, 149);
            this.lblMyTime.Name = "lblMyTime";
            this.lblMyTime.Size = new System.Drawing.Size(102, 25);
            this.lblMyTime.TabIndex = 3;
            this.lblMyTime.Text = "5 seconds";
            this.lblMyTime.Visible = false;
            this.lblMyTime.Click += new System.EventHandler(this.lblMyTime_Click);
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(329, 115);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(35, 13);
            this.lblM.TabIndex = 4;
            this.lblM.Text = "label2";
            this.lblM.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblMyTime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GRA QUIZ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMyTime;
        private System.Windows.Forms.Label lblM;
    }
}

