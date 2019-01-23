namespace WindowsFormsApp2
{
    partial class Form6
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.gbxQu3 = new System.Windows.Forms.GroupBox();
            this.opt4 = new System.Windows.Forms.RadioButton();
            this.opt3 = new System.Windows.Forms.RadioButton();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.lblMyTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.punkty = new System.Windows.Forms.Label();
            this.gbxQu3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNext.Location = new System.Drawing.Point(505, 330);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(117, 45);
            this.btnNext.TabIndex = 10;
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
            this.btnCheck.TabIndex = 9;
            this.btnCheck.Text = "Sprawdź";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // gbxQu3
            // 
            this.gbxQu3.Controls.Add(this.opt4);
            this.gbxQu3.Controls.Add(this.opt3);
            this.gbxQu3.Controls.Add(this.opt2);
            this.gbxQu3.Controls.Add(this.opt1);
            this.gbxQu3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbxQu3.Location = new System.Drawing.Point(182, 76);
            this.gbxQu3.Name = "gbxQu3";
            this.gbxQu3.Size = new System.Drawing.Size(440, 214);
            this.gbxQu3.TabIndex = 8;
            this.gbxQu3.TabStop = false;
            this.gbxQu3.Text = "Najwięcej olimpijskich medali posiada?";
            this.gbxQu3.Enter += new System.EventHandler(this.gbxQu3_Enter);
            // 
            // opt4
            // 
            this.opt4.AutoSize = true;
            this.opt4.Location = new System.Drawing.Point(17, 173);
            this.opt4.Name = "opt4";
            this.opt4.Size = new System.Drawing.Size(247, 29);
            this.opt4.TabIndex = 3;
            this.opt4.TabStop = true;
            this.opt4.Text = "Renata Mauer-Różańska";
            this.opt4.UseVisualStyleBackColor = true;
            this.opt4.CheckedChanged += new System.EventHandler(this.opt4_CheckedChanged);
            // 
            // opt3
            // 
            this.opt3.AutoSize = true;
            this.opt3.Location = new System.Drawing.Point(17, 122);
            this.opt3.Name = "opt3";
            this.opt3.Size = new System.Drawing.Size(190, 29);
            this.opt3.TabIndex = 2;
            this.opt3.TabStop = true;
            this.opt3.Text = "Otylia Jędrzejczak";
            this.opt3.UseVisualStyleBackColor = true;
            this.opt3.CheckedChanged += new System.EventHandler(this.opt3_CheckedChanged);
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.Location = new System.Drawing.Point(17, 76);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(174, 29);
            this.opt2.TabIndex = 1;
            this.opt2.TabStop = true;
            this.opt2.Text = "Irena Szewińska";
            this.opt2.UseVisualStyleBackColor = true;
            this.opt2.CheckedChanged += new System.EventHandler(this.opt2_CheckedChanged);
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.Location = new System.Drawing.Point(17, 29);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(198, 29);
            this.opt1.TabIndex = 0;
            this.opt1.TabStop = true;
            this.opt1.Text = "Justyna Kowalczyk";
            this.opt1.UseVisualStyleBackColor = true;
            this.opt1.CheckedChanged += new System.EventHandler(this.opt1_CheckedChanged);
            // 
            // lblMyTime
            // 
            this.lblMyTime.AutoSize = true;
            this.lblMyTime.BackColor = System.Drawing.SystemColors.Info;
            this.lblMyTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMyTime.Location = new System.Drawing.Point(628, 76);
            this.lblMyTime.Name = "lblMyTime";
            this.lblMyTime.Size = new System.Drawing.Size(103, 25);
            this.lblMyTime.TabIndex = 11;
            this.lblMyTime.Text = "30 sekund";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // punkty
            // 
            this.punkty.AutoSize = true;
            this.punkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.punkty.Location = new System.Drawing.Point(628, 156);
            this.punkty.Name = "punkty";
            this.punkty.Size = new System.Drawing.Size(94, 25);
            this.punkty.TabIndex = 12;
            this.punkty.Text = "Punkty: 4";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.punkty);
            this.Controls.Add(this.lblMyTime);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.gbxQu3);
            this.Name = "Form6";
            this.Text = "Form6";
            this.gbxQu3.ResumeLayout(false);
            this.gbxQu3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox gbxQu3;
        private System.Windows.Forms.RadioButton opt4;
        private System.Windows.Forms.RadioButton opt3;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.Label lblMyTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label punkty;
    }
}