namespace KMI
{
    partial class Form1
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
            this.TBmase = new System.Windows.Forms.TextBox();
            this.TBugis = new System.Windows.Forms.TextBox();
            this.TBkmi = new System.Windows.Forms.TextBox();
            this.TBmygtukas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBmase
            // 
            this.TBmase.Location = new System.Drawing.Point(12, 12);
            this.TBmase.Name = "TBmase";
            this.TBmase.Size = new System.Drawing.Size(100, 22);
            this.TBmase.TabIndex = 0;
            // 
            // TBugis
            // 
            this.TBugis.Location = new System.Drawing.Point(12, 50);
            this.TBugis.Name = "TBugis";
            this.TBugis.Size = new System.Drawing.Size(100, 22);
            this.TBugis.TabIndex = 1;
            // 
            // TBkmi
            // 
            this.TBkmi.Location = new System.Drawing.Point(118, 12);
            this.TBkmi.Multiline = true;
            this.TBkmi.Name = "TBkmi";
            this.TBkmi.Size = new System.Drawing.Size(102, 60);
            this.TBkmi.TabIndex = 2;
            // 
            // TBmygtukas
            // 
            this.TBmygtukas.Location = new System.Drawing.Point(12, 78);
            this.TBmygtukas.Name = "TBmygtukas";
            this.TBmygtukas.Size = new System.Drawing.Size(208, 29);
            this.TBmygtukas.TabIndex = 3;
            this.TBmygtukas.Text = "Apskaiciuoti";
            this.TBmygtukas.UseVisualStyleBackColor = true;
            this.TBmygtukas.Click += new System.EventHandler(this.TBmygtukas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 119);
            this.Controls.Add(this.TBmygtukas);
            this.Controls.Add(this.TBkmi);
            this.Controls.Add(this.TBugis);
            this.Controls.Add(this.TBmase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBmase;
        private System.Windows.Forms.TextBox TBugis;
        private System.Windows.Forms.TextBox TBkmi;
        private System.Windows.Forms.Button TBmygtukas;
    }
}

