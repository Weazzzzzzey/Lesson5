using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VardasIrData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Ivedimas.Name = "Taip?";
        }

        private void Ivedimas_Click(object sender, EventArgs e)
        {
            DateTime Dabar = DateTime.Now;
            string now = Dabar.ToString("\r\ndd MMMM yyyy");
            OutPut.Text = "Sveikas Programuotojau";
            OutPut.AppendText(now);


        }
    }
}
