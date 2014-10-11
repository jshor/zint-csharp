namespace ZintWrapper.Symbologies
{
    partial class CodeOne
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
            this.encodingOptions = new System.Windows.Forms.GroupBox();
            this.option2 = new ZintWrapper.Symbologies.OptionBox();
            this.encodingMode = new System.Windows.Forms.Label();
            this.symbolSizeLabel = new System.Windows.Forms.Label();
            this.gs1DataMode = new System.Windows.Forms.RadioButton();
            this.stdRadio = new System.Windows.Forms.RadioButton();
            this.encodingOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // encodingOptions
            // 
            this.encodingOptions.Controls.Add(this.option2);
            this.encodingOptions.Controls.Add(this.encodingMode);
            this.encodingOptions.Controls.Add(this.symbolSizeLabel);
            this.encodingOptions.Controls.Add(this.gs1DataMode);
            this.encodingOptions.Controls.Add(this.stdRadio);
            this.encodingOptions.Location = new System.Drawing.Point(13, 11);
            this.encodingOptions.Name = "encodingOptions";
            this.encodingOptions.Size = new System.Drawing.Size(403, 123);
            this.encodingOptions.TabIndex = 3;
            this.encodingOptions.TabStop = false;
            this.encodingOptions.Text = "Encoding options";
            // 
            // option2
            // 
            this.option2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option2.FormattingEnabled = true;
            this.option2.Location = new System.Drawing.Point(201, 29);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(184, 21);
            this.option2.TabIndex = 5;
            this.option2.SelectedIndexChanged += new System.EventHandler(this.encodingRadioButton_OptionsChanged);
            // 
            // encodingMode
            // 
            this.encodingMode.AutoSize = true;
            this.encodingMode.Location = new System.Drawing.Point(23, 67);
            this.encodingMode.Name = "encodingMode";
            this.encodingMode.Size = new System.Drawing.Size(84, 13);
            this.encodingMode.TabIndex = 4;
            this.encodingMode.Text = "Encoding mode:";
            // 
            // symbolSizeLabel
            // 
            this.symbolSizeLabel.AutoSize = true;
            this.symbolSizeLabel.Location = new System.Drawing.Point(23, 32);
            this.symbolSizeLabel.Name = "symbolSizeLabel";
            this.symbolSizeLabel.Size = new System.Drawing.Size(65, 13);
            this.symbolSizeLabel.TabIndex = 3;
            this.symbolSizeLabel.Text = "Symbol size:";
            // 
            // gs1DataMode
            // 
            this.gs1DataMode.AutoSize = true;
            this.gs1DataMode.Location = new System.Drawing.Point(201, 88);
            this.gs1DataMode.Name = "gs1DataMode";
            this.gs1DataMode.Size = new System.Drawing.Size(99, 17);
            this.gs1DataMode.TabIndex = 2;
            this.gs1DataMode.Text = "GS1 data mode";
            this.gs1DataMode.UseVisualStyleBackColor = true;
            this.gs1DataMode.CheckedChanged += new System.EventHandler(this.encodingRadioButton_OptionsChanged);
            // 
            // stdRadio
            // 
            this.stdRadio.AutoSize = true;
            this.stdRadio.Checked = true;
            this.stdRadio.Location = new System.Drawing.Point(26, 88);
            this.stdRadio.Name = "stdRadio";
            this.stdRadio.Size = new System.Drawing.Size(68, 17);
            this.stdRadio.TabIndex = 0;
            this.stdRadio.TabStop = true;
            this.stdRadio.Text = "Standard";
            this.stdRadio.UseVisualStyleBackColor = true;
            this.stdRadio.CheckedChanged += new System.EventHandler(this.encodingRadioButton_OptionsChanged);
            // 
            // CodeOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.encodingOptions);
            this.Name = "CodeOne";
            this.Size = new System.Drawing.Size(428, 243);
            this.Load += new System.EventHandler(this.CodeOne_Load);
            this.encodingOptions.ResumeLayout(false);
            this.encodingOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox encodingOptions;
        private OptionBox option2;
        private System.Windows.Forms.Label encodingMode;
        private System.Windows.Forms.Label symbolSizeLabel;
        private System.Windows.Forms.RadioButton gs1DataMode;
        private System.Windows.Forms.RadioButton stdRadio;
    }
}
