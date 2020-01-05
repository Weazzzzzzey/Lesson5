using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TBname_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ivedimas pavyko");
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (TBname.Text == "")
            {
                MessageBox.Show("Ivedimas negali buti tuscias");
                return;
            }
            
            TBoutput.Text = $"Sveikas {TBname.Text}";

            TBoutput.AppendText{"\r\n Malonu tave matyti"};
        }

        
    }
}
