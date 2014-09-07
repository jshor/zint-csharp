using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;

namespace ZintTest
{
    class ZBarcode
    {
        [DllImport("zint.dll", EntryPoint = "ZBarcode_Create", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr Create();

        [DllImport("zint.dll", EntryPoint = "ZBarcode_Encode_and_Buffer", CallingConvention = CallingConvention.Cdecl)]
        public extern static int EncodeAndBuffer(
         ref zint_symbol symbol,
         string input,
         int length,
         int rotate_angle);

        [DllImport("zint.dll", EntryPoint = "ZBarcode_Encode_and_Print", CallingConvention = CallingConvention.Cdecl)]
        public extern static int EncodeAndPrint(
         ref zint_symbol symbol,
         string input,
         int length,
         int rotate_angle);

        [DllImport("zint.dll", EntryPoint = "ZBarcode_Delete", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Delete(ref zint_symbol symbol);

        [DllImport("zint.dll", EntryPoint = "ZBarcode_Clear", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Clear(ref zint_symbol symbol);
    }
}
