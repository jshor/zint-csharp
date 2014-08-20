using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZintTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void createBarcode_Click(object sender, EventArgs e)
        {
            Symbology symb = new Symbology();
            symb.Symbol = 71;
            symb.Outfile = "datamatrix.png";
            symb.Width = 100;
            symb.Height = 100;

            symb.CreateSymbology("datamatrix.png", "12345", 5, 0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((String)comboBox1.SelectedItem == "Aztec Code (ISO 24778)")
            {

            }
        }
    }
}
