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
    public partial class GridMatrix : UserControl, IBarcode
    {
        public event EventHandler OptionsChanged;
        private Symbology symbology;

        public GridMatrix(Symbology symb)
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

        private void GridMatrix_Load(object sender, EventArgs e)
        {
            // size
            int[] Option2Values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            String[] Option2 = new String[] { "18 x 18", "30 x 30", "42 x 42", "54 x 54", "66 x 66", "78 x 78", "90 x 90", "102 x 102", "114 x 114", "126 x 126", "138 x 138", "150 x 150", "162 x 162", };

            // ecc
            int[] Option1Values = new int[] { 1, 2, 3, 4, 5 };
            String[] Option1 = new String[] { "~10%", "~20%", "~30%", "~40%", "~50%" };

            option1.PopulateOptions(Option1);
            option2.PopulateOptions(Option2);
            option1.SelectedIndex = 0;
            option2.SelectedIndex = 0;

            // default values
            symbology.Symbol = BarcodeTypes.DATAMATRIX;
            symbology.InputMode = 0;
            symbology.Option1 = 0;
            symbology.Option2 = 0;
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

        private void option_SelectedIndexChanged(object sender, EventArgs e)
        {
            symbology.Option1 = option1.GetSelectedItemValue();
            symbology.Option2 = option2.GetSelectedItemValue();

            Console.WriteLine("Selection changed...");

            if (this.OptionsChanged != null)
                this.OptionsChanged(new object(), new EventArgs());
        }
    }
}
