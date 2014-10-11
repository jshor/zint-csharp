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
    public partial class MaxiCode : UserControl, IBarcode
    {
        public event EventHandler OptionsChanged;
        private Symbology symbology;

        public MaxiCode(Symbology symb)
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

        private void MaxiCode_Load(object sender, EventArgs e)
        {
            int[] Option1Values = new int[] { 4, 3, 5, 6 };
            String[] Option1 = new String[] { "Standard Symbol, SEC (Mode 4)", "Structured Carrier Message (Mode 2 or 3)", "Full ECC Symbol (Mode 5)", "Reader Program, SEC (Mode 6)" };

            option1.PopulateOptions(Option1Values, Option1);
            option1.SelectedIndex = 0;

            this.symbology.Symbol = BarcodeTypes.MAXICODE;
        }

        private void optionElement_OptionsChanged(object sender, EventArgs e)
        {
            symbology.Option1 = option1.GetSelectedItemValue();

            if (option1.GetSelectedItemValue() == 3)
            {
                primaryText.Enabled = true;
                symbology.Primary = primaryText.Text;
            }
            else
            {
                primaryText.Enabled = false;
                symbology.Primary = null;
            }

            if (this.OptionsChanged != null)
                this.OptionsChanged(new object(), new EventArgs());
        }
    }
}
