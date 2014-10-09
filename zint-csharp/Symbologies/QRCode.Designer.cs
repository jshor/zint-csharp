namespace ZintWrapper.Symbologies
{
    partial class QRCode
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
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.option2Selected = new System.Windows.Forms.RadioButton();
            this.autoResize = new System.Windows.Forms.RadioButton();
            this.option1Selected = new System.Windows.Forms.RadioButton();
            this.encodingGroupBox = new System.Windows.Forms.GroupBox();
            this.hibcMode = new System.Windows.Forms.RadioButton();
            this.gs1DataMode = new System.Windows.Forms.RadioButton();
            this.standardMode = new System.Windows.Forms.RadioButton();
            this.option2 = new ZintWrapper.Symbologies.OptionBox();
            this.option1 = new ZintWrapper.Symbologies.OptionBox();
            this.sizeGroupBox.SuspendLayout();
            this.encodingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.option2);
            this.sizeGroupBox.Controls.Add(this.option1);
            this.sizeGroupBox.Controls.Add(this.option2Selected);
            this.sizeGroupBox.Controls.Add(this.autoResize);
            this.sizeGroupBox.Controls.Add(this.option1Selected);
            this.sizeGroupBox.Location = new System.Drawing.Point(13, 15);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(403, 113);
            this.sizeGroupBox.TabIndex = 8;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Symbology size";
            // 
            // option2Selected
            // 
            this.option2Selected.AutoSize = true;
            this.option2Selected.Location = new System.Drawing.Point(20, 77);
            this.option2Selected.Name = "option2Selected";
            this.option2Selected.Size = new System.Drawing.Size(90, 17);
            this.option2Selected.TabIndex = 2;
            this.option2Selected.TabStop = true;
            this.option2Selected.Text = "Adjust size to:";
            this.option2Selected.UseVisualStyleBackColor = true;
            this.option2Selected.CheckedChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // autoResize
            // 
            this.autoResize.AutoSize = true;
            this.autoResize.Checked = true;
            this.autoResize.Location = new System.Drawing.Point(20, 17);
            this.autoResize.Name = "autoResize";
            this.autoResize.Size = new System.Drawing.Size(110, 17);
            this.autoResize.TabIndex = 0;
            this.autoResize.TabStop = true;
            this.autoResize.Text = "Automatic resizing";
            this.autoResize.UseVisualStyleBackColor = true;
            this.autoResize.CheckedChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // option1Selected
            // 
            this.option1Selected.AutoSize = true;
            this.option1Selected.Location = new System.Drawing.Point(20, 47);
            this.option1Selected.Name = "option1Selected";
            this.option1Selected.Size = new System.Drawing.Size(164, 17);
            this.option1Selected.TabIndex = 1;
            this.option1Selected.TabStop = true;
            this.option1Selected.Text = "Add minimum error correction:";
            this.option1Selected.UseVisualStyleBackColor = true;
            this.option1Selected.CheckedChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // encodingGroupBox
            // 
            this.encodingGroupBox.Controls.Add(this.hibcMode);
            this.encodingGroupBox.Controls.Add(this.gs1DataMode);
            this.encodingGroupBox.Controls.Add(this.standardMode);
            this.encodingGroupBox.Location = new System.Drawing.Point(13, 134);
            this.encodingGroupBox.Name = "encodingGroupBox";
            this.encodingGroupBox.Size = new System.Drawing.Size(403, 93);
            this.encodingGroupBox.TabIndex = 7;
            this.encodingGroupBox.TabStop = false;
            this.encodingGroupBox.Text = "Encoding mode";
            // 
            // hibcMode
            // 
            this.hibcMode.AutoSize = true;
            this.hibcMode.Location = new System.Drawing.Point(20, 58);
            this.hibcMode.Name = "hibcMode";
            this.hibcMode.Size = new System.Drawing.Size(109, 17);
            this.hibcMode.TabIndex = 8;
            this.hibcMode.TabStop = true;
            this.hibcMode.Text = "HIBC Aztec mode";
            this.hibcMode.UseVisualStyleBackColor = true;
            this.hibcMode.CheckedChanged += new System.EventHandler(this.encodingRadioButton_OptionsChanged);
            // 
            // gs1DataMode
            // 
            this.gs1DataMode.AutoSize = true;
            this.gs1DataMode.Location = new System.Drawing.Point(190, 26);
            this.gs1DataMode.Name = "gs1DataMode";
            this.gs1DataMode.Size = new System.Drawing.Size(101, 17);
            this.gs1DataMode.TabIndex = 7;
            this.gs1DataMode.TabStop = true;
            this.gs1DataMode.Text = "GS1 Data mode";
            this.gs1DataMode.UseVisualStyleBackColor = true;
            this.gs1DataMode.CheckedChanged += new System.EventHandler(this.encodingRadioButton_OptionsChanged);
            // 
            // standardMode
            // 
            this.standardMode.AutoSize = true;
            this.standardMode.Checked = true;
            this.standardMode.Location = new System.Drawing.Point(20, 26);
            this.standardMode.Name = "standardMode";
            this.standardMode.Size = new System.Drawing.Size(97, 17);
            this.standardMode.TabIndex = 6;
            this.standardMode.TabStop = true;
            this.standardMode.Text = "Standard mode";
            this.standardMode.UseVisualStyleBackColor = true;
            this.standardMode.CheckedChanged += new System.EventHandler(this.encodingRadioButton_OptionsChanged);
            // 
            // option2
            // 
            this.option2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option2.FormattingEnabled = true;
            this.option2.Location = new System.Drawing.Point(190, 77);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(195, 21);
            this.option2.TabIndex = 4;
            this.option2.SelectedIndexChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // option1
            // 
            this.option1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option1.FormattingEnabled = true;
            this.option1.Location = new System.Drawing.Point(190, 43);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(195, 21);
            this.option1.TabIndex = 3;
            this.option1.SelectedIndexChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // QRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.encodingGroupBox);
            this.Name = "QRCode";
            this.Size = new System.Drawing.Size(428, 243);
            this.Load += new System.EventHandler(this.QRCode_Load);
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            this.encodingGroupBox.ResumeLayout(false);
            this.encodingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sizeGroupBox;
        private OptionBox option2;
        private OptionBox option1;
        private System.Windows.Forms.RadioButton option2Selected;
        private System.Windows.Forms.RadioButton autoResize;
        private System.Windows.Forms.RadioButton option1Selected;
        private System.Windows.Forms.GroupBox encodingGroupBox;
        private System.Windows.Forms.RadioButton hibcMode;
        private System.Windows.Forms.RadioButton gs1DataMode;
        private System.Windows.Forms.RadioButton standardMode;
    }
}
