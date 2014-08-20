using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZintTest.Symbologies
{
    class GridMatrix
    {
        public GridMatrix() { 
            // size
            int[] Option2Values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            String[] Option2 = new String[] { "18 x 18", "30 x 30", "42 x 42", "54 x 54", "66 x 66", "78 x 78", "90 x 90", "102 x 102", "114 x 114", "126 x 126", "138 x 138", "150 x 150", "162 x 162", };

            // ecc
            int[] Option1Values = new int[] { 1, 2, 3, 4, 5 };
            String[] Option1 = new String[] { "~10%", "~20%", "~30%", "~40%", "~50%" };
        }
    }
}
