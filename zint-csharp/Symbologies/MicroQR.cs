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
    public partial class MicroQR : UserControl, IBarcode
    {
        public event EventHandler OptionsChanged;
        private Symbology symbology;

        public MicroQR(Symbology symb)
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

        private void MicroQR_Load(object sender, EventArgs e)
        {
            // minimum error correction
            int[] Option1Values = new int[] { 1, 2, 3 };
            String[] Option1 = new String[] { "~20% (Level L)", "~37% (Level H)", "~55% (Level Q)" };

            // size
            String[] Option2 = new String[] { "11 x 11 (Version M1)", "13 x 13 (Version M2)", "15 x 15 (Version M3)", "17 x 17 (Version M4)" };

            option1.PopulateOptions(Option1Values, Option1);
            option2.PopulateOptions(Option2);

            // default values
            symbology.Symbol = BarcodeTypes.MICROQR;
            symbology.InputMode = 0;
            symbology.Option1 = 0;
            symbology.Option2 = 0;
            option1.Enabled = false;
            option2.Enabled = false;
        }

        private void optionElement_OptionsChanged(object sender, EventArgs e)
        {
            if (option1Selected.Checked)
            {
                symbology.Option1 = option1.GetSelectedItemValue();
                symbology.Option2 = 0;
                option1.Enabled = true;
                option2.Enabled = false;
            }
            else if (option2Selected.Checked)
            {
                symbology.Option2 = option2.GetSelectedItemValue();
                symbology.Option1 = 0;
                option1.Enabled = false;
                option2.Enabled = true;
            }
            else
            {
                symbology.Option1 = 0;
                symbology.Option2 = 0;
                option1.Enabled = false;
                option2.Enabled = false;
            }
                

            if (this.OptionsChanged != null)
                this.OptionsChanged(new object(), new EventArgs());
        }
    }
}
