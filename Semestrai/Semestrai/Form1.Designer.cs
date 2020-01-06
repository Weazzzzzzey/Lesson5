namespace Semestrai
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
            this.TBpirmas = new System.Windows.Forms.TextBox();
            this.TBantras = new System.Windows.Forms.TextBox();
            this.TBtrecias = new System.Windows.Forms.TextBox();
            this.TBoutput = new System.Windows.Forms.TextBox();
            this.TBapskaiciavimas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBpirmas
            // 
            this.TBpirmas.Location = new System.Drawing.Point(13, 13);
            this.TBpirmas.Name = "TBpirmas";
            this.TBpirmas.Size = new System.Drawing.Size(100, 22);
            this.TBpirmas.TabIndex = 0;
            // 
            // TBantras
            // 
            this.TBantras.Location = new System.Drawing.Point(119, 13);
            this.TBantras.Name = "TBantras";
            this.TBantras.Size = new System.Drawing.Size(100, 22);
            this.TBantras.TabIndex = 1;
            // 
            // TBtrecias
            // 
            this.TBtrecias.Location = new System.Drawing.Point(225, 13);
            this.TBtrecias.Name = "TBtrecias";
            this.TBtrecias.Size = new System.Drawing.Size(100, 22);
            this.TBtrecias.TabIndex = 2;
            // 
            // TBoutput
            // 
            this.TBoutput.Location = new System.Drawing.Point(331, 13);
            this.TBoutput.Multiline = true;
            this.TBoutput.Name = "TBoutput";
            this.TBoutput.Size = new System.Drawing.Size(209, 52);
            this.TBoutput.TabIndex = 3;
            // 
            // TBapskaiciavimas
            // 
            this.TBapskaiciavimas.Location = new System.Drawing.Point(13, 42);
            this.TBapskaiciavimas.Name = "TBapskaiciavimas";
            this.TBapskaiciavimas.Size = new System.Drawing.Size(312, 23);
            this.TBapskaiciavimas.TabIndex = 4;
            this.TBapskaiciavimas.Text = "Apskaiciuoti";
            this.TBapskaiciavimas.UseVisualStyleBackColor = true;
            this.TBapskaiciavimas.Click += new System.EventHandler(this.TBapskaiciavimas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 79);
            this.Controls.Add(this.TBapskaiciavimas);
            this.Controls.Add(this.TBoutput);
            this.Controls.Add(this.TBtrecias);
            this.Controls.Add(this.TBantras);
            this.Controls.Add(this.TBpirmas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBpirmas;
        private System.Windows.Forms.TextBox TBantras;
        private System.Windows.Forms.TextBox TBtrecias;
        private System.Windows.Forms.TextBox TBoutput;
        private System.Windows.Forms.Button TBapskaiciavimas;
    }
}

