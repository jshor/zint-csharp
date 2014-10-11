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

        private void barcodeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            symbology = new Symbology();

            if (barcodeList.GetSelectedBarcode() != BarcodeTypes.NONE)
                options1.ChangeSymbology(barcodeList.GetSelectedBarcode());

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
            // these symbologies require special options tabs
            BarcodeTypes[] symbologyValuesList = new BarcodeTypes[] {
                BarcodeTypes.AZTEC, BarcodeTypes.AZRUNE, BarcodeTypes.CHANNEL, BarcodeTypes.CODE128, BarcodeTypes.CODE16K, BarcodeTypes.CODE39, BarcodeTypes.EXCODE39,
                BarcodeTypes.CODE49, BarcodeTypes.CODEONE, BarcodeTypes.DATAMATRIX, BarcodeTypes.EANX, BarcodeTypes.GRIDMATRIX, BarcodeTypes.MAXICODE,
                BarcodeTypes.MICROPDF417,  BarcodeTypes.MICROQR, BarcodeTypes.QRCODE
            };

            String[] symbologyList = new String[] {"Aztec Code (ISO 24778)", "Aztec Runes", "Channel Code", "Code 128 (ISO 15417)", "Code 16k", "Code 39 (ISO 16388)",
                "Code 39 Extended", "Code 49", "Code One", "Data Matrix (ISO 16022)", "European Article Number (EAN)", "Grid Matrix", "Maxicode (ISO 16023)",
                "MicroPDF (ISO 24728)", "Micro QR Code", "QR Code (ISO 18004)"
            };

            barcodeList.PopulateOptions(symbologyValuesList, symbologyList);
        }
    }
}
