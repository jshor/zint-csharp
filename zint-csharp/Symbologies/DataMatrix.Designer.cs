namespace ZintWrapper.Symbologies
{
    partial class DataMatrix
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
            this.ecc200GroupBox = new System.Windows.Forms.GroupBox();
            this.rectangleSupression = new System.Windows.Forms.CheckBox();
            this.gs1DataMode = new System.Windows.Forms.RadioButton();
            this.standardMode = new System.Windows.Forms.RadioButton();
            this.option2 = new ZintWrapper.Symbologies.OptionBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.ecc200GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ecc200GroupBox
            // 
            this.ecc200GroupBox.Controls.Add(this.sizeLabel);
            this.ecc200GroupBox.Controls.Add(this.option2);
            this.ecc200GroupBox.Controls.Add(this.rectangleSupression);
            this.ecc200GroupBox.Controls.Add(this.gs1DataMode);
            this.ecc200GroupBox.Controls.Add(this.standardMode);
            this.ecc200GroupBox.Location = new System.Drawing.Point(12, 21);
            this.ecc200GroupBox.Name = "ecc200GroupBox";
            this.ecc200GroupBox.Size = new System.Drawing.Size(403, 208);
            this.ecc200GroupBox.TabIndex = 5;
            this.ecc200GroupBox.TabStop = false;
            this.ecc200GroupBox.Text = "ECC 200 Options";
            // 
            // rectangleSupression
            // 
            this.rectangleSupression.AutoSize = true;
            this.rectangleSupression.Location = new System.Drawing.Point(38, 112);
            this.rectangleSupression.Name = "rectangleSupression";
            this.rectangleSupression.Size = new System.Drawing.Size(255, 17);
            this.rectangleSupression.TabIndex = 9;
            this.rectangleSupression.Text = "Suppress rectangular symbols in automatic mode";
            this.rectangleSupression.UseVisualStyleBackColor = true;
            this.rectangleSupression.CheckedChanged += new System.EventHandler(this.rectangleSupression_CheckedChanged);
            // 
            // gs1DataMode
            // 
            this.gs1DataMode.AutoSize = true;
            this.gs1DataMode.Location = new System.Drawing.Point(213, 76);
            this.gs1DataMode.Name = "gs1DataMode";
            this.gs1DataMode.Size = new System.Drawing.Size(101, 17);
            this.gs1DataMode.TabIndex = 7;
            this.gs1DataMode.TabStop = true;
            this.gs1DataMode.Text = "GS1 Data mode";
            this.gs1DataMode.UseVisualStyleBackColor = true;
            // 
            // standardMode
            // 
            this.standardMode.AutoSize = true;
            this.standardMode.Checked = true;
            this.standardMode.Location = new System.Drawing.Point(38, 76);
            this.standardMode.Name = "standardMode";
            this.standardMode.Size = new System.Drawing.Size(97, 17);
            this.standardMode.TabIndex = 6;
            this.standardMode.TabStop = true;
            this.standardMode.Text = "Standard mode";
            this.standardMode.UseVisualStyleBackColor = true;
            // 
            // option2
            // 
            this.option2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option2.FormattingEnabled = true;
            this.option2.Location = new System.Drawing.Point(213, 35);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(174, 21);
            this.option2.TabIndex = 4;
            this.option2.SelectedIndexChanged += new System.EventHandler(this.option2_SelectedIndexChanged);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(35, 43);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(30, 13);
            this.sizeLabel.TabIndex = 7;
            this.sizeLabel.Text = "Size:";
            // 
            // DataMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ecc200GroupBox);
            this.Name = "DataMatrix";
            this.Size = new System.Drawing.Size(428, 243);
            this.Load += new System.EventHandler(this.Aztec_Load);
            this.ecc200GroupBox.ResumeLayout(false);
            this.ecc200GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ecc200GroupBox;
        private System.Windows.Forms.RadioButton gs1DataMode;
        private System.Windows.Forms.RadioButton standardMode;
        private OptionBox option2;
        private System.Windows.Forms.CheckBox rectangleSupression;
        private System.Windows.Forms.Label sizeLabel;
    }
}
