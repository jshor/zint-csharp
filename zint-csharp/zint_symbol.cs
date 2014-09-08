using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace ZintWrapper
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct zint_symbol
    {
        public int symbology;

        public int height;
        public int whitespace_width;
        public int border_width;

        public int output_options;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
        public string fgcolour;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
        public string bgcolour;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string outfile;

        public float scale;
        public int option_1;
        public int option_2;
        public int option_3;
        public int show_hrt;

        public int input_mode;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string text;

        public int rows;
        public int width;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string primary;

        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U1, SizeConst = 31684)]
        public byte[] encoded_data;

        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.I4, SizeConst = 178)]
        public int[] row_height;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
        public string errtxt;

        public IntPtr bitmap;

        public int bitmap_width;
        public int bitmap_height;
        public IntPtr rendered;
    }
}
