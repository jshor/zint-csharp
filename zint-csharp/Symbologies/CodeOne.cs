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
    public partial class CodeOne : UserControl, IBarcode
    {
        public event EventHandler OptionsChanged;
        private Symbology symbology;

        public CodeOne(Symbology symb)
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


            // change symbol size
            this.symbology.Option2 = option2.GetSelectedItemValue();

            if (this.OptionsChanged != null)
                this.OptionsChanged(new object(), new EventArgs());
        }

        private void CodeOne_Load(object sender, EventArgs e)
        {
            // size option
            String[] Option2 = { "Automatic", "16 x 18 (Version A)", "22 x 22 (Version B)", "28 x 32 (Version C)", "40 x 42 (Version D)", "52 x 54 (Version E)", 
                                   "70 x 76 (Version F)", "104 x 98 (Version G)", "148 x 134 (Version H)", "8x height (Version S)", "16x height (Version T)" };

            option2.PopulateOptions(Option2);
            option2.SelectedIndex = 0;
        }
    }
}
