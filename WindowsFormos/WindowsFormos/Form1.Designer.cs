namespace WindowsFormos
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TXTname = new System.Windows.Forms.Label();
            this.TBname = new System.Windows.Forms.Button();
            this.TBoutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TXTname
            // 
            this.TXTname.AutoSize = true;
            this.TXTname.Location = new System.Drawing.Point(12, 13);
            this.TXTname.Name = "TXTname";
            this.TXTname.Size = new System.Drawing.Size(46, 17);
            this.TXTname.TabIndex = 1;
            this.TXTname.Text = "label1";
            // 
            // TBname
            // 
            this.TBname.Location = new System.Drawing.Point(13, 41);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(158, 23);
            this.TBname.TabIndex = 2;
            this.TBname.Text = "button1";
            this.TBname.UseVisualStyleBackColor = true;
            this.TBname.Click += new System.EventHandler(this.TBname_Click);
            // 
            // TBoutput
            // 
            this.TBoutput.Location = new System.Drawing.Point(13, 71);
            this.TBoutput.Multiline = true;
            this.TBoutput.Name = "TBoutput";
            this.TBoutput.Size = new System.Drawing.Size(158, 193);
            this.TBoutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 276);
            this.Controls.Add(this.TBoutput);
            this.Controls.Add(this.TBname);
            this.Controls.Add(this.TXTname);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TXTname;
        private System.Windows.Forms.Button TBname;
        private System.Windows.Forms.TextBox TBoutput;
    }
}

