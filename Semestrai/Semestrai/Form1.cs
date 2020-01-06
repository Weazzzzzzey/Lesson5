using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestrai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TBapskaiciavimas_Click(object sender, EventArgs e)
        {
            string pirmas = TBpirmas.Text;
            string antras = TBantras.Text;
            string trecias = TBtrecias.Text;
            double vidurkis = (double.Parse(pirmas) + double.Parse(antras) + double.Parse(trecias)) / 3;

            TBoutput.Text = $"Semestru pazymiai: {pirmas}, {antras}, {trecias}";
            TBoutput.AppendText($"\r\nVidurkis: {Math.Round(vidurkis,2)}");



        }
    }
}
