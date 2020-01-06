namespace LyginisSkaicius
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
            this.TBinput = new System.Windows.Forms.TextBox();
            this.TBskaiciavimas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBinput
            // 
            this.TBinput.Location = new System.Drawing.Point(13, 13);
            this.TBinput.Name = "TBinput";
            this.TBinput.Size = new System.Drawing.Size(100, 22);
            this.TBinput.TabIndex = 0;
            // 
            // TBskaiciavimas
            // 
            this.TBskaiciavimas.Location = new System.Drawing.Point(12, 41);
            this.TBskaiciavimas.Name = "TBskaiciavimas";
            this.TBskaiciavimas.Size = new System.Drawing.Size(75, 23);
            this.TBskaiciavimas.TabIndex = 1;
            this.TBskaiciavimas.Text = "button1";
            this.TBskaiciavimas.UseVisualStyleBackColor = true;
            this.TBskaiciavimas.Click += new System.EventHandler(this.TBskaiciavimas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBskaiciavimas);
            this.Controls.Add(this.TBinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBinput;
        private System.Windows.Forms.Button TBskaiciavimas;
    }
}

