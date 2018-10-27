using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zintcsharp.Symbologies
{
    public partial class DataMatrix : UserControl, IBarcode
    {
        public event EventHandler OptionsChanged;
        private Symbology symbology;

        public DataMatrix(Symbology symb)
        {
            InitializeComponent();

            this.symbology = symb;
            this.symbology.Option1 = 0;
            this.symbology.Option2 = 0;
            this.symbology.Option3 = 0;
            this.symbology.InputMode = 0;
        }

        public Symbology GetSymbology()
        {
            return this.symbology;
        }

        public UserControl GetControl()
        {
            return this;
        }

        private void Aztec_Load(object sender, EventArgs e)
        {
            // sizes
            String[] Option2 = new String[] { "Automatic", "10 x 10", "12 x 12", "14 x 14", "16 x 16", "18 x 18", "20 x 20", "22 x 22", 
                "24 x 24", "26 x 26", "32 x 32", "36 x 36", "40 x 40", "44 x 44", "48 x 48", "52 x 52", "64 x 64", "72 x 72", 
                "80 x 80", "88 x 88", "96 x 96", "104 x 104", "120 x 120", "132 x 132", "144 x 144", "8 x 18", "8 x 32", 
                "12 x 26", "12 x 36", "16 x 36", "16 x 48" };

            option2.PopulateOptions(Option2);
            option2.SelectedIndex = 0;

            // default values
            symbology.Symbol = BarcodeTypes.DATAMATRIX;
            symbology.InputMode = 0;
            symbology.Option1 = 0;
            symbology.Option2 = 0;
        }

        private void rectangleSupression_CheckedChanged(object sender, EventArgs e)
        {
            if (rectangleSupression.Checked)
                symbology.Option3 = 100; // DM_SQUARE
            else
                symbology.Option3 = 0; // none

            if (this.OptionsChanged != null)
                this.OptionsChanged(new object(), new EventArgs());
        }

        private void option2_SelectedIndexChanged(object sender, EventArgs e)
        {
            symbology.Option2 = option2.GetSelectedItemValue();

            if (this.OptionsChanged != null)
                this.OptionsChanged(new object(), new EventArgs());
        }
        private void encodingRadioButton_OptionsChanged(object sender, EventArgs e)
        {
            if (gs1DataMode.Checked)
            {
                symbology.Symbol = BarcodeTypes.DATAMATRIX;
                symbology.InputMode = 2;
            }
            else
            {
                symbology.Symbol = BarcodeTypes.DATAMATRIX;
                symbology.InputMode = 0;
            }

            if (this.OptionsChanged != null)
                this.OptionsChanged(new object(), new EventArgs());
        }
    }
}
