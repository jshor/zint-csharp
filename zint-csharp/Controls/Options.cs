using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZintWrapper.Symbologies
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

        public void ChangeSymbology(BarcodeTypes symbol)
        {
            // remove all tabs except the "appearance" tab
            for (int i = 0; i < generalTab.TabPages.Count; i++ )
            {
                if (generalTab.TabPages[i] != appearanceTab)
                {
                    generalTab.TabPages.Remove(generalTab.TabPages[i]);
                }
            }

            switch (symbol)
            {
                case BarcodeTypes.AZTEC:
                    symbologyOptions = new Aztec(symbology);
                    break;
                case BarcodeTypes.CHANNEL:
                    symbologyOptions = new ChannelCode(symbology);
                    break;
                case BarcodeTypes.DATAMATRIX:
                    symbologyOptions = new DataMatrix(symbology);
                    break;
                case BarcodeTypes.GRIDMATRIX:
                    symbologyOptions = new GridMatrix(symbology);
                    break;
                case BarcodeTypes.MAXICODE:
                    symbologyOptions = new MaxiCode(symbology);
                    break;
                case BarcodeTypes.MICROPDF417:
                    symbologyOptions = new MicroPDF(symbology);
                    break;
                default:
                    symbologyOptions = null;
                    break;
            }

            if(symbologyOptions != null)
            {
                // add the "options" tab if it's set and add event listener
                TabPage optionsTab = new TabPage("Options");
                optionsTab.Controls.Add(symbologyOptions.GetControl());
                generalTab.TabPages.Add(optionsTab);
                symbologyOptions.OptionsChanged += symbologyOptions_OptionsChanged;
            }

            symbology.Symbol = symbol;
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

        private void height_ValueChanged(object sender, EventArgs e)
        {
            symbology.Height = (int)height.Value;
        }

        private void borderWidth_ValueChanged(object sender, EventArgs e)
        {
            symbology.BorderWidth = (int)borderWidth.Value;
        }

        private void whitespace_ValueChanged(object sender, EventArgs e)
        {
            symbology.WhitespaceWidth = (int)whitespace.Value;
        }

        private void printingScale_ValueChanged(object sender, EventArgs e)
        {
            symbology.Scale = (int)printingScale.Value;
        }

        private void rotation_ValueChanged(object sender, EventArgs e)
        {
            symbology.Rotation = (int)rotation.Value;
        }
    }
}
