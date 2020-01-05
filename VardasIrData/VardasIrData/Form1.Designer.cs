namespace VardasIrData
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
            this.Ivedimas = new System.Windows.Forms.Button();
            this.OutPut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ivedimas
            // 
            this.Ivedimas.Location = new System.Drawing.Point(12, 93);
            this.Ivedimas.Name = "Ivedimas";
            this.Ivedimas.Size = new System.Drawing.Size(184, 58);
            this.Ivedimas.TabIndex = 0;
            this.Ivedimas.Text = "Ivedimas";
            this.Ivedimas.UseVisualStyleBackColor = true;
            this.Ivedimas.Click += new System.EventHandler(this.Ivedimas_Click);
            // 
            // OutPut
            // 
            this.OutPut.Location = new System.Drawing.Point(13, 13);
            this.OutPut.Multiline = true;
            this.OutPut.Name = "OutPut";
            this.OutPut.Size = new System.Drawing.Size(183, 74);
            this.OutPut.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 163);
            this.Controls.Add(this.OutPut);
            this.Controls.Add(this.Ivedimas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ivedimas;
        private System.Windows.Forms.TextBox OutPut;
    }
}

