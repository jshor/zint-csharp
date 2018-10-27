namespace zintcsharp.Symbologies
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
            this.dataTab = new System.Windows.Forms.TabPage();
            this.add2DComponentGroup = new System.Windows.Forms.GroupBox();
            this.add2DComponent = new System.Windows.Forms.CheckBox();
            this.componentTypeLabel = new System.Windows.Forms.Label();
            this.secondaryData = new System.Windows.Forms.TextBox();
            this.secondaryDataLabel = new System.Windows.Forms.Label();
            this.componentType = new System.Windows.Forms.ComboBox();
            this.primaryDataLabel = new System.Windows.Forms.Label();
            this.primaryData = new System.Windows.Forms.TextBox();
            this.appearanceTab = new System.Windows.Forms.TabPage();
            this.rotationLabel = new System.Windows.Forms.Label();
            this.rotation = new System.Windows.Forms.NumericUpDown();
            this.foregroundColor = new System.Windows.Forms.Button();
            this.backgroundColor = new System.Windows.Forms.Button();
            this.foregroundColorLabel = new System.Windows.Forms.Label();
            this.backgroundColorLabel = new System.Windows.Forms.Label();
            this.borderType = new System.Windows.Forms.ComboBox();
            this.printingScale = new System.Windows.Forms.NumericUpDown();
            this.whitespace = new System.Windows.Forms.NumericUpDown();
            this.borderWidth = new System.Windows.Forms.NumericUpDown();
            this.borderTypeLabel = new System.Windows.Forms.Label();
            this.whitespaceLabel = new System.Windows.Forms.Label();
            this.printingScaleLabel = new System.Windows.Forms.Label();
            this.borderWidthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.generalTab.SuspendLayout();
            this.dataTab.SuspendLayout();
            this.add2DComponentGroup.SuspendLayout();
            this.appearanceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitespace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.SuspendLayout();
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.dataTab);
            this.generalTab.Controls.Add(this.appearanceTab);
            this.generalTab.Location = new System.Drawing.Point(0, 3);
            this.generalTab.Name = "generalTab";
            this.generalTab.SelectedIndex = 0;
            this.generalTab.Size = new System.Drawing.Size(435, 267);
            this.generalTab.TabIndex = 0;
            // 
            // dataTab
            // 
            this.dataTab.Controls.Add(this.add2DComponentGroup);
            this.dataTab.Controls.Add(this.primaryDataLabel);
            this.dataTab.Controls.Add(this.primaryData);
            this.dataTab.Location = new System.Drawing.Point(4, 22);
            this.dataTab.Name = "dataTab";
            this.dataTab.Padding = new System.Windows.Forms.Padding(3);
            this.dataTab.Size = new System.Drawing.Size(427, 241);
            this.dataTab.TabIndex = 1;
            this.dataTab.Text = "General";
            this.dataTab.UseVisualStyleBackColor = true;
            // 
            // add2DComponentGroup
            // 
            this.add2DComponentGroup.Controls.Add(this.add2DComponent);
            this.add2DComponentGroup.Controls.Add(this.componentTypeLabel);
            this.add2DComponentGroup.Controls.Add(this.secondaryData);
            this.add2DComponentGroup.Controls.Add(this.secondaryDataLabel);
            this.add2DComponentGroup.Controls.Add(this.componentType);
            this.add2DComponentGroup.Location = new System.Drawing.Point(6, 84);
            this.add2DComponentGroup.Name = "add2DComponentGroup";
            this.add2DComponentGroup.Size = new System.Drawing.Size(411, 151);
            this.add2DComponentGroup.TabIndex = 7;
            this.add2DComponentGroup.TabStop = false;
            this.add2DComponentGroup.Text = "groupBox1";
            // 
            // add2DComponent
            // 
            this.add2DComponent.AutoSize = true;
            this.add2DComponent.Location = new System.Drawing.Point(16, 40);
            this.add2DComponent.Name = "add2DComponent";
            this.add2DComponent.Size = new System.Drawing.Size(118, 17);
            this.add2DComponent.TabIndex = 2;
            this.add2DComponent.Text = "Add 2D component";
            this.add2DComponent.UseVisualStyleBackColor = true;
            this.add2DComponent.CheckedChanged += new System.EventHandler(this.data_ValueChanged);
            // 
            // componentTypeLabel
            // 
            this.componentTypeLabel.AutoSize = true;
            this.componentTypeLabel.Location = new System.Drawing.Point(274, 33);
            this.componentTypeLabel.Name = "componentTypeLabel";
            this.componentTypeLabel.Size = new System.Drawing.Size(87, 13);
            this.componentTypeLabel.TabIndex = 6;
            this.componentTypeLabel.Text = "Component type:";
            // 
            // secondaryData
            // 
            this.secondaryData.Enabled = false;
            this.secondaryData.Location = new System.Drawing.Point(16, 98);
            this.secondaryData.Name = "secondaryData";
            this.secondaryData.Size = new System.Drawing.Size(382, 20);
            this.secondaryData.TabIndex = 1;
            this.secondaryData.TextChanged += new System.EventHandler(this.data_ValueChanged);
            // 
            // secondaryDataLabel
            // 
            this.secondaryDataLabel.AutoSize = true;
            this.secondaryDataLabel.Location = new System.Drawing.Point(13, 76);
            this.secondaryDataLabel.Name = "secondaryDataLabel";
            this.secondaryDataLabel.Size = new System.Drawing.Size(104, 13);
            this.secondaryDataLabel.TabIndex = 4;
            this.secondaryDataLabel.Text = "2D component data:";
            // 
            // componentType
            // 
            this.componentType.Enabled = false;
            this.componentType.FormattingEnabled = true;
            this.componentType.Items.AddRange(new object[] {
            "Automatic",
            "CC_A",
            "CC_B",
            "CC_C"});
            this.componentType.Location = new System.Drawing.Point(277, 49);
            this.componentType.Name = "componentType";
            this.componentType.Size = new System.Drawing.Size(121, 21);
            this.componentType.TabIndex = 3;
            this.componentType.SelectedIndexChanged += new System.EventHandler(this.data_ValueChanged);
            // 
            // primaryDataLabel
            // 
            this.primaryDataLabel.AutoSize = true;
            this.primaryDataLabel.Location = new System.Drawing.Point(19, 23);
            this.primaryDataLabel.Name = "primaryDataLabel";
            this.primaryDataLabel.Size = new System.Drawing.Size(68, 13);
            this.primaryDataLabel.TabIndex = 5;
            this.primaryDataLabel.Text = "Primary data:";
            // 
            // primaryData
            // 
            this.primaryData.Location = new System.Drawing.Point(22, 43);
            this.primaryData.Name = "primaryData";
            this.primaryData.Size = new System.Drawing.Size(382, 20);
            this.primaryData.TabIndex = 0;
            this.primaryData.TextChanged += new System.EventHandler(this.data_ValueChanged);
            // 
            // appearanceTab
            // 
            this.appearanceTab.Controls.Add(this.rotationLabel);
            this.appearanceTab.Controls.Add(this.rotation);
            this.appearanceTab.Controls.Add(this.foregroundColor);
            this.appearanceTab.Controls.Add(this.backgroundColor);
            this.appearanceTab.Controls.Add(this.foregroundColorLabel);
            this.appearanceTab.Controls.Add(this.backgroundColorLabel);
            this.appearanceTab.Controls.Add(this.borderType);
            this.appearanceTab.Controls.Add(this.printingScale);
            this.appearanceTab.Controls.Add(this.whitespace);
            this.appearanceTab.Controls.Add(this.borderWidth);
            this.appearanceTab.Controls.Add(this.borderTypeLabel);
            this.appearanceTab.Controls.Add(this.whitespaceLabel);
            this.appearanceTab.Controls.Add(this.printingScaleLabel);
            this.appearanceTab.Controls.Add(this.borderWidthLabel);
            this.appearanceTab.Controls.Add(this.heightLabel);
            this.appearanceTab.Controls.Add(this.height);
            this.appearanceTab.Location = new System.Drawing.Point(4, 22);
            this.appearanceTab.Name = "appearanceTab";
            this.appearanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.appearanceTab.Size = new System.Drawing.Size(423, 241);
            this.appearanceTab.TabIndex = 0;
            this.appearanceTab.Text = "Appearance";
            this.appearanceTab.UseVisualStyleBackColor = true;
            // 
            // rotationLabel
            // 
            this.rotationLabel.AutoSize = true;
            this.rotationLabel.Location = new System.Drawing.Point(256, 21);
            this.rotationLabel.Name = "rotationLabel";
            this.rotationLabel.Size = new System.Drawing.Size(50, 13);
            this.rotationLabel.TabIndex = 15;
            this.rotationLabel.Text = "Rotation:";
            // 
            // rotation
            // 
            this.rotation.Location = new System.Drawing.Point(318, 19);
            this.rotation.Name = "rotation";
            this.rotation.Size = new System.Drawing.Size(90, 20);
            this.rotation.TabIndex = 14;
            this.rotation.ValueChanged += new System.EventHandler(this.rotation_ValueChanged);
            // 
            // foregroundColor
            // 
            this.foregroundColor.BackColor = System.Drawing.Color.Black;
            this.foregroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foregroundColor.Location = new System.Drawing.Point(357, 94);
            this.foregroundColor.Name = "foregroundColor";
            this.foregroundColor.Size = new System.Drawing.Size(51, 23);
            this.foregroundColor.TabIndex = 13;
            this.foregroundColor.UseVisualStyleBackColor = false;
            this.foregroundColor.Click += new System.EventHandler(this.foregroundColor_Click);
            // 
            // backgroundColor
            // 
            this.backgroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgroundColor.Location = new System.Drawing.Point(357, 55);
            this.backgroundColor.Name = "backgroundColor";
            this.backgroundColor.Size = new System.Drawing.Size(51, 23);
            this.backgroundColor.TabIndex = 12;
            this.backgroundColor.UseVisualStyleBackColor = false;
            this.backgroundColor.Click += new System.EventHandler(this.backgroundColor_Click);
            // 
            // foregroundColorLabel
            // 
            this.foregroundColorLabel.AutoSize = true;
            this.foregroundColorLabel.Location = new System.Drawing.Point(256, 99);
            this.foregroundColorLabel.Name = "foregroundColorLabel";
            this.foregroundColorLabel.Size = new System.Drawing.Size(91, 13);
            this.foregroundColorLabel.TabIndex = 11;
            this.foregroundColorLabel.Text = "Foreground Color:";
            // 
            // backgroundColorLabel
            // 
            this.backgroundColorLabel.AutoSize = true;
            this.backgroundColorLabel.Location = new System.Drawing.Point(256, 60);
            this.backgroundColorLabel.Name = "backgroundColorLabel";
            this.backgroundColorLabel.Size = new System.Drawing.Size(95, 13);
            this.backgroundColorLabel.TabIndex = 10;
            this.backgroundColorLabel.Text = "Background Color:";
            // 
            // borderType
            // 
            this.borderType.FormattingEnabled = true;
            this.borderType.Location = new System.Drawing.Point(100, 181);
            this.borderType.Name = "borderType";
            this.borderType.Size = new System.Drawing.Size(121, 21);
            this.borderType.TabIndex = 9;
            // 
            // printingScale
            // 
            this.printingScale.Location = new System.Drawing.Point(100, 140);
            this.printingScale.Name = "printingScale";
            this.printingScale.Size = new System.Drawing.Size(120, 20);
            this.printingScale.TabIndex = 8;
            this.printingScale.ValueChanged += new System.EventHandler(this.printingScale_ValueChanged);
            // 
            // whitespace
            // 
            this.whitespace.Location = new System.Drawing.Point(100, 98);
            this.whitespace.Name = "whitespace";
            this.whitespace.Size = new System.Drawing.Size(120, 20);
            this.whitespace.TabIndex = 7;
            this.whitespace.ValueChanged += new System.EventHandler(this.whitespace_ValueChanged);
            // 
            // borderWidth
            // 
            this.borderWidth.Location = new System.Drawing.Point(99, 58);
            this.borderWidth.Name = "borderWidth";
            this.borderWidth.Size = new System.Drawing.Size(120, 20);
            this.borderWidth.TabIndex = 6;
            this.borderWidth.ValueChanged += new System.EventHandler(this.borderWidth_ValueChanged);
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
            // whitespaceLabel
            // 
            this.whitespaceLabel.AutoSize = true;
            this.whitespaceLabel.Location = new System.Drawing.Point(16, 100);
            this.whitespaceLabel.Name = "whitespaceLabel";
            this.whitespaceLabel.Size = new System.Drawing.Size(67, 13);
            this.whitespaceLabel.TabIndex = 4;
            this.whitespaceLabel.Text = "Whitespace:";
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
            // borderWidthLabel
            // 
            this.borderWidthLabel.AutoSize = true;
            this.borderWidthLabel.Location = new System.Drawing.Point(16, 60);
            this.borderWidthLabel.Name = "borderWidthLabel";
            this.borderWidthLabel.Size = new System.Drawing.Size(72, 13);
            this.borderWidthLabel.TabIndex = 2;
            this.borderWidthLabel.Text = "Border Width:";
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
            // height
            // 
            this.height.Location = new System.Drawing.Point(100, 19);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(120, 20);
            this.height.TabIndex = 0;
            this.height.ValueChanged += new System.EventHandler(this.height_ValueChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.generalTab);
            this.Name = "Options";
            this.Size = new System.Drawing.Size(434, 273);
            this.generalTab.ResumeLayout(false);
            this.dataTab.ResumeLayout(false);
            this.dataTab.PerformLayout();
            this.add2DComponentGroup.ResumeLayout(false);
            this.add2DComponentGroup.PerformLayout();
            this.appearanceTab.ResumeLayout(false);
            this.appearanceTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitespace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl generalTab;
        private System.Windows.Forms.TabPage appearanceTab;
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
        private System.Windows.Forms.Label rotationLabel;
        private System.Windows.Forms.NumericUpDown rotation;
        private System.Windows.Forms.TabPage dataTab;
        private System.Windows.Forms.Label componentTypeLabel;
        private System.Windows.Forms.Label primaryDataLabel;
        private System.Windows.Forms.Label secondaryDataLabel;
        private System.Windows.Forms.ComboBox componentType;
        private System.Windows.Forms.CheckBox add2DComponent;
        private System.Windows.Forms.TextBox secondaryData;
        private System.Windows.Forms.TextBox primaryData;
        private System.Windows.Forms.GroupBox add2DComponentGroup;
    }
}
