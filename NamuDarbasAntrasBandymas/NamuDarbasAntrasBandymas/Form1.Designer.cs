namespace NamuDarbasAntrasBandymas
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
            this.TBlabel = new System.Windows.Forms.Label();
            this.TBinput = new System.Windows.Forms.TextBox();
            this.TBmygtukas = new System.Windows.Forms.Button();
            this.TBoutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBlabel
            // 
            this.TBlabel.AutoSize = true;
            this.TBlabel.Location = new System.Drawing.Point(13, 13);
            this.TBlabel.Name = "TBlabel";
            this.TBlabel.Size = new System.Drawing.Size(46, 17);
            this.TBlabel.TabIndex = 0;
            this.TBlabel.Text = "label1";
            // 
            // TBinput
            // 
            this.TBinput.Location = new System.Drawing.Point(65, 8);
            this.TBinput.Name = "TBinput";
            this.TBinput.Size = new System.Drawing.Size(100, 22);
            this.TBinput.TabIndex = 1;
            this.TBinput.TextChanged += new System.EventHandler(this.TBinput_TextChanged);
            // 
            // TBmygtukas
            // 
            this.TBmygtukas.Location = new System.Drawing.Point(13, 34);
            this.TBmygtukas.Name = "TBmygtukas";
            this.TBmygtukas.Size = new System.Drawing.Size(152, 23);
            this.TBmygtukas.TabIndex = 2;
            this.TBmygtukas.Text = "button1";
            this.TBmygtukas.UseVisualStyleBackColor = true;
            this.TBmygtukas.Click += new System.EventHandler(this.TBmygtukas_Click);
            // 
            // TBoutput
            // 
            this.TBoutput.Location = new System.Drawing.Point(13, 64);
            this.TBoutput.Multiline = true;
            this.TBoutput.Name = "TBoutput";
            this.TBoutput.Size = new System.Drawing.Size(152, 142);
            this.TBoutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 218);
            this.Controls.Add(this.TBoutput);
            this.Controls.Add(this.TBmygtukas);
            this.Controls.Add(this.TBinput);
            this.Controls.Add(this.TBlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TBlabel;
        private System.Windows.Forms.TextBox TBinput;
        private System.Windows.Forms.Button TBmygtukas;
        private System.Windows.Forms.TextBox TBoutput;
    }
}

