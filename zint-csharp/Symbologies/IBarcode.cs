using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zintcsharp.Symbologies
{
    interface IBarcode
    {
        Symbology GetSymbology();
        UserControl GetControl();

        event EventHandler OptionsChanged;
    }
}
