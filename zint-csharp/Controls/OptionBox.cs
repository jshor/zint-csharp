﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zintcsharp.Symbologies
{
    public class OptionBox : ComboBox
    {
        private int[] optionValues;
        private BarcodeTypes[] optionBarcodeValues;
        private String[] options;

        public OptionBox()
        {
            base.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void PopulateOptions(int[] optionVals, String[] opts)
        {
            for (int i = 0; i < opts.Length; i++)
            {
                this.Items.Add(opts[i]);
            }

            this.optionValues = optionVals;
            this.options = opts;
            this.SelectedIndex = 0;
        }

        public void PopulateOptions(BarcodeTypes[] optionVals, String[] opts)
        {
            for (int i = 0; i < opts.Length; i++)
            {
                this.Items.Add(opts[i]);
            }

            this.optionBarcodeValues = optionVals;
            this.options = opts;
            this.SelectedIndex = 0;
        }

        public void PopulateOptions(String[] opts)
        {
            // for options with sequential integer values
            int[] optionVals = new int[opts.Length];

            for (int i = 0; i < optionVals.Length; i++)
            {
                optionVals[i] = i + 1;
            }

            PopulateOptions(optionVals, opts);
        }

        public BarcodeTypes GetSelectedBarcode()
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                if ((String)this.SelectedItem == this.options[i])
                    return optionBarcodeValues[i];
            }

            Console.WriteLine("should not return");

            return BarcodeTypes.NONE;
        }

        public int GetSelectedItemValue()
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                if ((String)this.SelectedItem == this.options[i])
                    return optionValues[i];
            }

            return 0;
        }
    }
}
