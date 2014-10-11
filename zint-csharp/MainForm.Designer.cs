namespace ZintWrapper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.symbologyImage = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.options1 = new ZintWrapper.Symbologies.Options();
            ((System.ComponentModel.ISupportInitialize)(this.symbologyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // symbologyImage
            // 
            this.symbologyImage.BackColor = System.Drawing.Color.White;
            this.symbologyImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.symbologyImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.symbologyImage.InitialImage = null;
            this.symbologyImage.Location = new System.Drawing.Point(12, 36);
            this.symbologyImage.Name = "symbologyImage";
            this.symbologyImage.Size = new System.Drawing.Size(261, 210);
            this.symbologyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.symbologyImage.TabIndex = 1;
            this.symbologyImage.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select barcode...",
            "Aztec Code (ISO 24778)",
            "Aztec Runes",
            "European Article Number (EAN)",
            "Code 128 (ISO 15417)",
            "Code 16k",
            "Code 39 (ISO 16388)",
            "Code 39 Extended",
            "Code 49",
            "Code One",
            "Channel Code",
            "Data Matrix (ISO 16022)",
            "Grid Matrix",
            "Maxicode (ISO 16023)",
            "MicroPDF (ISO 24728)",
            "Micro QR Code",
            "QR Code (ISO 18004)"});
            this.comboBox1.Location = new System.Drawing.Point(12, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // options1
            // 
            this.options1.Location = new System.Drawing.Point(279, 6);
            this.options1.Name = "options1";
            this.options1.Size = new System.Drawing.Size(434, 273);
            this.options1.TabIndex = 8;
            this.options1.OptionsChanged += new System.EventHandler(this.options_OptionsChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 318);
            this.Controls.Add(this.options1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.symbologyImage);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.symbologyImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox symbologyImage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Symbologies.Options options1;
    }
}

