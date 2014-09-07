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
        public Symbology symbology;
        private IBarcode symbologyOptions;
        public event EventHandler OptionsChanged;
        public Options()
        {
            InitializeComponent();
            symbology = new Symbology();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {

        }

        public void ChangeSymbology(BarcodeTypes symbol)
        {
            if (symbol == BarcodeTypes.AZTEC)
            {
                symbologyOptions = new Aztec(symbology);
                tabPage2.Controls.Add(symbologyOptions.GetControl());
            }

            symbology.Symbol = BarcodeTypes.AZTEC;
            symbologyOptions.OptionsChanged += symbologyOptions_OptionsChanged;
        }

        private void symbologyOptions_OptionsChanged(object sender, EventArgs e)
        {

            if (this.OptionsChanged != null)
                this.OptionsChanged(new object(), new EventArgs());
        }

        private void backgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                backgroundColor.BackColor = colorDialog.Color;
                symbology.BackgroundColor = ColorToHex(colorDialog.Color);
                symbologyOptions_OptionsChanged(sender, e);
            }
        }

        private void foregroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                foregroundColor.BackColor = colorDialog.Color;
                symbology.ForegroundColor = ColorToHex(colorDialog.Color);
                symbologyOptions_OptionsChanged(sender, e);
            }
        }

        private static String ColorToHex(System.Drawing.Color c)
        {
            String rtn = String.Empty;
            try
            {
                rtn = c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            }
            catch (Exception ex)
            {
                //doing nothing
            }

            return rtn;
        }
    }
}
