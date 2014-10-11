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
    public partial class ChannelCode : UserControl, IBarcode
    {
        public event EventHandler OptionsChanged;
        private Symbology symbology;
        public ChannelCode(Symbology symb)
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

        private void ChannelCode_Load(object sender, EventArgs e)
        {
            // number of channels
            int[] Option2Values = new int[] { 1, 3, 4, 5, 6, 7, 8 };
            String[] Option2 = new String[] { "Automatic", "3", "4", "5", "6", "7", "8" };

            option2.PopulateOptions(Option2Values, Option2);
            option2.SelectedIndex = 0;

            // default values
            symbology.Symbol = BarcodeTypes.CHANNEL;
            symbology.InputMode = 0;
            symbology.Option1 = 0;
            symbology.Option3 = 0;
        }

        private void option2_OptionsChanged(object sender, EventArgs e)
        {
            symbology.Option2 = option2.GetSelectedItemValue();

            if (this.OptionsChanged != null)
                this.OptionsChanged(new object(), new EventArgs());
        }
    }
}
