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
    public partial class Ean : UserControl, IBarcode
    {
        public event EventHandler OptionsChanged;
        private Symbology symbology;
        public Ean(Symbology symb)
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
    }
}
