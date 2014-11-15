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
    public partial class PDF417 : UserControl, IBarcode
    {
        public event EventHandler OptionsChanged;
        private Symbology symbology;

        public PDF417(Symbology symb)
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

        private void PDF417_Load(object sender, EventArgs e)
        {
            String[] Option1 = new String[] { "Automatic", "2 words", "4 words", "8 words", "16 words", "32 words", "64 words", "128 words", "256 words", "512 words" };
            String[] Option2 = new String[] { "Automatic", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" };

            option1.PopulateOptions(Option1);
            option2.PopulateOptions(Option2);
        }

        private void optionElement_OptionsChanged(object sender, EventArgs e)
        {
            symbology.Option1 = option1.GetSelectedItemValue();
            symbology.Option2 = option2.GetSelectedItemValue();

            if (hibcMode.Checked)
                this.symbology.Symbol = BarcodeTypes.HIBC_PDF;
            else if (truncatedMode.Checked)
                this.symbology.Symbol = BarcodeTypes.PDF417TRUNC;
            else
                this.symbology.Symbol = BarcodeTypes.PDF417;

            if (this.OptionsChanged != null)
                this.OptionsChanged(new object(), new EventArgs());
        }
    }
}
