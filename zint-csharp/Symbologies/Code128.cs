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
    public partial class Code128 : UserControl, IBarcode
    {
        public event EventHandler OptionsChanged;
        private Symbology symbology;
        public Code128(Symbology symb)
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
            if (hibc128.Checked)
                this.symbology.Symbol = BarcodeTypes.HIBC_128;
            else if (subsetCSuppression.Checked)
                this.symbology.Symbol = BarcodeTypes.CODE128B;
            else
                this.symbology.Symbol = BarcodeTypes.CODE128;

            if (this.OptionsChanged != null)
                this.OptionsChanged(new object(), new EventArgs());
        }
    }
}
