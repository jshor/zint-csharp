namespace ZintTest.Symbologies
{
    partial class Options
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.generalTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.heightLabel = new System.Windows.Forms.Label();
            this.borderWidthLabel = new System.Windows.Forms.Label();
            this.printingScaleLabel = new System.Windows.Forms.Label();
            this.whitespaceLabel = new System.Windows.Forms.Label();
            this.borderTypeLabel = new System.Windows.Forms.Label();
            this.borderWidth = new System.Windows.Forms.NumericUpDown();
            this.whitespace = new System.Windows.Forms.NumericUpDown();
            this.printingScale = new System.Windows.Forms.NumericUpDown();
            this.borderType = new System.Windows.Forms.ComboBox();
            this.backgroundColorLabel = new System.Windows.Forms.Label();
            this.foregroundColorLabel = new System.Windows.Forms.Label();
            this.backgroundColor = new System.Windows.Forms.Button();
            this.foregroundColor = new System.Windows.Forms.Button();
            this.generalTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitespace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingScale)).BeginInit();
            this.SuspendLayout();
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.tabPage1);
            this.generalTab.Controls.Add(this.tabPage2);
            this.generalTab.Location = new System.Drawing.Point(0, 3);
            this.generalTab.Name = "generalTab";
            this.generalTab.SelectedIndex = 0;
            this.generalTab.Size = new System.Drawing.Size(431, 267);
            this.generalTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.foregroundColor);
            this.tabPage1.Controls.Add(this.backgroundColor);
            this.tabPage1.Controls.Add(this.foregroundColorLabel);
            this.tabPage1.Controls.Add(this.backgroundColorLabel);
            this.tabPage1.Controls.Add(this.borderType);
            this.tabPage1.Controls.Add(this.printingScale);
            this.tabPage1.Controls.Add(this.whitespace);
            this.tabPage1.Controls.Add(this.borderWidth);
            this.tabPage1.Controls.Add(this.borderTypeLabel);
            this.tabPage1.Controls.Add(this.whitespaceLabel);
            this.tabPage1.Controls.Add(this.printingScaleLabel);
            this.tabPage1.Controls.Add(this.borderWidthLabel);
            this.tabPage1.Controls.Add(this.heightLabel);
            this.tabPage1.Controls.Add(this.height);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(423, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(423, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(100, 19);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(120, 20);
            this.height.TabIndex = 0;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(16, 21);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Height:";
            // 
            // borderWidthLabel
            // 
            this.borderWidthLabel.AutoSize = true;
            this.borderWidthLabel.Location = new System.Drawing.Point(16, 60);
            this.borderWidthLabel.Name = "borderWidthLabel";
            this.borderWidthLabel.Size = new System.Drawing.Size(72, 13);
            this.borderWidthLabel.TabIndex = 2;
            this.borderWidthLabel.Text = "Border Width:";
            // 
            // printingScaleLabel
            // 
            this.printingScaleLabel.AutoSize = true;
            this.printingScaleLabel.Location = new System.Drawing.Point(16, 142);
            this.printingScaleLabel.Name = "printingScaleLabel";
            this.printingScaleLabel.Size = new System.Drawing.Size(75, 13);
            this.printingScaleLabel.TabIndex = 3;
            this.printingScaleLabel.Text = "Printing Scale:";
            // 
            // whitespaceLabel
            // 
            this.whitespaceLabel.AutoSize = true;
            this.whitespaceLabel.Location = new System.Drawing.Point(16, 100);
            this.whitespaceLabel.Name = "whitespaceLabel";
            this.whitespaceLabel.Size = new System.Drawing.Size(67, 13);
            this.whitespaceLabel.TabIndex = 4;
            this.whitespaceLabel.Text = "Whitespace:";
            // 
            // borderTypeLabel
            // 
            this.borderTypeLabel.AutoSize = true;
            this.borderTypeLabel.Location = new System.Drawing.Point(16, 184);
            this.borderTypeLabel.Name = "borderTypeLabel";
            this.borderTypeLabel.Size = new System.Drawing.Size(68, 13);
            this.borderTypeLabel.TabIndex = 5;
            this.borderTypeLabel.Text = "Border Type:";
            // 
            // borderWidth
            // 
            this.borderWidth.Location = new System.Drawing.Point(99, 58);
            this.borderWidth.Name = "borderWidth";
            this.borderWidth.Size = new System.Drawing.Size(120, 20);
            this.borderWidth.TabIndex = 6;
            // 
            // whitespace
            // 
            this.whitespace.Location = new System.Drawing.Point(100, 98);
            this.whitespace.Name = "whitespace";
            this.whitespace.Size = new System.Drawing.Size(120, 20);
            this.whitespace.TabIndex = 7;
            // 
            // printingScale
            // 
            this.printingScale.Location = new System.Drawing.Point(100, 140);
            this.printingScale.Name = "printingScale";
            this.printingScale.Size = new System.Drawing.Size(120, 20);
            this.printingScale.TabIndex = 8;
            // 
            // borderType
            // 
            this.borderType.FormattingEnabled = true;
            this.borderType.Location = new System.Drawing.Point(100, 181);
            this.borderType.Name = "borderType";
            this.borderType.Size = new System.Drawing.Size(121, 21);
            this.borderType.TabIndex = 9;
            // 
            // backgroundColorLabel
            // 
            this.backgroundColorLabel.AutoSize = true;
            this.backgroundColorLabel.Location = new System.Drawing.Point(256, 21);
            this.backgroundColorLabel.Name = "backgroundColorLabel";
            this.backgroundColorLabel.Size = new System.Drawing.Size(95, 13);
            this.backgroundColorLabel.TabIndex = 10;
            this.backgroundColorLabel.Text = "Background Color:";
            // 
            // foregroundColorLabel
            // 
            this.foregroundColorLabel.AutoSize = true;
            this.foregroundColorLabel.Location = new System.Drawing.Point(256, 60);
            this.foregroundColorLabel.Name = "foregroundColorLabel";
            this.foregroundColorLabel.Size = new System.Drawing.Size(91, 13);
            this.foregroundColorLabel.TabIndex = 11;
            this.foregroundColorLabel.Text = "Foreground Color:";
            // 
            // backgroundColor
            // 
            this.backgroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgroundColor.Location = new System.Drawing.Point(357, 16);
            this.backgroundColor.Name = "backgroundColor";
            this.backgroundColor.Size = new System.Drawing.Size(51, 23);
            this.backgroundColor.TabIndex = 12;
            this.backgroundColor.UseVisualStyleBackColor = false;
            this.backgroundColor.Click += new System.EventHandler(this.backgroundColor_Click);
            // 
            // foregroundColor
            // 
            this.foregroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foregroundColor.Location = new System.Drawing.Point(357, 55);
            this.foregroundColor.Name = "foregroundColor";
            this.foregroundColor.Size = new System.Drawing.Size(51, 23);
            this.foregroundColor.TabIndex = 13;
            this.foregroundColor.UseVisualStyleBackColor = false;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.generalTab);
            this.Name = "Options";
            this.Size = new System.Drawing.Size(434, 273);
            this.generalTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitespace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingScale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl generalTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label foregroundColorLabel;
        private System.Windows.Forms.Label backgroundColorLabel;
        private System.Windows.Forms.ComboBox borderType;
        private System.Windows.Forms.NumericUpDown printingScale;
        private System.Windows.Forms.NumericUpDown whitespace;
        private System.Windows.Forms.NumericUpDown borderWidth;
        private System.Windows.Forms.Label borderTypeLabel;
        private System.Windows.Forms.Label whitespaceLabel;
        private System.Windows.Forms.Label printingScaleLabel;
        private System.Windows.Forms.Label borderWidthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.Button foregroundColor;
        private System.Windows.Forms.Button backgroundColor;
    }
}
