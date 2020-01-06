using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TBmygtukas_Click(object sender, EventArgs e)
        {
            string mase = TBmase.Text;
            string ugis = TBugis.Text;
            double kmi = Convert.ToDouble(mase) / Math.Pow(Convert.ToDouble(ugis),2);
            string aprasymas = "";
            
            if (kmi <= 18.5)
            {
                aprasymas = "Asmuo yra nusilpes ir jo kuno svoris yra per mazas";
            }
            else if (kmi > 18.5 && kmi < 25)
            {
                aprasymas = "Idealus kmi";
            }
            else if (kmi > 25 && kmi < 30)
            {
                aprasymas = "Asmuo turi virssvori";
            }
            else if (kmi >= 30)
            {
                aprasymas = "Asmuo yra nutukes";
            }

            TBkmi.Text = $"{Math.Round(kmi,2)} - {aprasymas}";




        }
    }
}
