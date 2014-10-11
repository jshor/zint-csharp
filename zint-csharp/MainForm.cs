using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.MemoryMappedFiles;

namespace ZintWrapper
{
    public partial class MainForm : Form
    {
        public Symbology symbology;
        public MainForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            symbology = new Symbology();

            // these symbologies require special options tabs
            switch ((String)comboBox1.SelectedItem)
            {
                case "Aztec Code (ISO 24778)":
                    options1.ChangeSymbology(BarcodeTypes.AZTEC);
                    break;
                case "Aztec Runes":
                    options1.ChangeSymbology(BarcodeTypes.AZRUNE);
                    break;
                case "Channel Code":
                    options1.ChangeSymbology(BarcodeTypes.CHANNEL);
                    break;
                case "Data Matrix (ISO 16022)":
                    options1.ChangeSymbology(BarcodeTypes.DATAMATRIX);
                    break;
                case "European Article Number (EAN)":
                    options1.ChangeSymbology(BarcodeTypes.EANX);
                    break;
                case "Grid Matrix":
                    options1.ChangeSymbology(BarcodeTypes.GRIDMATRIX);
                    break;
                case "Maxicode (ISO 16023)":
                    options1.ChangeSymbology(BarcodeTypes.MAXICODE);
                    break;
                case "MicroPDF (ISO 24728)":
                    options1.ChangeSymbology(BarcodeTypes.MICROPDF417);
                    break;
                case "Micro QR Code":
                    options1.ChangeSymbology(BarcodeTypes.MICROQR);
                    break;
                case "QR Code (ISO 18004)":
                    options1.ChangeSymbology(BarcodeTypes.QRCODE);
                    break;
            }

            this.symbology = options1.symbology;
            options_OptionsChanged(sender, e);
        }

        private void options_OptionsChanged(object sender, EventArgs e)
        {
            if (this.symbology != null)
            {
                try {
                    Image previewImage = symbology.Render((String)options1.DataToEncode);

                    if (previewImage != null)
                    {
                        symbologyImage.BackgroundImage = previewImage;
                    }
                }
                catch (Exception ex)
                {
                    // badness
                    Console.WriteLine("missing");
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            symbologyImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
