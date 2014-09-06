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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.createBarcode = new System.Windows.Forms.Button();
            this.symbologyImage = new System.Windows.Forms.PictureBox();
            this.symbologyData = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.options1 = new ZintTest.Symbologies.Options();
            ((System.ComponentModel.ISupportInitialize)(this.symbologyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // createBarcode
            // 
            this.createBarcode.Location = new System.Drawing.Point(197, 252);
            this.createBarcode.Name = "createBarcode";
            this.createBarcode.Size = new System.Drawing.Size(76, 23);
            this.createBarcode.TabIndex = 0;
            this.createBarcode.Text = "Create";
            this.createBarcode.UseVisualStyleBackColor = true;
            this.createBarcode.Click += new System.EventHandler(this.createBarcode_Click);
            // 
            // symbologyImage
            // 
            this.symbologyImage.BackColor = System.Drawing.Color.White;
            this.symbologyImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("symbologyImage.BackgroundImage")));
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
            // symbologyData
            // 
            this.symbologyData.Location = new System.Drawing.Point(12, 254);
            this.symbologyData.Name = "symbologyData";
            this.symbologyData.Size = new System.Drawing.Size(179, 20);
            this.symbologyData.TabIndex = 2;
            this.symbologyData.TextChanged += new System.EventHandler(this.options_OptionsChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select barcode...",
            "Aztec Code (ISO 24778)"});
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
            this.options1.Location = new System.Drawing.Point(279, 5);
            this.options1.Name = "options1";
            this.options1.Size = new System.Drawing.Size(435, 276);
            this.options1.TabIndex = 6;
            this.options1.OptionsChanged += new System.EventHandler(this.options_OptionsChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.options1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.symbologyData);
            this.Controls.Add(this.symbologyImage);
            this.Controls.Add(this.createBarcode);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.symbologyImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBarcode;
        private System.Windows.Forms.PictureBox symbologyImage;
        private System.Windows.Forms.TextBox symbologyData;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private Symbologies.Options options1;
        private System.Windows.Forms.Button button2;
    }
}

