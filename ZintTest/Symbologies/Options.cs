using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZintTest.Symbologies
{
    public partial class Options : UserControl
    {
        private Symbology symbology;
        private IBarcode symbologyOptions;
        public Options()
        {
            InitializeComponent();
            symbology = new Symbology();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            symbologyOptions = new Aztec(symbology);
            tabPage2.Controls.Add(symbologyOptions.GetControl());

            symbologyOptions.OptionsChanged += symbologyOptions_OptionsChanged;
        }

        private void symbologyOptions_OptionsChanged(object sender, EventArgs e)
        {
            this.symbology = symbologyOptions.GetSymbology();

            String symbologyStr = "Symbology = " + this.symbology.Symbol + "; Option1 = " + this.symbology.Option1
                + "; Option2 = " + this.symbology.Option2 + "; Option3 = " + this.symbology.Option3 + "; Mode = "
                + this.symbology.InputMode + "; ";

            Console.WriteLine(symbologyStr);
        }
    }
}
