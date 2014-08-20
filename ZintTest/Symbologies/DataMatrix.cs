using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZintTest.Symbologies
{
    class DataMatrix
    {
        public DataMatrix() { 
            // sizes
            int[] Option2Values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            String[] Option2 = new String[] { "10 x 10", "12 x 12", "14 x 14", "16 x 16", "18 x 18", "20 x 20", "22 x 22", 
                "24 x 24", "26 x 26", "32 x 32", "36 x 36", "40 x 40", "44 x 44", "48 x 48", "52 x 52", "64 x 64", "72 x 72", 
                "80 x 80", "88 x 88", "96 x 96", "104 x 104", "120 x 120", "132 x 132", "144 x 144", "8 x 18", "8 x 32", 
                "12 x 26", "12 x 36", "16 x 36", "16 x 48" };

            // checkbox with value of "DM_SQUARE"
            int[] Option3Values = new int[] { 3 };
            String[] Option3 = new String[] { "DM_SQUARE" };
        }
    }
}
