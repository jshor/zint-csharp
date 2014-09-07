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

namespace ZintTest
{
    public class Symbology
    {
        public static zint_symbol SymbolStruct;

        #region Getters and setters

        public BarcodeTypes Symbol;
        public int Height;
        public int WhitespaceWidth;
        public int BorderWidth;
        public int OutputOptions;
        public int Option1;
        public int Option2;
        public int Option3;
        public int ShowHrt;
        public int InputMode;
        public int Rows;
        public int Width;
        public String ForegroundColor;
        public String BackgroundColor;
        public String Outfile;
        public String Text;
        public String Primary;
        public float Scale;

        #endregion

        #region Read-only Getters
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
                Marshal.PtrToStructure(ZintLib.Create(), typeof(zint_symbol));
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
                SymbolStruct = (zint_symbol)

                // generate managed counterpart of struct
                Marshal.PtrToStructure(ZintLib.Create(), typeof(zint_symbol));

                SymbolStruct = SetStructVariables(SymbolStruct);

                if (ZintLib.EncodeAndBuffer(ref SymbolStruct, str, str.Length, 0) == 0)
                {
                    // copy generated members to class
                    GetStructVariables(SymbolStruct);

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

        public zint_symbol SetStructVariables(zint_symbol newStruct)
        {
            // copy the member settings from the old struct to the new one
            // though this may seem inefficient, this is necessary to avoid memory overconsumption
            // from the bitmap pointer
            newStruct.symbology = this.Symbol;
            newStruct.height = this.Height;
            newStruct.whitespace_width = this.WhitespaceWidth;
            newStruct.border_width = this.BorderWidth;
            newStruct.output_options = this.OutputOptions;
            newStruct.option_1 = this.Option1;
            newStruct.option_2 = this.Option2;
            newStruct.option_3 = this.Option3;
            newStruct.show_hrt = this.ShowHrt;
            newStruct.input_mode = this.InputMode;
            newStruct.rows = this.Rows;
            newStruct.width = this.Width;
            newStruct.fgcolour = this.ForegroundColor;
            newStruct.bgcolour = this.BackgroundColor;
            newStruct.outfile = this.Outfile;
            newStruct.text = this.Text;
            newStruct.primary = this.Primary;
            newStruct.scale = this.Scale;

            return newStruct;
        }
        public void GetStructVariables(zint_symbol newStruct)
        {
            // copy the member settings from the old struct to the new one
            // though this may seem inefficient, this is necessary to avoid memory overconsumption
            // from the bitmap pointer
            this.Height = newStruct.height;
            this.WhitespaceWidth = newStruct.whitespace_width;
            this.BorderWidth = newStruct.border_width;
            this.OutputOptions = newStruct.output_options;
            this.Option1 = newStruct.option_1;
            this.Option2 = newStruct.option_2;
            this.Option3 = newStruct.option_3;
            this.ShowHrt = newStruct.show_hrt;
            this.InputMode = newStruct.input_mode;
            this.Rows = newStruct.rows;
            this.Width = newStruct.width;
            this.ForegroundColor = newStruct.fgcolour;
            this.BackgroundColor = newStruct.bgcolour;
            this.Outfile = newStruct.outfile;
            this.Text = newStruct.text;
            this.Primary = newStruct.primary;
            this.Scale = newStruct.scale;
        }
    }
}

