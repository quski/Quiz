namespace WindowsFormsApp2
{
    partial class Form12
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
            this.close = new System.Windows.Forms.Button();
            this.Again = new System.Windows.Forms.Button();
            this.Wygrana = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close.Location = new System.Drawing.Point(535, 266);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(117, 45);
            this.close.TabIndex = 0;
            this.close.Text = "Koniec";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Again
            // 
            this.Again.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Again.Location = new System.Drawing.Point(119, 266);
            this.Again.Name = "Again";
            this.Again.Size = new System.Drawing.Size(117, 45);
            this.Again.TabIndex = 1;
            this.Again.Text = "Powrót";
            this.Again.UseVisualStyleBackColor = true;
            this.Again.Click += new System.EventHandler(this.Again_Click);
            // 
            // Wygrana
            // 
            this.Wygrana.AutoSize = true;
            this.Wygrana.BackColor = System.Drawing.SystemColors.Control;
            this.Wygrana.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wygrana.Location = new System.Drawing.Point(205, 29);
            this.Wygrana.Name = "Wygrana";
            this.Wygrana.Size = new System.Drawing.Size(359, 234);
            this.Wygrana.TabIndex = 2;
            this.Wygrana.Text = "Gratulacje Wygrałeś !!!\r\n\r\n\r\n\r\n\r\n\r\n";
            this.Wygrana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Wygrana);
            this.Controls.Add(this.Again);
            this.Controls.Add(this.close);
            this.Name = "Form12";
            this.Text = "Form12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button Again;
        private System.Windows.Forms.Label Wygrana;
    }
}