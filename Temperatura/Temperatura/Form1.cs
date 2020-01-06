using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TBapskeiciavimas_Click(object sender, EventArgs e)
        {
            string ivedimas = TBivedimas.Text;
            double K = Convert.ToDouble(ivedimas) + 273.16;
            double R = Convert.ToDouble(ivedimas) * 0.8;
            double F = Convert.ToDouble(ivedimas) * 9 / 5 + 32;

            TBoutput.Text =     $"K {K}" + 
                            $"\r\nR {R}" +
                            $"\r\nF {F}";


        }
    }
}
