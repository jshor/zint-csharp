using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace ZintTest
{
    public class Symbology
    {
        public static zint_symbol SymbolStruct;

        /* getters and setters */
        #region Symbol
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
        #endregion

        #region Height
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
        #endregion

        #region WhitespaceWidth
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
        #endregion

        #region BorderWidth
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
        #endregion

        #region OutputOptions
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
        #endregion

        #region Option1
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
        #endregion

        #region Option2
        public int Option2
        {
            get
            {
                return SymbolStruct.option_2;
            }
            set
            {
                SymbolStruct.option_2 = value;
            }
        }
        #endregion

        #region Option3
        public int Option3
        {
            get
            {
                return SymbolStruct.option_3;
            }
            set
            {
                SymbolStruct.option_3 = value;
            }
        }
        #endregion

        #region ShowHrt
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
        #endregion

        #region InputMode
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
        #endregion

        #region Rows
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
        #endregion

        #region Width
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
        #endregion

        #region ForegroundColor
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
        #endregion

        #region BackgroundColor
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
        #endregion

        #region Outfile
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
        #endregion

        #region Text
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
        #endregion

        #region Primary
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
        #endregion

        #region Scale
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
        #endregion

        /* read-only getters */
        #region RowHeight
        public int[] RowHeight
        {
            get
            {
                return SymbolStruct.row_height;
            }
        }
        #endregion

        #region Error
        public string Error
        {
            get
            {
                return SymbolStruct.errtxt;
            }
        }
        #endregion

        #region BitmapHeight
        public int BitmapHeight
        {
            get
            {
                return SymbolStruct.bitmap_height;
            }
        }
        #endregion

        #region BitmapWidth
        public int BitmapWidth
        {
            get
            {
                return SymbolStruct.bitmap_width;
            }
        }
        #endregion

        /* import from DLL */
        #region zint_symbol Struct
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
        #endregion
        
        #region Imported methods

        [DllImport("zint.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ZBarcode_Create")]
        public extern static IntPtr Create();

        [DllImport("zint.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ZBarcode_Encode_and_Print")]
        public extern static int EncodeAndPrint(
         ref zint_symbol symbol,
         string input,
         int length,
         int rotate_angle);
        #endregion

        static Symbology()
        {
            try { 
                SymbolStruct = (zint_symbol)

                // generate managed counterpart of struct
                Marshal.PtrToStructure(Create(), typeof(zint_symbol));
            }
            catch (DllNotFoundException e)
            {
                // dll not found, application aborted
            }
        }

        public Bitmap StreamSymbology(string input, int rotateAngle)
        {
            String fileName = System.IO.Path.GetTempPath() + "barcode_" + input + ".png";
            Bitmap symbologyBitmap = null;

            CreateSymbology(fileName, input, input.Length, rotateAngle);

            if (System.IO.File.Exists(fileName)) {
                symbologyBitmap = new Bitmap(fileName);
                System.IO.File.Delete(fileName);
            }

            return symbologyBitmap;
        }

        public void CreateSymbology(string outfile, string input, int length, int rotateAngle)
        {
            try { 
                this.Outfile = outfile;
                EncodeAndPrint(ref SymbolStruct, input, input.Length, 0);

                if (SymbolStruct.errtxt != "")
                    Console.WriteLine("Errors: " + SymbolStruct.errtxt);
            }
            catch (DllNotFoundException e)
            {
                // dll not found, application aborted
            }
        }
    }
}
