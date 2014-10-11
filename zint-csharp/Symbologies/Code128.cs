﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZintWrapper.Symbologies
{
    public partial class Code128 : UserControl, IBarcode
    {
        public event EventHandler OptionsChanged;
        private Symbology symbology;
        public Code128(Symbology symb)
        {
            InitializeComponent();

            this.symbology = symb;
          //  this.symbology.Option1 = 0;
         //   this.symbology.Option2 = 0;
          //  this.symbology.Option3 = 0;
          //  this.symbology.InputMode = 0;
        }

        public Symbology GetSymbology()
        {
            return this.symbology;
        }

        public UserControl GetControl()
        {
            return this;
        }

        private void Code128_Load(object sender, EventArgs e)
        {
            this.symbology.Symbol = BarcodeTypes.EANX_CC;
            this.symbology.Option1 = 1;
            this.symbology.Primary = "331234567890";
           // this.symbology.InputMode = 2;
        }

    }
}
