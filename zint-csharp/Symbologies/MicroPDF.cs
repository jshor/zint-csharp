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
    public partial class MicroPDF : UserControl, IBarcode
    {
        public event EventHandler OptionsChanged;
        private Symbology symbology;

        public MicroPDF(Symbology symb)
        {
            InitializeComponent();

            this.symbology = symb;
            this.symbology.Option1 = 0;
            this.symbology.Option2 = 0;
            this.symbology.Option3 = 0;
            this.symbology.InputMode = 0;
        }

        private void MicroPDF_Load(object sender, EventArgs e)
        {
            int[] Option2Value = new int[] { 0, 1, 2, 3, 4 };
            String[] Option2 = new String[] { "Automatic", "1", "2", "3", "4" };

            option2.PopulateOptions(Option2Value, Option2);
        }

        public Symbology GetSymbology()
        {
            return this.symbology;
        }

        public UserControl GetControl()
        {
            return this;
        }

        private void optionElement_OptionsChanged(object sender, EventArgs e)
        {
            symbology.Option2 = option2.GetSelectedItemValue();

            if (hibcRadio.Checked)
            {
                this.symbology.Symbol = BarcodeTypes.HIBC_MICPDF;
            }
            else
            {
                // standard mode
                this.symbology.Symbol = BarcodeTypes.MICROPDF417;
            }

            if (this.OptionsChanged != null)
                this.OptionsChanged(new object(), new EventArgs());
        }
    }
}
