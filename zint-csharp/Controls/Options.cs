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
        public string DataToEncode;

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
                if (generalTab.TabPages[i] != appearanceTab && generalTab.TabPages[i] != dataTab)
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
                case BarcodeTypes.CODE128:
                    symbologyOptions = new Code128(symbology);
                    break;
                case BarcodeTypes.CODE16K:
                    symbologyOptions = new Code16k(symbology);
                    break;
                case BarcodeTypes.CODE39:
                    symbologyOptions = new Code39(symbology);
                    break;
                case BarcodeTypes.EXCODE39:
                    symbologyOptions = new Code39Ext(symbology);
                    break;
                case BarcodeTypes.CODE49:
                    symbologyOptions = new Code49(symbology);
                    break;
                case BarcodeTypes.CODEONE:
                    symbologyOptions = new CodeOne(symbology);
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
                case BarcodeTypes.MICROQR:
                    symbologyOptions = new MicroQR(symbology);
                    break;
                case BarcodeTypes.QRCODE:
                    symbologyOptions = new QRCode(symbology);
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

            // show the 2D composite options group box, if applies
            if (Allows2DComponent(symbol))
            {
                add2DComponentGroup.Visible = true;
            }
            else
            {
                add2DComponent.Checked = false;
                add2DComponentGroup.Visible = false;
                componentType.SelectedIndex = 0;
                secondaryData.Text = "";
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

        private void data_ValueChanged(object sender, EventArgs e)
        {
            if (add2DComponent.Checked)
            {
                componentType.Enabled = true;
                secondaryData.Enabled = true;

                this.DataToEncode = secondaryData.Text;
                this.symbology.Option1 = componentType.SelectedIndex;
                symbology.Primary = primaryData.Text;

                // attempt to convert to enum with '_CC' appended
                BarcodeTypes newBarcodeType = this.symbology.Symbol;

                if (Enum.TryParse<BarcodeTypes>(this.symbology.Symbol.ToString() + "_CC", out newBarcodeType))
                    this.symbology.Symbol = newBarcodeType;
            }
            else
            {
                componentType.Enabled = false;
                secondaryData.Enabled = false;

                this.DataToEncode = primaryData.Text;
                symbology.Primary = "";

                // attempt to convert to enum with '_CC' truncated
                string oldBarcodeType = this.symbology.Symbol.ToString();
                BarcodeTypes newBarcodeType = this.symbology.Symbol;

                if (oldBarcodeType.Substring(oldBarcodeType.Length - 3, 3) == "_CC")
                {
                    if (Enum.TryParse<BarcodeTypes>(oldBarcodeType.Substring(0, oldBarcodeType.Length-3), out newBarcodeType))
                        this.symbology.Symbol = newBarcodeType;
                }
            }

            Console.WriteLine(this.symbology.Symbol);
            symbologyOptions_OptionsChanged(sender, e);
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

        private bool Allows2DComponent(BarcodeTypes barcodeType)
        {
            bool allowed = false;
            BarcodeTypes[] compositeCodeTypes = new BarcodeTypes[] {
                BarcodeTypes.EANX,
                BarcodeTypes.EAN128,
                BarcodeTypes.RSS14,
                BarcodeTypes.RSS_LTD,
                BarcodeTypes.RSS_EXP,
                BarcodeTypes.UPCA,
                BarcodeTypes.UPCE,
                BarcodeTypes.RSS14STACK,
                BarcodeTypes.RSS14STACK_OMNI,
                BarcodeTypes.RSS_EXPSTACK,
            };

            if (compositeCodeTypes.Contains<BarcodeTypes>(barcodeType))
                allowed = true;

            return allowed;
        }
    }
}
