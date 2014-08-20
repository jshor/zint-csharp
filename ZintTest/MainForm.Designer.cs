namespace ZintTest
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
            this.createBarcode = new System.Windows.Forms.Button();
            this.symbologyImage = new System.Windows.Forms.PictureBox();
            this.symbologyData = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.options1 = new ZintTest.Symbologies.Options();
            ((System.ComponentModel.ISupportInitialize)(this.symbologyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // createBarcode
            // 
            this.createBarcode.Location = new System.Drawing.Point(197, 171);
            this.createBarcode.Name = "createBarcode";
            this.createBarcode.Size = new System.Drawing.Size(75, 23);
            this.createBarcode.TabIndex = 0;
            this.createBarcode.Text = "Create";
            this.createBarcode.UseVisualStyleBackColor = true;
            this.createBarcode.Click += new System.EventHandler(this.createBarcode_Click);
            // 
            // symbologyImage
            // 
            this.symbologyImage.Location = new System.Drawing.Point(12, 12);
            this.symbologyImage.Name = "symbologyImage";
            this.symbologyImage.Size = new System.Drawing.Size(260, 151);
            this.symbologyImage.TabIndex = 1;
            this.symbologyImage.TabStop = false;
            // 
            // symbologyData
            // 
            this.symbologyData.Location = new System.Drawing.Point(12, 172);
            this.symbologyData.Name = "symbologyData";
            this.symbologyData.Size = new System.Drawing.Size(179, 20);
            this.symbologyData.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select barcode...",
            "Aztec Code (ISO 24778)"});
            this.comboBox1.Location = new System.Drawing.Point(332, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // options1
            // 
            this.options1.Location = new System.Drawing.Point(305, 189);
            this.options1.Name = "options1";
            this.options1.Size = new System.Drawing.Size(546, 264);
            this.options1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 465);
            this.Controls.Add(this.options1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.symbologyData);
            this.Controls.Add(this.symbologyImage);
            this.Controls.Add(this.createBarcode);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.symbologyImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBarcode;
        private System.Windows.Forms.PictureBox symbologyImage;
        private System.Windows.Forms.TextBox symbologyData;
        private System.Windows.Forms.ComboBox comboBox1;
        private Symbologies.Options options1;
    }
}

