using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZintTest.Symbologies
{
    public class Barcode
    {
        #region Option1
        private int option1;
        public int Option1
        {
            get
            {
                return this.option1;
            }
            set
            {
                this.option1 = value;
            }
        }
        #endregion

        #region Option2
        private int option2;
        public int Option2
        {
            get
            {
                return this.option2;
            }
            set
            {
                this.option2 = value;
            }
        }
        #endregion

        #region Option3
        private int option3;
        public int Option3
        {
            get
            {
                return this.option3;
            }
            set
            {
                this.option3 = value;
            }
        }
        #endregion

        public Barcode()
        {

        }

        public void Render() {

        }
    }
}
