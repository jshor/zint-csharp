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
        public Symbology symbology;
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

            //symb.CreateSymbology("datamatrix.png", "12345", 5, 0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((String)comboBox1.SelectedItem == "Aztec Code (ISO 24778)")
            {
                options1.ChangeSymbology(BarcodeTypes.AZTEC);
                this.symbology = options1.symbology;
            }
        }

        private void options_OptionsChanged(object sender, EventArgs e)
        {
            if (this.symbology != null)
            {
                String symbologyStr = "Symbology = " + this.symbology.Symbol + "; Option1 = " + this.symbology.Option1
                    + "; Option2 = " + this.symbology.Option2 + "; Option3 = " + this.symbology.Option3 + "; Mode = "
                    + this.symbology.InputMode + "; ";

                Console.WriteLine(symbologyStr);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
