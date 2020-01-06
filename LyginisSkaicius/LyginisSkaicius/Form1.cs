using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyginisSkaicius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TBskaiciavimas_Click(object sender, EventArgs e)
        {
            string isgavimas = TBinput.Text;

            if(Convert.ToInt32(isgavimas) %2 == 0)
            {
                MessageBox.Show("Skaicius yra lyginis");
            }
            else
                MessageBox.Show("Skaicius yra nelyginis");
        }
    }
}
