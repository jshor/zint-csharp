using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ZintTest
{
    class Symbology
    {
        public static zint_symbol SymbolStruct;
        public int Symbol
        {
            get
            {
                return SymbolStruct.symbology;
            }
            set
            {
                SymbolStruct.symbology = value;
            }
        }
        public int Height
        {
            get
            {
                return SymbolStruct.height;
            }
            set
            {
                SymbolStruct.height = value;
            }
        }
        public int WhitespaceWidth
        {
            get
            {
                return SymbolStruct.whitespace_width;
            }
            set
            {
                SymbolStruct.whitespace_width = value;
            }
        }
        public int BorderWidth
        {
            get
            {
                return SymbolStruct.border_width;
            }
            set
            {
                SymbolStruct.border_width = value;
            }
        }
        public int OutputOptions
        {
            get
            {
                return SymbolStruct.output_options;
            }
            set
            {
                SymbolStruct.output_options = value;
            }
        }
        public int Option1
        {
            get
            {
                return SymbolStruct.option_1;
            }
            set
            {
                SymbolStruct.option_1 = value;
            }
        }
        public int ShowHrt
        {
            get
            {
                return SymbolStruct.show_hrt;
            }
            set
            {
                SymbolStruct.show_hrt = value;
            }
        }
        public int InputMode
        {
            get
            {
                return SymbolStruct.input_mode;
            }
            set
            {
                SymbolStruct.input_mode = value;
            }
        }
        public int Rows
        {
            get
            {
                return SymbolStruct.rows;
            }
            set
            {
                SymbolStruct.rows = value;
            }
        }
        public int Width
        {
            get
            {
                return SymbolStruct.width;
            }
            set
            {
                SymbolStruct.width = value;
            }
        }
        public String ForegroundColor
        {
            get
            {
                return SymbolStruct.fgcolour;
            }
            set
            {
                SymbolStruct.fgcolour = value;
            }
        }
        public String BackgroundColor
        {
            get
            {
                return SymbolStruct.bgcolour;
            }
            set
            {
                SymbolStruct.bgcolour = value;
            }
        }
        public String Outfile
        {
            get
            {
                return SymbolStruct.outfile;
            }
            set
            {
                SymbolStruct.outfile = value;
            }
        }
        public String Text
        {
            get
            {
                return SymbolStruct.text;
            }
            set
            {
                SymbolStruct.text = value;
            }
        }
        public String Primary
        {
            get
            {
                return SymbolStruct.primary;
            }
            set
            {
                SymbolStruct.primary = value;
            }
        }
        public float Scale
        {
            get
            {
                return SymbolStruct.scale;
            }
            set
            {
                SymbolStruct.scale = value;
            }
        }








        public int[] RowHeight
        {
            get
            {
                return SymbolStruct.row_height;
            }
        }
        public string Error
        {
            get
            {
                return SymbolStruct.errtxt;
            }
        }
        public int BitmapHeight
        {
            get
            {
                return SymbolStruct.bitmap_height;
            }
        }
        public int BitmapWidth
        {
            get
            {
                return SymbolStruct.bitmap_width;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct zint_symbol
        {
            //public SymbologyTypes symbology;
            public int symbology;
            public int height;
            public int whitespace_width;
            public int border_width;

            //public OutputOptions output_options;
            public int output_options;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
            public string fgcolour;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
            public string bgcolour;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string outfile;

            public float scale;
            public int option_1;
            public int option_2;
            public int option_3;
            public int show_hrt;

            //public EncodingMode input_mode;
            public int input_mode;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string text;

            public int rows;
            public int width;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string primary;

            [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U1, SizeConst = 25454)]
            public byte[] encoded_data;

            [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.I4, SizeConst = 178)]
            public int[] row_height;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string errtxt;

            public byte[] bitmap;

            public int bitmap_width;
            public int bitmap_height;
            public IntPtr rendered;
        }

        [DllImport("zint.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ZBarcode_Create")]
        public extern static IntPtr Create();

        [DllImport("zint.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ZBarcode_Encode_and_Print")]
        public extern static int EncodeAndPrint(
         ref zint_symbol symbol,
         string input,
         int length,
         int rotate_angle);

        [DllImport("zint.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ZBarcode_Encode_and_Buffer")]
        public extern static int EncodeAndBuffer(
         ref zint_symbol symbol,
         string input,
         int length,
         int rotate_angle);

        static Symbology()
        {
            SymbolStruct = (zint_symbol)

            // generate managed counterpart of struct
            Marshal.PtrToStructure(Create(), typeof(zint_symbol));
        }

        public void CreateSymbology(string outfile, string input, int length, int rotateAngle)
        {
            this.Outfile = outfile;
            EncodeAndPrint(ref SymbolStruct, input, input.Length, 0);

            if (SymbolStruct.errtxt != "")
                Console.WriteLine("Errors: " + SymbolStruct.errtxt);
        }
    }
}
