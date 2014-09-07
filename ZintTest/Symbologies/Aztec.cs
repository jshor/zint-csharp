using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZintTest.Symbologies
{
    public partial class Aztec : UserControl, IBarcode
    {
        public event EventHandler OptionsChanged;
        private Symbology symbology;

        public Aztec(Symbology symb)
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
            // minimum error correction
            String[] Option1 = new String[] { "10% + 3 words", "23% + 3 words", "36% + 3 words", "50% + 3 words" };

            // size
            String[] Option2 = new String[]{"15 x 15 Compact", "19 x 19 Compact", "23 x 23 Compact", "27 x 27 Compact", 
                   "19 x 19", "23 x 23", "27 x 27", "31 x 31", "37 x 37", "41 x 41", "45 x 45",
                   "49 x 49", "53 x 53", "57 x 57", "61 x 61", "67 x 67", "71 x 71", "75 x 75",
                   "79 x 79", "83 x 83", "87 x 87", "91 x 91", "95 x 95", "101 x 101", "105 x 105",
                   "109 x 109", "113 x 113", "117 x 117", "121 x 121", "125 x 125", "131 x 131",
                   "135 x 135", "139 x 139", "143 x 143", "147 x 147", "151 x 151"};

            option1.PopulateOptions(Option1);
            option2.PopulateOptions(Option2);

            // default values
            symbology.Symbol = BarcodeTypes.AZTEC;
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
        private void encodingRadioButton_OptionsChanged(object sender, EventArgs e)
        {
            if (gs1DataMode.Checked)
            {
                symbology.Symbol = BarcodeTypes.AZTEC;
                symbology.InputMode = 2;
            }
            else if (hibcMode.Checked)
            {
                symbology.Symbol = BarcodeTypes.HIBC_AZTEC;
                symbology.InputMode = 0;
            }
            else
            {
                symbology.Symbol = BarcodeTypes.AZTEC;
                symbology.InputMode = 0;
            }

            if (this.OptionsChanged != null)
                this.OptionsChanged(new object(), new EventArgs());
        }
    }
}
