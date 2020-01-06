namespace Temperatura
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
            this.TBivedimas = new System.Windows.Forms.TextBox();
            this.TBoutput = new System.Windows.Forms.TextBox();
            this.TBapskeiciavimas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBivedimas
            // 
            this.TBivedimas.Location = new System.Drawing.Point(13, 13);
            this.TBivedimas.Name = "TBivedimas";
            this.TBivedimas.Size = new System.Drawing.Size(100, 22);
            this.TBivedimas.TabIndex = 0;
            // 
            // TBoutput
            // 
            this.TBoutput.Location = new System.Drawing.Point(119, 13);
            this.TBoutput.Multiline = true;
            this.TBoutput.Name = "TBoutput";
            this.TBoutput.Size = new System.Drawing.Size(133, 64);
            this.TBoutput.TabIndex = 1;
            // 
            // TBapskeiciavimas
            // 
            this.TBapskeiciavimas.Location = new System.Drawing.Point(13, 42);
            this.TBapskeiciavimas.Name = "TBapskeiciavimas";
            this.TBapskeiciavimas.Size = new System.Drawing.Size(100, 35);
            this.TBapskeiciavimas.TabIndex = 2;
            this.TBapskeiciavimas.Text = "button1";
            this.TBapskeiciavimas.UseVisualStyleBackColor = true;
            this.TBapskeiciavimas.Click += new System.EventHandler(this.TBapskeiciavimas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 89);
            this.Controls.Add(this.TBapskeiciavimas);
            this.Controls.Add(this.TBoutput);
            this.Controls.Add(this.TBivedimas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBivedimas;
        private System.Windows.Forms.TextBox TBoutput;
        private System.Windows.Forms.Button TBapskeiciavimas;
    }
}

