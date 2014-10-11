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
    public partial class Code39 : UserControl, IBarcode
    {
        public event EventHandler OptionsChanged;
        private Symbology symbology;

        public Code39(Symbology symb)
        {
            InitializeComponent();

            this.symbology = symb;
        }

        public Symbology GetSymbology()
        {
            return this.symbology;
        }

        public UserControl GetControl()
        {
            return this;
        }

        private void encodingRadioButton_OptionsChanged(object sender, EventArgs e)
        {
            if (mod43ChkDigit.Checked)
            {
                this.symbology.Option2 = 1;
                this.symbology.Symbol = BarcodeTypes.CODE39;
            }
            else if (hibc39.Checked)
            {
                this.symbology.Option2 = 0;
                this.symbology.Symbol = BarcodeTypes.HIBC_39;
            }
            else
            {
                this.symbology.Option2 = 0;
                this.symbology.Symbol = BarcodeTypes.CODE39;
            }

            if (this.OptionsChanged != null)
                this.OptionsChanged(new object(), new EventArgs());
        }
    }
}
