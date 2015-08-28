namespace zintcsharp
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.barcodeList = new zintcsharp.Symbologies.OptionBox();
            this.options1 = new zintcsharp.Symbologies.Options();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.symbologyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // symbologyImage
            // 
            this.symbologyImage.BackColor = System.Drawing.Color.White;
            this.symbologyImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.symbologyImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.symbologyImage.InitialImage = null;
            this.symbologyImage.Location = new System.Drawing.Point(9, 36);
            this.symbologyImage.Name = "symbologyImage";
            this.symbologyImage.Size = new System.Drawing.Size(281, 239);
            this.symbologyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.symbologyImage.TabIndex = 1;
            this.symbologyImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(577, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // barcodeList
            // 
            this.barcodeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.barcodeList.FormattingEnabled = true;
            this.barcodeList.Location = new System.Drawing.Point(9, 9);
            this.barcodeList.Name = "barcodeList";
            this.barcodeList.Size = new System.Drawing.Size(281, 21);
            this.barcodeList.TabIndex = 10;
            this.barcodeList.SelectedIndexChanged += new System.EventHandler(this.barcodeList_SelectedIndexChanged);
            // 
            // options1
            // 
            this.options1.Location = new System.Drawing.Point(299, 6);
            this.options1.Name = "options1";
            this.options1.Size = new System.Drawing.Size(434, 273);
            this.options1.TabIndex = 8;
            this.options1.OptionsChanged += new System.EventHandler(this.options_OptionsChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "About";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 318);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.barcodeList);
            this.Controls.Add(this.options1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.symbologyImage);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.symbologyImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox symbologyImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Symbologies.Options options1;
        private Symbologies.OptionBox barcodeList;
        private System.Windows.Forms.Button button3;
    }
}

