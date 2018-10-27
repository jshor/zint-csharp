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
    public partial class Code16k : UserControl, IBarcode
    {
        public event EventHandler OptionsChanged;
        private Symbology symbology;

        public Code16k(Symbology symb)
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
            if (gs1DataMode.Checked)
                this.symbology.InputMode = (int)EncodingMode.GS1_MODE;
            else
                this.symbology.InputMode = (int)EncodingMode.DATA_MODE;

            if (this.OptionsChanged != null)
                this.OptionsChanged(new object(), new EventArgs());
        }
    }
}
