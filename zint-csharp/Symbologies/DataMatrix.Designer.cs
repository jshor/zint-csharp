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
            this.encodingGroupBox = new System.Windows.Forms.GroupBox();
            this.hibcMode = new System.Windows.Forms.RadioButton();
            this.option2 = new ZintWrapper.Symbologies.OptionBox();
            this.gs1DataMode = new System.Windows.Forms.RadioButton();
            this.standardMode = new System.Windows.Forms.RadioButton();
            this.rectangleSupression = new System.Windows.Forms.CheckBox();
            this.encodingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // encodingGroupBox
            // 
            this.encodingGroupBox.Controls.Add(this.rectangleSupression);
            this.encodingGroupBox.Controls.Add(this.hibcMode);
            this.encodingGroupBox.Controls.Add(this.gs1DataMode);
            this.encodingGroupBox.Controls.Add(this.standardMode);
            this.encodingGroupBox.Location = new System.Drawing.Point(12, 77);
            this.encodingGroupBox.Name = "encodingGroupBox";
            this.encodingGroupBox.Size = new System.Drawing.Size(403, 152);
            this.encodingGroupBox.TabIndex = 5;
            this.encodingGroupBox.TabStop = false;
            this.encodingGroupBox.Text = "Encoding mode";
            // 
            // hibcMode
            // 
            this.hibcMode.AutoSize = true;
            this.hibcMode.Location = new System.Drawing.Point(38, 71);
            this.hibcMode.Name = "hibcMode";
            this.hibcMode.Size = new System.Drawing.Size(109, 17);
            this.hibcMode.TabIndex = 8;
            this.hibcMode.TabStop = true;
            this.hibcMode.Text = "HIBC Aztec mode";
            this.hibcMode.UseVisualStyleBackColor = true;
            // 
            // option2
            // 
            this.option2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option2.FormattingEnabled = true;
            this.option2.Location = new System.Drawing.Point(225, 21);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(190, 21);
            this.option2.TabIndex = 4;
            this.option2.SelectedIndexChanged += new System.EventHandler(this.option2_SelectedIndexChanged);
            // 
            // gs1DataMode
            // 
            this.gs1DataMode.AutoSize = true;
            this.gs1DataMode.Location = new System.Drawing.Point(213, 39);
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
            this.standardMode.Location = new System.Drawing.Point(38, 39);
            this.standardMode.Name = "standardMode";
            this.standardMode.Size = new System.Drawing.Size(97, 17);
            this.standardMode.TabIndex = 6;
            this.standardMode.TabStop = true;
            this.standardMode.Text = "Standard mode";
            this.standardMode.UseVisualStyleBackColor = true;
            // 
            // rectangleSupression
            // 
            this.rectangleSupression.AutoSize = true;
            this.rectangleSupression.Location = new System.Drawing.Point(38, 110);
            this.rectangleSupression.Name = "rectangleSupression";
            this.rectangleSupression.Size = new System.Drawing.Size(122, 17);
            this.rectangleSupression.TabIndex = 9;
            this.rectangleSupression.Text = "rectangleSupression";
            this.rectangleSupression.UseVisualStyleBackColor = true;
            this.rectangleSupression.CheckedChanged += new System.EventHandler(this.rectangleSupression_CheckedChanged);
            // 
            // DataMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.encodingGroupBox);
            this.Controls.Add(this.option2);
            this.Name = "DataMatrix";
            this.Size = new System.Drawing.Size(428, 243);
            this.Load += new System.EventHandler(this.Aztec_Load);
            this.encodingGroupBox.ResumeLayout(false);
            this.encodingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox encodingGroupBox;
        private System.Windows.Forms.RadioButton hibcMode;
        private System.Windows.Forms.RadioButton gs1DataMode;
        private System.Windows.Forms.RadioButton standardMode;
        private OptionBox option2;
        private System.Windows.Forms.CheckBox rectangleSupression;
    }
}
