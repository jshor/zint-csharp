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
    public class Symbology
    {
        public static zint_symbol SymbolStruct;

        #region getters and setters
        #region Symbol
        public BarcodeTypes Symbol
        {
            get
            {
                return (BarcodeTypes)SymbolStruct.symbology;
            }
            set
            {
                SymbolStruct.symbology = (Int32)value;
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

        #region Rotation
        public int Rotation;
        #endregion
        #endregion

        #region read-only getters
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
        #endregion

        static Symbology()
        {
            try { 
                SymbolStruct = (zint_symbol)

                // generate managed counterpart of struct
                Marshal.PtrToStructure(ZBarcode.Create(), typeof(zint_symbol));
            }
            catch (Exception e)
            {
                // dll not found, application aborted
            }
        }

        public Bitmap Render(String str)
        {
            Bitmap bitmap = null;

            try {
                if (ZBarcode.EncodeAndBuffer(ref SymbolStruct, str, str.Length, this.Rotation) == 0)
                {
                    // no error returned, create barcode preview
                    bitmap = new Bitmap(SymbolStruct.bitmap_width, SymbolStruct.bitmap_height);

                    byte[] bitmapBytes = new byte[SymbolStruct.bitmap_height * SymbolStruct.bitmap_width * 3];
                    Marshal.Copy(SymbolStruct.bitmap, bitmapBytes, 0, bitmapBytes.Length);

                    // write image pixel-by-pixel
                    int row, column, i = 0;
                    int red, blue, green;

                    for (row = 0; row < SymbolStruct.bitmap_height; row++)
                    {
                        for (column = 0; column < SymbolStruct.bitmap_width; column++)
                        {
                            red = bitmapBytes[i];
                            green = bitmapBytes[i + 1];
                            blue = bitmapBytes[i + 2];

                            bitmap.SetPixel(column, row, Color.FromArgb(red, green, blue));
                            i += 3;
                        }
                    }

                    // reset bitmap
                    ZBarcode.Clear(ref SymbolStruct);
                }
                else
                {
                    if (SymbolStruct.errtxt == null)
                        SymbolStruct.errtxt = "error!";

                    bitmap = WriteErrorImage(SymbolStruct.errtxt);
                }
            }
            catch (Exception e)
            {
                // dll not found, application aborted
                bitmap = WriteErrorImage("Fatal error: a DLL is missing");
            }

            return bitmap;
        }

        public Bitmap WriteErrorImage(String error)
        {
            Bitmap bitmap = new Bitmap(200, 100);
            RectangleF rectf = new RectangleF(0, 0, 200, 200);

            Graphics g = Graphics.FromImage(bitmap);
            g.DrawString(SymbolStruct.errtxt, new Font(SystemFonts.DefaultFont.ToString(), 12), Brushes.Black, rectf);
            g.Flush();

            return bitmap;
        }
    }
}

