using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NamuDarbasAntrasBandymas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TBmygtukas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ivedimas Pavyko");
        }

        private void TBinput_TextChanged(object sender, EventArgs e)
        {
            if (TBinput.Text == "")
            {
                MessageBox.Show("Ivedimas negali buti tuscias");
                return;
            }
            TBoutput.Text = $"Sveikas {TBinput.Text}";
            TBoutput.AppendText("\r\nMalonu Tave Matyti");
        }
    }
}
